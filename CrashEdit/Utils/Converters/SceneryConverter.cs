using CrashEdit.Crash;
using OpenTK.Mathematics;
using System.Globalization;
using System.Media;

namespace CrashEdit.CE
{
    /// <summary>
    /// Imports a Wavefront OBJ (as produced by this tool's own Crash 2/3 Scenery OBJ exporter,
    /// see CrashEdit.Exporters.SceneryExtensions.AddScenery) back into a SceneryEntry (.nsentry).
    ///
    /// Scope: reconstructs geometry (vertices, per-vertex color, triangles, quads) using the exact
    /// inverse of the export math in SceneryExtensions. It does NOT reconstruct texture/UV data or
    /// animated textures - the Crash 2/3 scenery texture-info layout isn't fully documented (see
    /// cbhacks/CrashEdit#112), so faces are imported untextured (Texture = 0, Animated = false).
    /// Fill in texture reconstruction once/if that format is confirmed.
    /// </summary>
    public static class SceneryConverter
    {
        // Info (header) layout, per SceneryEntryLoaderInternal.LoadScenery - MUST be exactly 76 bytes:
        //   0: XOffset (int32)          4: YOffset (int32)         8: ZOffset (int32)
        //  12: IsSky (int32)           16: VertexCount (int32)    20: TriangleCount (int32)
        //  24: QuadCount (int32)       28: TextureCount (int32)   32: ColorCount (int32)
        //  36: AnimatedTextureCount    40: TPAGCount (int32)      44-75: up to 8 TPAG entries (int32 each)
        private const int InfoSize = 76;

