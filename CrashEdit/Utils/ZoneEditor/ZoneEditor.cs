using CrashEdit.Crash;
using System.IO;
using System;
using System.Media;

namespace CrashEdit.CE
{
    /// <summary>
    /// Creates a brand-new, blank ZoneEntry (.nsentry) from scratch - no NSF/tree required.
    /// Mirrors the header construction already used by ZoneConverter.Import, but exposes every
    /// raw field (dimensions, offsets, collision depth, header counts) directly instead of
    /// deriving them from an OBJ/JSON import.
    ///
    /// The zone is created with zero entities and zero collision cells (an empty Layout body,
    /// same as ZoneConverter's blank-zone case) - add entities/collision afterwards via the
    /// normal NSF tree, ZoneConverter (OBJ import), or the in-app Zone Header editor.
    /// </summary>
    public static class ZoneEditor
    {
        // Old (Crash 2 / Crash 3 beta) header: 0x318 bytes, 8 world/zone link slots.
        private const int OldHeaderSize = 0x318;
        // New (Crash 3 final) header: 0x358 bytes, 16 world/zone link slots.
        private const int NewHeaderSize = 0x358;
        private const int WorldZoneSlotsOld = 8;
        private const int WorldZoneSlotsNew = 16;

        // Blank Layout body: just large enough for the fixed X/Y/Z/Width/Height/Depth/CollisionDepth
        // fields ZoneEntry writes directly (up to offset 0x24), no collision cell data.
        private const int BlankLayoutSize = 0x28;

        public static void CreateBlank(
            string outputDirectory,
            string ename,
            bool isC3,
            int x, int y, int z,
            int width, int height, int depth,
            ushort collisionDepthX, ushort collisionDepthY, ushort collisionDepthZ,
            int worldCount, int infoCount, int cameraCount, int entityCount, int zoneCount,
            string musicEname,
            bool addSelfZoneLink)
        {
            try
            {
                if (Entry.CheckEIDErrors(ename, false) is string err && err != string.Empty)
                    throw new ArgumentException(err);

                int eid = Entry.ENameToEID(ename);

                int music = Entry.NullEID;
                if (!string.IsNullOrWhiteSpace(musicEname))
                {
                    if (Entry.CheckEIDErrors(musicEname, true) is string musicErr && musicErr != string.Empty)
                        throw new ArgumentException($"Music EID: {musicErr}");
                    music = Entry.ENameToEID(musicEname);
                }

                ZoneHeader header = isC3
                    ? ZoneHeader.LoadNew(new byte[NewHeaderSize])
                    : ZoneHeader.Load(new byte[OldHeaderSize]);

                header.WorldCount = worldCount;
                header.InfoCount = infoCount;
                header.CameraCount = cameraCount;
                header.EntityCount = entityCount;
                header.ZoneCount = zoneCount;
                header.Music = music;

                if (addSelfZoneLink)
                {
                    header.Zones[0] = eid;
                    header.ZoneLinkTypes[0] = 0x1E;
                }

                int slots = isC3 ? WorldZoneSlotsNew : WorldZoneSlotsOld;
                if (header.Worlds.Count != slots || header.Zones.Count != slots)
                    throw new InvalidOperationException("Unexpected world/zone link slot count from ZoneHeader.");

                ZoneEntry zone = new(
                    zoneheader: header,
                    layout: new byte[BlankLayoutSize],
                    entities: [],
                    eid: eid)
                {
                    X = x,
                    Y = y,
                    Z = z,
                    Width = width,
                    Height = height,
                    Depth = depth,
                    CollisionDepthX = collisionDepthX,
                    CollisionDepthY = collisionDepthY,
                    CollisionDepthZ = collisionDepthZ,
                };

                byte[] fileBytes = zone.Save();
                string savePath = Path.Combine(outputDirectory, $"{ename}.nsentry");
                File.WriteAllBytes(savePath, fileBytes);

                Console.WriteLine($"Created blank zone entry: {savePath}");
                SystemSounds.Asterisk.Play();

            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}