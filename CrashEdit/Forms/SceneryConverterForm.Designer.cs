using AltUI.Controls;

namespace CrashEdit.CE
{
    partial class SceneryConverterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblFile = new Label();
            txtFilePath = new DarkTextBox();
            cmdBrowse = new DarkButton();
            lblEID = new Label();
            txtEID = new DarkTextBox();
            lblXOffset = new Label();
            numXOffset = new DarkNumericUpDown();
            lblYOffset = new Label();
            numYOffset = new DarkNumericUpDown();
            lblZOffset = new Label();
            numZOffset = new DarkNumericUpDown();
            chkSky = new CheckBox();
            chkCrash3 = new CheckBox();
            cmdConvert = new DarkButton();
            ((System.ComponentModel.ISupportInitialize)numXOffset).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numYOffset).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numZOffset).BeginInit();
            SuspendLayout();
            // 
            // lblFile
            // 
            lblFile.AutoSize = true;
            lblFile.Location = new Point(12, 15);
            lblFile.Name = "lblFile";
            lblFile.Size = new Size(52, 15);
            lblFile.TabIndex = 0;
            lblFile.Text = "OBJ File:";
            // 
            // txtFilePath
            // 
            txtFilePath.Location = new Point(80, 12);
            txtFilePath.Name = "txtFilePath";
            txtFilePath.ReadOnly = true;
            txtFilePath.Size = new Size(300, 23);
            txtFilePath.TabIndex = 1;
            // 
            // cmdBrowse
            // 
            cmdBrowse.BorderColour = Color.Empty;
            cmdBrowse.CustomColour = false;
            cmdBrowse.FlatBottom = false;
            cmdBrowse.FlatTop = false;
            cmdBrowse.Location = new Point(386, 11);
            cmdBrowse.Name = "cmdBrowse";
            cmdBrowse.Padding = new Padding(5);
            cmdBrowse.Size = new Size(90, 25);
            cmdBrowse.TabIndex = 2;
            cmdBrowse.Text = "Browse...";
            cmdBrowse.Click += cmdBrowse_Click;
            // 
            // lblEID
            // 
            lblEID.AutoSize = true;
            lblEID.Location = new Point(12, 47);
            lblEID.Name = "lblEID";
            lblEID.Size = new Size(31, 15);
            lblEID.TabIndex = 3;
            lblEID.Text = "EID:";
            // 
            // txtEID
            // 
            txtEID.Location = new Point(80, 44);
            txtEID.MaxLength = 5;
            txtEID.Name = "txtEID";
            txtEID.Size = new Size(100, 23);
            txtEID.TabIndex = 4;
            // 
            // lblXOffset
            // 
            lblXOffset.AutoSize = true;
            lblXOffset.Location = new Point(12, 82);
            lblXOffset.Name = "lblXOffset";
            lblXOffset.Size = new Size(50, 15);
            lblXOffset.TabIndex = 5;
            lblXOffset.Text = "X Offset:";
            // 
            // numXOffset
            // 
            numXOffset.Location = new Point(80, 79);
            numXOffset.Maximum = new decimal(new int[] { 2147483647, 0, 0, 0 });
            numXOffset.Minimum = new decimal(new int[] { 2147483647, 0, 0, int.MinValue });
            numXOffset.Name = "numXOffset";
            numXOffset.Size = new Size(100, 23);
            numXOffset.TabIndex = 6;
            // 
            // lblYOffset
            // 
            lblYOffset.AutoSize = true;
            lblYOffset.Location = new Point(196, 82);
            lblYOffset.Name = "lblYOffset";
            lblYOffset.Size = new Size(50, 15);
            lblYOffset.TabIndex = 7;
            lblYOffset.Text = "Y Offset:";
            // 
            // numYOffset
            // 
            numYOffset.Location = new Point(264, 79);
            numYOffset.Maximum = new decimal(new int[] { 2147483647, 0, 0, 0 });
            numYOffset.Minimum = new decimal(new int[] { 2147483647, 0, 0, int.MinValue });
            numYOffset.Name = "numYOffset";
            numYOffset.Size = new Size(100, 23);
            numYOffset.TabIndex = 8;
            // 
            // lblZOffset
            // 
            lblZOffset.AutoSize = true;
            lblZOffset.Location = new Point(12, 113);
            lblZOffset.Name = "lblZOffset";
            lblZOffset.Size = new Size(50, 15);
            lblZOffset.TabIndex = 9;
            lblZOffset.Text = "Z Offset:";
            // 
            // numZOffset
            // 
            numZOffset.Location = new Point(80, 110);
            numZOffset.Maximum = new decimal(new int[] { 2147483647, 0, 0, 0 });
            numZOffset.Minimum = new decimal(new int[] { 2147483647, 0, 0, int.MinValue });
            numZOffset.Name = "numZOffset";
            numZOffset.Size = new Size(100, 23);
            numZOffset.TabIndex = 10;
            // 
            // chkSky
            // 
            chkSky.AutoSize = true;
            chkSky.BackColor = Color.Transparent;
            chkSky.Location = new Point(196, 113);
            chkSky.Name = "chkSky";
            chkSky.Size = new Size(70, 19);
            chkSky.TabIndex = 11;
            chkSky.Text = "Is Sky";
            chkSky.UseVisualStyleBackColor = false;
            // 
            // chkCrash3
            // 
            chkCrash3.AutoSize = true;
            chkCrash3.BackColor = Color.Transparent;
            chkCrash3.Location = new Point(280, 113);
            chkCrash3.Name = "chkCrash3";
            chkCrash3.Size = new Size(110, 19);
            chkCrash3.TabIndex = 12;
            chkCrash3.Text = "Crash 3 format";
            chkCrash3.UseVisualStyleBackColor = false;
            // 
            // cmdConvert
            // 
            cmdConvert.BorderColour = Color.Empty;
            cmdConvert.CustomColour = false;
            cmdConvert.Enabled = false;
            cmdConvert.FlatBottom = false;
            cmdConvert.FlatTop = false;
            cmdConvert.Location = new Point(12, 150);
            cmdConvert.Name = "cmdConvert";
            cmdConvert.Padding = new Padding(5);
            cmdConvert.Size = new Size(464, 34);
            cmdConvert.TabIndex = 13;
            cmdConvert.Text = "Convert";
            cmdConvert.Click += cmdConvert_Click;
            // 
            // SceneryConverterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(488, 196);
            Controls.Add(lblFile);
            Controls.Add(txtFilePath);
            Controls.Add(cmdBrowse);
            Controls.Add(lblEID);
            Controls.Add(txtEID);
            Controls.Add(lblXOffset);
            Controls.Add(numXOffset);
            Controls.Add(lblYOffset);
            Controls.Add(numYOffset);
            Controls.Add(lblZOffset);
            Controls.Add(numZOffset);
            Controls.Add(chkSky);
            Controls.Add(chkCrash3);
            Controls.Add(cmdConvert);
            CornerStyle = CornerPreference.Default;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SceneryConverterForm";
            Text = "Scenery Converter";
            TransparencyKey = Color.FromArgb(31, 31, 32);
            ((System.ComponentModel.ISupportInitialize)numXOffset).EndInit();
            ((System.ComponentModel.ISupportInitialize)numYOffset).EndInit();
            ((System.ComponentModel.ISupportInitialize)numZOffset).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFile;
        private DarkTextBox txtFilePath;
        private DarkButton cmdBrowse;
        private Label lblEID;
        private DarkTextBox txtEID;
        private Label lblXOffset;
        private DarkNumericUpDown numXOffset;
        private Label lblYOffset;
        private DarkNumericUpDown numYOffset;
        private Label lblZOffset;
        private DarkNumericUpDown numZOffset;
        private CheckBox chkSky;
        private CheckBox chkCrash3;
        private DarkButton cmdConvert;
    }
}