        public static void Import(string objFile, string ename, int xOffset, int yOffset, int zOffset, bool isSky, bool isC3)
        {
            try
            {
                if (Entry.CheckEIDErrors(ename, false) is string err && err != string.Empty)
                    throw new ArgumentException(err);

                var objVertices = new List<Vector3>();
                var objColors = new List<Vector3?>(); // parallel to objVertices; null = no color given
                var faces = new List<int[]>();

                foreach (string rawLine in File.ReadAllLines(objFile))
                {
                    string line = rawLine.Trim();
                    if (line.Length == 0 || line.StartsWith('#'))
                        continue;

                    string[] parts = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    if (parts.Length == 0)
                        continue;

                    switch (parts[0])
                    {
                        case "v":
                            {
                                // "v x y z" or "v x y z r g b"
                                float x = float.Parse(parts[1], CultureInfo.InvariantCulture);
                                float y = float.Parse(parts[2], CultureInfo.InvariantCulture);
                                float z = float.Parse(parts[3], CultureInfo.InvariantCulture);
                                objVertices.Add(new Vector3(x, y, z));

                                if (parts.Length >= 7)
                                {
                                    float r = float.Parse(parts[4], CultureInfo.InvariantCulture);
                                    float g = float.Parse(parts[5], CultureInfo.InvariantCulture);
                                    float b = float.Parse(parts[6], CultureInfo.InvariantCulture);
                                    objColors.Add(new Vector3(r, g, b));
                                }
                                else
                                {
                                    objColors.Add(null);
                                }
                                break;
                            }
                        case "f":
                            {
                                // "f i" or "f i/j" or "f i/j/k" or "f i//k", triangles or quads only
                                var indices = new int[parts.Length - 1];
                                for (int i = 1; i < parts.Length; i++)
                                {
                                    string token = parts[i].Split('/')[0];
                                    int idx = int.Parse(token, CultureInfo.InvariantCulture);
                                    // OBJ indices are 1-based and may be negative (relative to current count)
                                    idx = idx > 0 ? idx - 1 : objVertices.Count + idx;
                                    indices[i - 1] = idx;
                                }
                                if (indices.Length == 3 || indices.Length == 4)
                                    faces.Add(indices);
                                else
                                    Console.WriteLine($"    Skipping face with {indices.Length} vertices (only tris/quads are supported)");
                                break;
                            }
                    }
                }

                if (objVertices.Count == 0)
                    throw new InvalidOperationException("No vertices found in OBJ file.");

                // Build a deduplicated color table (SceneryVertex.Color is only 10 bits: 0-1023)
                var colorTable = new List<SceneryColor>();
                var colorLookup = new Dictionary<(byte, byte, byte), int>();
                var defaultColor = new SceneryColor(255, 255, 255);

                int GetColorIndex(Vector3? c)
                {
                    byte r, g, b;
                    if (c.HasValue)
                    {
                        r = (byte)Math.Clamp((int)MathF.Round(c.Value.X * 255f), 0, 255);
                        g = (byte)Math.Clamp((int)MathF.Round(c.Value.Y * 255f), 0, 255);
                        b = (byte)Math.Clamp((int)MathF.Round(c.Value.Z * 255f), 0, 255);
                    }
                    else
                    {
                        r = defaultColor.Red;
                        g = defaultColor.Green;
                        b = defaultColor.Blue;
                    }

                    if (colorLookup.TryGetValue((r, g, b), out int existing))
                        return existing;

                    if (colorTable.Count >= 1024)
                        throw new InvalidOperationException("Too many unique vertex colors (limit is 1024).");

                    int index = colorTable.Count;
                    colorTable.Add(new SceneryColor(r, g, b));
                    colorLookup[(r, g, b)] = index;
                    return index;
                }

                // Rebuild SceneryVertex list using the exact inverse of SceneryExtensions.AddScenery:
                //   objPos = (internal * 16 + offset) / GameScales.WorldC1
                // => internal = round((objPos * GameScales.WorldC1 - offset) / 16)
                var vertices = new List<SceneryVertex>(objVertices.Count);
                for (int i = 0; i < objVertices.Count; i++)
                {
                    Vector3 v = objVertices[i];
                    int ix = (int)MathF.Round((v.X * GameScales.WorldC1 - xOffset) / 16f);
                    int iy = (int)MathF.Round((v.Y * GameScales.WorldC1 - yOffset) / 16f);
                    int iz = (int)MathF.Round((v.Z * GameScales.WorldC1 - zOffset) / 16f);

                    int colorIndex = GetColorIndex(objColors[i]);
                    int unknownX = (colorIndex >> 4) & 0xF;
                    int unknownZ = colorIndex & 0xF;
                    int unknownY = (colorIndex >> 8) & 0x3; // top 2 bits of UnknownY hold FX, left as 0

                    vertices.Add(new SceneryVertex(ix, iy, iz, unknownX, unknownY, unknownZ, isC3));
                }

                var triangles = new List<SceneryTriangle>();
                var quads = new List<SceneryQuad>();
                foreach (int[] face in faces)
                {
                    foreach (int idx in face)
                    {
                        if (idx < 0 || idx >= vertices.Count)
                            throw new InvalidOperationException($"Face references out-of-range vertex index {idx}.");
                    }

                    if (face.Length == 3)
                    {
                        triangles.Add(new SceneryTriangle(face[0], face[1], face[2], texture: 0, animated: false));
                    }
                    else // 4
                    {
                        quads.Add(new SceneryQuad(face[0], face[1], face[2], face[3], texture: 0, unknown: 0, animated: false));
                    }
                }

                byte[] info = new byte[InfoSize];
                BitConv.ToInt32(info, 0, xOffset);
                BitConv.ToInt32(info, 4, yOffset);
                BitConv.ToInt32(info, 8, zOffset);
                BitConv.ToInt32(info, 12, isSky ? 1 : 0);
                BitConv.ToInt32(info, 16, vertices.Count);
                BitConv.ToInt32(info, 20, triangles.Count);
                BitConv.ToInt32(info, 24, quads.Count);
                BitConv.ToInt32(info, 28, 0);            // TextureCount (no textures reconstructed)
                BitConv.ToInt32(info, 32, colorTable.Count);
                BitConv.ToInt32(info, 36, 0);            // AnimatedTextureCount
                BitConv.ToInt32(info, 40, 0);            // TPAGCount
                // bytes 44-75: up to 8 TPAG entries, left as 0 (no texture pages referenced)

                SceneryEntry scenery = new(
                    scenery: new Scenery(),
                    info: info,
                    vertices: vertices,
                    triangles: triangles,
                    quads: quads,
                    textures: [],
                    colors: colorTable,
                    animatedtextures: [],
                    is_c3: isC3,
                    eid: Entry.ENameToEID(ename));

                byte[] fileBytes = scenery.Save();
                string saveDirectory = Path.GetDirectoryName(objFile) ?? ".";
                string savePath = Path.Combine(saveDirectory, $"{ename}.nsentry");
                File.WriteAllBytes(savePath, fileBytes);

                Console.WriteLine($"Imported {vertices.Count} vertices, {triangles.Count} triangles, {quads.Count} quads, {colorTable.Count} colors.");
                Console.WriteLine($"    Saved scenery entry: {savePath}");

                SystemSounds.Asterisk.Play();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
