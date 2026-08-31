using AltUI.Forms;
using CrashEdit.CE.Properties;
using CrashEdit.CrashUI.Properties;
using System;
using System.Media;

namespace CrashEdit.CE
{
    public partial class SceneryConverterForm : DarkForm
    {
        public SceneryConverterForm()
        {
            InitializeComponent();
            Icon = Embeds.GetIcon("Plugin");
        }

        private void cmdBrowse_Click(object sender, EventArgs e)
        {
            using OpenFileDialog ofd = new();
            ofd.Filter = "Wavefront OBJ (*.obj)|*.obj|All Files (*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = ofd.FileName;
                if (string.IsNullOrWhiteSpace(txtEID.Text))
                    txtEID.Text = System.IO.Path.GetFileNameWithoutExtension(ofd.FileName);

                cmdConvert.Enabled = true;
            }
        }

        private void cmdConvert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFilePath.Text) || !File.Exists(txtFilePath.Text))
            {
                DarkMessageBox.ShowError("Please select a valid OBJ file first.", Resources.Title_Error);
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
                SceneryConverter.Import(
                    objFile: txtFilePath.Text,
                    ename: txtEID.Text,
                    xOffset: (int)numXOffset.Value,
                    yOffset: (int)numYOffset.Value,
                    zOffset: (int)numZOffset.Value,
                    isSky: chkSky.Checked,
                    isC3: chkCrash3.Checked);

                SystemSounds.Asterisk.Play();
                DarkMessageBox.ShowInformation("Scenery entry converted successfully.", "Success");
            }
            catch (Exception ex)
            {
                DarkMessageBox.ShowError($"Error converting file:\n\n{ex.Message}", Resources.Title_Error);
            }
        }
    }
}
