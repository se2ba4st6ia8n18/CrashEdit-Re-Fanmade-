using AltUI.Forms;
using CrashEdit.CE.Properties;
using CrashEdit.CrashUI.Properties;
using System;
using System.Media;

namespace CrashEdit.CE
{
    public partial class ZoneEditorForm : DarkForm
    {
        public ZoneEditorForm()
        {
            InitializeComponent();
            Icon = Embeds.GetIcon("Plugin");
        }

        private void cmdBrowseOutput_Click(object sender, EventArgs e)
        {
            using FolderBrowserDialog fbd = new();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txtOutputDir.Text = fbd.SelectedPath;
            }
        }

        private void cmdCreate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtOutputDir.Text) || !Directory.Exists(txtOutputDir.Text))
            {
                DarkMessageBox.ShowError("Please choose a valid output folder first.", Resources.Title_Error);
                return;
            }

            string error = CrashEdit.Crash.Entry.CheckEIDErrors(txtEID.Text, false);
            if (error != string.Empty)
            {
                DarkMessageBox.ShowError(error, "EID Error");
                return;
            }

            try
            {
                ZoneEditor.CreateBlank(
                    outputDirectory: txtOutputDir.Text,
                    ename: txtEID.Text,
                    isC3: chkCrash3.Checked,
                    x: (int)numX.Value,
                    y: (int)numY.Value,
                    z: (int)numZ.Value,
                    width: (int)numWidth.Value,
                    height: (int)numHeight.Value,
                    depth: (int)numDepth.Value,
                    collisionDepthX: (ushort)numCollisionDepthX.Value,
                    collisionDepthY: (ushort)numCollisionDepthY.Value,
                    collisionDepthZ: (ushort)numCollisionDepthZ.Value,
                    worldCount: (int)numWorldCount.Value,
                    infoCount: (int)numInfoCount.Value,
                    cameraCount: (int)numCameraCount.Value,
                    entityCount: (int)numEntityCount.Value,
                    zoneCount: (int)numZoneCount.Value,
                    musicEname: txtMusic.Text,
                    addSelfZoneLink: chkSelfLink.Checked);

                SystemSounds.Asterisk.Play();
                DarkMessageBox.ShowInformation("Blank zone entry created successfully.", "Success");
            }
            catch (Exception ex)
            {
                DarkMessageBox.ShowError($"Error creating zone:\n\n{ex.Message}", Resources.Title_Error);
            }
        }
    }
}
