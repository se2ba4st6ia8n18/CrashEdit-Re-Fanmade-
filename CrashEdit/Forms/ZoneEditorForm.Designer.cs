using AltUI.Controls;

namespace CrashEdit.CE
{
    partial class ZoneEditorForm
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
            lblOutputDir = new Label();
            txtOutputDir = new DarkTextBox();
            cmdBrowseOutput = new DarkButton();
            lblEID = new Label();
            txtEID = new DarkTextBox();
            chkCrash3 = new CheckBox();
            chkSelfLink = new CheckBox();
            lblMusic = new Label();
            txtMusic = new DarkTextBox();
            grpDimensions = new GroupBox();
            lblX = new Label();
            numX = new DarkNumericUpDown();
            lblY = new Label();
            numY = new DarkNumericUpDown();
            lblZ = new Label();
            numZ = new DarkNumericUpDown();
            lblWidth = new Label();
            numWidth = new DarkNumericUpDown();
            lblHeight = new Label();
            numHeight = new DarkNumericUpDown();
            lblDepth = new Label();
            numDepth = new DarkNumericUpDown();
            lblCollisionDepthX = new Label();
            numCollisionDepthX = new DarkNumericUpDown();
            lblCollisionDepthY = new Label();
            numCollisionDepthY = new DarkNumericUpDown();
            lblCollisionDepthZ = new Label();
            numCollisionDepthZ = new DarkNumericUpDown();
            grpHeaderCounts = new GroupBox();
            lblWorldCount = new Label();
            numWorldCount = new DarkNumericUpDown();
            lblInfoCount = new Label();
            numInfoCount = new DarkNumericUpDown();
            lblCameraCount = new Label();
            numCameraCount = new DarkNumericUpDown();
            lblEntityCount = new Label();
            numEntityCount = new DarkNumericUpDown();
            lblZoneCount = new Label();
            numZoneCount = new DarkNumericUpDown();
            cmdCreate = new DarkButton();
            grpDimensions.SuspendLayout();
            grpHeaderCounts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numZ).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numWidth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numHeight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDepth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCollisionDepthX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCollisionDepthY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCollisionDepthZ).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numWorldCount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numInfoCount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCameraCount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numEntityCount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numZoneCount).BeginInit();
            SuspendLayout();
            //
            // lblOutputDir
            //
            lblOutputDir.AutoSize = true;
            lblOutputDir.Location = new Point(12, 15);
            lblOutputDir.Name = "lblOutputDir";
            lblOutputDir.Size = new Size(70, 15);
            lblOutputDir.TabIndex = 0;
            lblOutputDir.Text = "Output Folder:";
            //
            // txtOutputDir
            //
            txtOutputDir.Location = new Point(110, 12);
            txtOutputDir.Name = "txtOutputDir";
            txtOutputDir.ReadOnly = true;
            txtOutputDir.Size = new Size(260, 23);
            txtOutputDir.TabIndex = 1;
            //
            // cmdBrowseOutput
            //
            cmdBrowseOutput.BorderColour = Color.Empty;
            cmdBrowseOutput.CustomColour = false;
            cmdBrowseOutput.FlatBottom = false;
            cmdBrowseOutput.FlatTop = false;
            cmdBrowseOutput.Location = new Point(376, 11);
            cmdBrowseOutput.Name = "cmdBrowseOutput";
            cmdBrowseOutput.Padding = new Padding(5);
            cmdBrowseOutput.Size = new Size(90, 25);
            cmdBrowseOutput.TabIndex = 2;
            cmdBrowseOutput.Text = "Browse...";
            cmdBrowseOutput.Click += cmdBrowseOutput_Click;
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
            txtEID.Location = new Point(110, 44);
            txtEID.MaxLength = 5;
            txtEID.Name = "txtEID";
            txtEID.Size = new Size(70, 23);
            txtEID.TabIndex = 4;
            //
            // chkCrash3
            //
            chkCrash3.AutoSize = true;
            chkCrash3.BackColor = Color.Transparent;
            chkCrash3.Location = new Point(196, 47);
            chkCrash3.Name = "chkCrash3";
            chkCrash3.Size = new Size(110, 19);
            chkCrash3.TabIndex = 5;
            chkCrash3.Text = "Crash 3 format";
            chkCrash3.UseVisualStyleBackColor = false;
            //
            // chkSelfLink
            //
            chkSelfLink.AutoSize = true;
            chkSelfLink.BackColor = Color.Transparent;
            chkSelfLink.Checked = true;
            chkSelfLink.CheckState = CheckState.Checked;
            chkSelfLink.Location = new Point(320, 47);
            chkSelfLink.Name = "chkSelfLink";
            chkSelfLink.Size = new Size(130, 19);
            chkSelfLink.TabIndex = 6;
            chkSelfLink.Text = "Add self zone-link";
            chkSelfLink.UseVisualStyleBackColor = false;
            //
            // lblMusic
            //
            lblMusic.AutoSize = true;
            lblMusic.Location = new Point(12, 79);
            lblMusic.Name = "lblMusic";
            lblMusic.Size = new Size(63, 15);
            lblMusic.TabIndex = 7;
            lblMusic.Text = "Music EID:";
            //
            // txtMusic
            //
            txtMusic.Location = new Point(110, 76);
            txtMusic.MaxLength = 5;
            txtMusic.Name = "txtMusic";
            txtMusic.Size = new Size(70, 23);
            txtMusic.TabIndex = 8;
            //
            // grpDimensions - single-column stacked layout, one field per row, row pitch 30px
            //
            grpDimensions.Controls.Add(lblX);
            grpDimensions.Controls.Add(numX);
            grpDimensions.Controls.Add(lblY);
            grpDimensions.Controls.Add(numY);
            grpDimensions.Controls.Add(lblZ);
            grpDimensions.Controls.Add(numZ);
            grpDimensions.Controls.Add(lblWidth);
            grpDimensions.Controls.Add(numWidth);
            grpDimensions.Controls.Add(lblHeight);
            grpDimensions.Controls.Add(numHeight);
            grpDimensions.Controls.Add(lblDepth);
            grpDimensions.Controls.Add(numDepth);
            grpDimensions.Controls.Add(lblCollisionDepthX);
            grpDimensions.Controls.Add(numCollisionDepthX);
            grpDimensions.Controls.Add(lblCollisionDepthY);
            grpDimensions.Controls.Add(numCollisionDepthY);
            grpDimensions.Controls.Add(lblCollisionDepthZ);
            grpDimensions.Controls.Add(numCollisionDepthZ);
            grpDimensions.ForeColor = Color.Gainsboro;
            grpDimensions.Location = new Point(12, 108);
            grpDimensions.Name = "grpDimensions";
            grpDimensions.Size = new Size(454, 300);
            grpDimensions.TabIndex = 9;
            grpDimensions.TabStop = false;
            grpDimensions.Text = "Dimensions / Offsets / Collision Depth";
            //
            // lblX
            //
            lblX.AutoSize = true;
            lblX.Location = new Point(14, 28);
            lblX.Name = "lblX";
            lblX.Size = new Size(17, 15);
            lblX.TabIndex = 0;
            lblX.Text = "X:";
            //
            // numX
            //
            numX.Location = new Point(160, 25);
            numX.Maximum = new decimal(new int[] { 2147483647, 0, 0, 0 });
            numX.Minimum = new decimal(new int[] { 2147483647, 0, 0, int.MinValue });
            numX.Name = "numX";
            numX.Size = new Size(120, 23);
            numX.TabIndex = 1;
            //
            // lblY
            //
            lblY.AutoSize = true;
            lblY.Location = new Point(14, 58);
            lblY.Name = "lblY";
            lblY.Size = new Size(17, 15);
            lblY.TabIndex = 2;
            lblY.Text = "Y:";
            //
            // numY
            //
            numY.Location = new Point(160, 55);
            numY.Maximum = new decimal(new int[] { 2147483647, 0, 0, 0 });
            numY.Minimum = new decimal(new int[] { 2147483647, 0, 0, int.MinValue });
            numY.Name = "numY";
            numY.Size = new Size(120, 23);
            numY.TabIndex = 3;
            //
            // lblZ
            //
            lblZ.AutoSize = true;
            lblZ.Location = new Point(14, 88);
            lblZ.Name = "lblZ";
            lblZ.Size = new Size(17, 15);
            lblZ.TabIndex = 4;
            lblZ.Text = "Z:";
            //
            // numZ
            //
            numZ.Location = new Point(160, 85);
            numZ.Maximum = new decimal(new int[] { 2147483647, 0, 0, 0 });
            numZ.Minimum = new decimal(new int[] { 2147483647, 0, 0, int.MinValue });
            numZ.Name = "numZ";
            numZ.Size = new Size(120, 23);
            numZ.TabIndex = 5;
            //
            // lblWidth
            //
            lblWidth.AutoSize = true;
            lblWidth.Location = new Point(14, 118);
            lblWidth.Name = "lblWidth";
            lblWidth.Size = new Size(42, 15);
            lblWidth.TabIndex = 6;
            lblWidth.Text = "Width:";
            //
            // numWidth
            //
            numWidth.Location = new Point(160, 115);
            numWidth.Maximum = new decimal(new int[] { 2147483647, 0, 0, 0 });
            numWidth.Minimum = new decimal(new int[] { 2147483647, 0, 0, int.MinValue });
            numWidth.Name = "numWidth";
            numWidth.Size = new Size(120, 23);
            numWidth.TabIndex = 7;
            //
            // lblHeight
            //
            lblHeight.AutoSize = true;
            lblHeight.Location = new Point(14, 148);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new Size(45, 15);
            lblHeight.TabIndex = 8;
            lblHeight.Text = "Height:";
            //
            // numHeight
            //
            numHeight.Location = new Point(160, 145);
            numHeight.Maximum = new decimal(new int[] { 2147483647, 0, 0, 0 });
            numHeight.Minimum = new decimal(new int[] { 2147483647, 0, 0, int.MinValue });
            numHeight.Name = "numHeight";
            numHeight.Size = new Size(120, 23);
            numHeight.TabIndex = 9;
            //
            // lblDepth
            //
            lblDepth.AutoSize = true;
            lblDepth.Location = new Point(14, 178);
            lblDepth.Name = "lblDepth";
            lblDepth.Size = new Size(40, 15);
            lblDepth.TabIndex = 10;
            lblDepth.Text = "Depth:";
            //
            // numDepth
            //
            numDepth.Location = new Point(160, 175);
            numDepth.Maximum = new decimal(new int[] { 2147483647, 0, 0, 0 });
            numDepth.Minimum = new decimal(new int[] { 2147483647, 0, 0, int.MinValue });
            numDepth.Name = "numDepth";
            numDepth.Size = new Size(120, 23);
            numDepth.TabIndex = 11;
            //
            // lblCollisionDepthX
            //
            lblCollisionDepthX.AutoSize = true;
            lblCollisionDepthX.Location = new Point(14, 208);
            lblCollisionDepthX.Name = "lblCollisionDepthX";
            lblCollisionDepthX.Size = new Size(102, 15);
            lblCollisionDepthX.TabIndex = 12;
            lblCollisionDepthX.Text = "Collision Depth X:";
            //
            // numCollisionDepthX
            //
            numCollisionDepthX.Location = new Point(160, 205);
            numCollisionDepthX.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            numCollisionDepthX.Name = "numCollisionDepthX";
            numCollisionDepthX.Size = new Size(120, 23);
            numCollisionDepthX.TabIndex = 13;
            //
            // lblCollisionDepthY
            //
            lblCollisionDepthY.AutoSize = true;
            lblCollisionDepthY.Location = new Point(14, 238);
            lblCollisionDepthY.Name = "lblCollisionDepthY";
            lblCollisionDepthY.Size = new Size(102, 15);
            lblCollisionDepthY.TabIndex = 14;
            lblCollisionDepthY.Text = "Collision Depth Y:";
            //
            // numCollisionDepthY
            //
            numCollisionDepthY.Location = new Point(160, 235);
            numCollisionDepthY.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            numCollisionDepthY.Name = "numCollisionDepthY";
            numCollisionDepthY.Size = new Size(120, 23);
            numCollisionDepthY.TabIndex = 15;
            //
            // lblCollisionDepthZ
            //
            lblCollisionDepthZ.AutoSize = true;
            lblCollisionDepthZ.Location = new Point(14, 268);
            lblCollisionDepthZ.Name = "lblCollisionDepthZ";
            lblCollisionDepthZ.Size = new Size(102, 15);
            lblCollisionDepthZ.TabIndex = 16;
            lblCollisionDepthZ.Text = "Collision Depth Z:";
            //
            // numCollisionDepthZ
            //
            numCollisionDepthZ.Location = new Point(160, 265);
            numCollisionDepthZ.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            numCollisionDepthZ.Name = "numCollisionDepthZ";
            numCollisionDepthZ.Size = new Size(120, 23);
            numCollisionDepthZ.TabIndex = 17;
            //
            // grpHeaderCounts - single-column stacked layout, one field per row, row pitch 30px
            //
            grpHeaderCounts.Controls.Add(lblWorldCount);
            grpHeaderCounts.Controls.Add(numWorldCount);
            grpHeaderCounts.Controls.Add(lblInfoCount);
            grpHeaderCounts.Controls.Add(numInfoCount);
            grpHeaderCounts.Controls.Add(lblCameraCount);
            grpHeaderCounts.Controls.Add(numCameraCount);
            grpHeaderCounts.Controls.Add(lblEntityCount);
            grpHeaderCounts.Controls.Add(numEntityCount);
            grpHeaderCounts.Controls.Add(lblZoneCount);
            grpHeaderCounts.Controls.Add(numZoneCount);
            grpHeaderCounts.ForeColor = Color.Gainsboro;
            grpHeaderCounts.Location = new Point(12, 418);
            grpHeaderCounts.Name = "grpHeaderCounts";
            grpHeaderCounts.Size = new Size(454, 180);
            grpHeaderCounts.TabIndex = 10;
            grpHeaderCounts.TabStop = false;
            grpHeaderCounts.Text = "Header Counts";
            //
            // lblWorldCount
            //
            lblWorldCount.AutoSize = true;
            lblWorldCount.Location = new Point(14, 28);
            lblWorldCount.Name = "lblWorldCount";
            lblWorldCount.Size = new Size(73, 15);
            lblWorldCount.TabIndex = 0;
            lblWorldCount.Text = "World Count:";
            //
            // numWorldCount
            //
            numWorldCount.Location = new Point(160, 25);
            numWorldCount.Maximum = new decimal(new int[] { 8, 0, 0, 0 });
            numWorldCount.Name = "numWorldCount";
            numWorldCount.Size = new Size(120, 23);
            numWorldCount.TabIndex = 1;
            //
            // lblInfoCount
            //
            lblInfoCount.AutoSize = true;
            lblInfoCount.Location = new Point(14, 58);
            lblInfoCount.Name = "lblInfoCount";
            lblInfoCount.Size = new Size(63, 15);
            lblInfoCount.TabIndex = 2;
            lblInfoCount.Text = "Info Count:";
            //
            // numInfoCount
            //
            numInfoCount.Location = new Point(160, 55);
            numInfoCount.Maximum = new decimal(new int[] { 2147483647, 0, 0, 0 });
            numInfoCount.Name = "numInfoCount";
            numInfoCount.Size = new Size(120, 23);
            numInfoCount.TabIndex = 3;
            numInfoCount.Value = new decimal(new int[] { 2, 0, 0, 0 });
            //
            // lblCameraCount
            //
            lblCameraCount.AutoSize = true;
            lblCameraCount.Location = new Point(14, 88);
            lblCameraCount.Name = "lblCameraCount";
            lblCameraCount.Size = new Size(82, 15);
            lblCameraCount.TabIndex = 4;
            lblCameraCount.Text = "Camera Count:";
            //
            // numCameraCount
            //
            numCameraCount.Location = new Point(160, 85);
            numCameraCount.Maximum = new decimal(new int[] { 2147483647, 0, 0, 0 });
            numCameraCount.Name = "numCameraCount";
            numCameraCount.Size = new Size(120, 23);
            numCameraCount.TabIndex = 5;
            //
            // lblEntityCount
            //
            lblEntityCount.AutoSize = true;
            lblEntityCount.Location = new Point(14, 118);
            lblEntityCount.Name = "lblEntityCount";
            lblEntityCount.Size = new Size(76, 15);
            lblEntityCount.TabIndex = 6;
            lblEntityCount.Text = "Entity Count:";
            //
            // numEntityCount
            //
            numEntityCount.Location = new Point(160, 115);
            numEntityCount.Maximum = new decimal(new int[] { 2147483647, 0, 0, 0 });
            numEntityCount.Name = "numEntityCount";
            numEntityCount.Size = new Size(120, 23);
            numEntityCount.TabIndex = 7;
            //
            // lblZoneCount
            //
            lblZoneCount.AutoSize = true;
            lblZoneCount.Location = new Point(14, 148);
            lblZoneCount.Name = "lblZoneCount";
            lblZoneCount.Size = new Size(70, 15);
            lblZoneCount.TabIndex = 8;
            lblZoneCount.Text = "Zone Count:";
            //
            // numZoneCount
            //
            numZoneCount.Location = new Point(160, 145);
            numZoneCount.Maximum = new decimal(new int[] { 2147483647, 0, 0, 0 });
            numZoneCount.Name = "numZoneCount";
            numZoneCount.Size = new Size(120, 23);
            numZoneCount.TabIndex = 9;
            numZoneCount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            //
            // cmdCreate
            //
            cmdCreate.BorderColour = Color.Empty;
            cmdCreate.CustomColour = false;
            cmdCreate.FlatBottom = false;
            cmdCreate.FlatTop = false;
            cmdCreate.Location = new Point(12, 608);
            cmdCreate.Name = "cmdCreate";
            cmdCreate.Padding = new Padding(5);
            cmdCreate.Size = new Size(454, 34);
            cmdCreate.TabIndex = 11;
            cmdCreate.Text = "Create Blank Zone";
            cmdCreate.Click += cmdCreate_Click;
            //
            // ZoneEditorForm
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 654);
            Controls.Add(lblOutputDir);
            Controls.Add(txtOutputDir);
            Controls.Add(cmdBrowseOutput);
            Controls.Add(lblEID);
            Controls.Add(txtEID);
            Controls.Add(chkCrash3);
            Controls.Add(chkSelfLink);
            Controls.Add(lblMusic);
            Controls.Add(txtMusic);
            Controls.Add(grpDimensions);
            Controls.Add(grpHeaderCounts);
            Controls.Add(cmdCreate);
            CornerStyle = CornerPreference.Default;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ZoneEditorForm";
            Text = "Zone Editor";
            TransparencyKey = Color.FromArgb(31, 31, 32);
            grpDimensions.ResumeLayout(false);
            grpDimensions.PerformLayout();
            grpHeaderCounts.ResumeLayout(false);
            grpHeaderCounts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numX).EndInit();
            ((System.ComponentModel.ISupportInitialize)numY).EndInit();
            ((System.ComponentModel.ISupportInitialize)numZ).EndInit();
            ((System.ComponentModel.ISupportInitialize)numWidth).EndInit();
            ((System.ComponentModel.ISupportInitialize)numHeight).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDepth).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCollisionDepthX).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCollisionDepthY).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCollisionDepthZ).EndInit();
            ((System.ComponentModel.ISupportInitialize)numWorldCount).EndInit();
            ((System.ComponentModel.ISupportInitialize)numInfoCount).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCameraCount).EndInit();
            ((System.ComponentModel.ISupportInitialize)numEntityCount).EndInit();
            ((System.ComponentModel.ISupportInitialize)numZoneCount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblOutputDir;
        private DarkTextBox txtOutputDir;
        private DarkButton cmdBrowseOutput;
        private Label lblEID;
        private DarkTextBox txtEID;
        private CheckBox chkCrash3;
        private CheckBox chkSelfLink;
        private Label lblMusic;
        private DarkTextBox txtMusic;
        private GroupBox grpDimensions;
        private Label lblX;
        private DarkNumericUpDown numX;
        private Label lblY;
        private DarkNumericUpDown numY;
        private Label lblZ;
        private DarkNumericUpDown numZ;
        private Label lblWidth;
        private DarkNumericUpDown numWidth;
        private Label lblHeight;
        private DarkNumericUpDown numHeight;
        private Label lblDepth;
        private DarkNumericUpDown numDepth;
        private Label lblCollisionDepthX;
        private DarkNumericUpDown numCollisionDepthX;
        private Label lblCollisionDepthY;
        private DarkNumericUpDown numCollisionDepthY;
        private Label lblCollisionDepthZ;
        private DarkNumericUpDown numCollisionDepthZ;
        private GroupBox grpHeaderCounts;
        private Label lblWorldCount;
        private DarkNumericUpDown numWorldCount;
        private Label lblInfoCount;
        private DarkNumericUpDown numInfoCount;
        private Label lblCameraCount;
        private DarkNumericUpDown numCameraCount;
        private Label lblEntityCount;
        private DarkNumericUpDown numEntityCount;
        private Label lblZoneCount;
        private DarkNumericUpDown numZoneCount;
        private DarkButton cmdCreate;
    }
}
