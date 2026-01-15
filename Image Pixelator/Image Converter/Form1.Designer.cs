namespace Image_Converter
{
    partial class mainWindow
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
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showOriginalImageMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLogMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logListBox = new System.Windows.Forms.ListBox();
            this.RescaledPictureBox = new System.Windows.Forms.PictureBox();
            this.numericBox = new System.Windows.Forms.NumericUpDown();
            this.scaleLabel = new System.Windows.Forms.Label();
            this.SplitOriginalPictureBox = new System.Windows.Forms.PictureBox();
            this.SplitRescaledPictureBox = new System.Windows.Forms.PictureBox();
            this.logLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.minimumDimensionBox = new System.Windows.Forms.NumericUpDown();
            this.pixelateButton = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RescaledPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SplitOriginalPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SplitRescaledPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimumDimensionBox)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1092, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openMenuItem,
            this.saveMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openMenuItem
            // 
            this.openMenuItem.Name = "openMenuItem";
            this.openMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openMenuItem.Text = "Open";
            this.openMenuItem.Click += new System.EventHandler(this.openMenuItem_Click);
            // 
            // saveMenuItem
            // 
            this.saveMenuItem.Enabled = false;
            this.saveMenuItem.Name = "saveMenuItem";
            this.saveMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveMenuItem.Text = "Save";
            this.saveMenuItem.Click += new System.EventHandler(this.saveMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showOriginalImageMenuItem,
            this.showLogMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // showOriginalImageMenuItem
            // 
            this.showOriginalImageMenuItem.Checked = true;
            this.showOriginalImageMenuItem.CheckOnClick = true;
            this.showOriginalImageMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showOriginalImageMenuItem.Name = "showOriginalImageMenuItem";
            this.showOriginalImageMenuItem.Size = new System.Drawing.Size(184, 22);
            this.showOriginalImageMenuItem.Text = "Show Original Image";
            this.showOriginalImageMenuItem.CheckedChanged += new System.EventHandler(this.showOriginalImageMenuItem_CheckedChanged);
            // 
            // showLogMenuItem
            // 
            this.showLogMenuItem.CheckOnClick = true;
            this.showLogMenuItem.Name = "showLogMenuItem";
            this.showLogMenuItem.Size = new System.Drawing.Size(184, 22);
            this.showLogMenuItem.Text = "Show Log";
            this.showLogMenuItem.CheckedChanged += new System.EventHandler(this.showLogMenuItem_CheckedChanged);
            // 
            // logListBox
            // 
            this.logListBox.Enabled = false;
            this.logListBox.Font = new System.Drawing.Font("Directive Four Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logListBox.FormattingEnabled = true;
            this.logListBox.HorizontalExtent = 1000;
            this.logListBox.ItemHeight = 19;
            this.logListBox.Location = new System.Drawing.Point(12, 179);
            this.logListBox.Name = "logListBox";
            this.logListBox.Size = new System.Drawing.Size(462, 460);
            this.logListBox.TabIndex = 2;
            this.logListBox.Visible = false;
            // 
            // RescaledPictureBox
            // 
            this.RescaledPictureBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.RescaledPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RescaledPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.RescaledPictureBox.Location = new System.Drawing.Point(480, 37);
            this.RescaledPictureBox.Name = "RescaledPictureBox";
            this.RescaledPictureBox.Size = new System.Drawing.Size(600, 602);
            this.RescaledPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RescaledPictureBox.TabIndex = 3;
            this.RescaledPictureBox.TabStop = false;
            this.RescaledPictureBox.Visible = false;
            // 
            // numericBox
            // 
            this.numericBox.Font = new System.Drawing.Font("Directive Four Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericBox.Location = new System.Drawing.Point(347, 38);
            this.numericBox.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericBox.Name = "numericBox";
            this.numericBox.Size = new System.Drawing.Size(120, 39);
            this.numericBox.TabIndex = 4;
            this.numericBox.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // scaleLabel
            // 
            this.scaleLabel.AutoSize = true;
            this.scaleLabel.Font = new System.Drawing.Font("Directive Four Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scaleLabel.Location = new System.Drawing.Point(148, 40);
            this.scaleLabel.Name = "scaleLabel";
            this.scaleLabel.Size = new System.Drawing.Size(198, 31);
            this.scaleLabel.TabIndex = 5;
            this.scaleLabel.Text = "Pixelate Factor:";
            // 
            // SplitOriginalPictureBox
            // 
            this.SplitOriginalPictureBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.SplitOriginalPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SplitOriginalPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SplitOriginalPictureBox.Location = new System.Drawing.Point(480, 37);
            this.SplitOriginalPictureBox.Name = "SplitOriginalPictureBox";
            this.SplitOriginalPictureBox.Size = new System.Drawing.Size(600, 298);
            this.SplitOriginalPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SplitOriginalPictureBox.TabIndex = 6;
            this.SplitOriginalPictureBox.TabStop = false;
            // 
            // SplitRescaledPictureBox
            // 
            this.SplitRescaledPictureBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.SplitRescaledPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SplitRescaledPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SplitRescaledPictureBox.Location = new System.Drawing.Point(480, 341);
            this.SplitRescaledPictureBox.Name = "SplitRescaledPictureBox";
            this.SplitRescaledPictureBox.Size = new System.Drawing.Size(600, 298);
            this.SplitRescaledPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SplitRescaledPictureBox.TabIndex = 7;
            this.SplitRescaledPictureBox.TabStop = false;
            // 
            // logLabel
            // 
            this.logLabel.AutoSize = true;
            this.logLabel.Font = new System.Drawing.Font("Directive Four Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logLabel.Location = new System.Drawing.Point(12, 151);
            this.logLabel.Name = "logLabel";
            this.logLabel.Size = new System.Drawing.Size(49, 25);
            this.logLabel.TabIndex = 8;
            this.logLabel.Text = "Log:";
            this.logLabel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Directive Four Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "Minimum Dimension:";
            // 
            // minimumDimensionBox
            // 
            this.minimumDimensionBox.Font = new System.Drawing.Font("Directive Four Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimumDimensionBox.Location = new System.Drawing.Point(347, 83);
            this.minimumDimensionBox.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.minimumDimensionBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.minimumDimensionBox.Name = "minimumDimensionBox";
            this.minimumDimensionBox.Size = new System.Drawing.Size(120, 39);
            this.minimumDimensionBox.TabIndex = 10;
            this.minimumDimensionBox.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // pixelateButton
            // 
            this.pixelateButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pixelateButton.Enabled = false;
            this.pixelateButton.Font = new System.Drawing.Font("Directive Four Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pixelateButton.Location = new System.Drawing.Point(347, 128);
            this.pixelateButton.Name = "pixelateButton";
            this.pixelateButton.Size = new System.Drawing.Size(120, 39);
            this.pixelateButton.TabIndex = 11;
            this.pixelateButton.Text = "Pixelate";
            this.pixelateButton.UseVisualStyleBackColor = false;
            this.pixelateButton.Click += new System.EventHandler(this.pixelateButton_Click);
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1092, 649);
            this.Controls.Add(this.pixelateButton);
            this.Controls.Add(this.minimumDimensionBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logLabel);
            this.Controls.Add(this.SplitRescaledPictureBox);
            this.Controls.Add(this.SplitOriginalPictureBox);
            this.Controls.Add(this.scaleLabel);
            this.Controls.Add(this.numericBox);
            this.Controls.Add(this.RescaledPictureBox);
            this.Controls.Add(this.logListBox);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "mainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Pixelator";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RescaledPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SplitOriginalPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SplitRescaledPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimumDimensionBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openMenuItem;
        private System.Windows.Forms.ListBox logListBox;
        private System.Windows.Forms.PictureBox RescaledPictureBox;
        private System.Windows.Forms.NumericUpDown numericBox;
        private System.Windows.Forms.Label scaleLabel;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showOriginalImageMenuItem;
        private System.Windows.Forms.PictureBox SplitOriginalPictureBox;
        private System.Windows.Forms.PictureBox SplitRescaledPictureBox;
        private System.Windows.Forms.ToolStripMenuItem saveMenuItem;
        private System.Windows.Forms.Label logLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown minimumDimensionBox;
        private System.Windows.Forms.Button pixelateButton;
        private System.Windows.Forms.ToolStripMenuItem showLogMenuItem;
    }
}

