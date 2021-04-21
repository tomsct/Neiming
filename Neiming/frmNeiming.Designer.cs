namespace Neiming
{
    partial class frmNeiming
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
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.textBoxConvention = new System.Windows.Forms.TextBox();
            this.filesList = new System.Windows.Forms.CheckedListBox();
            this.checkBoxSelectAll = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.browseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonNeiming = new System.Windows.Forms.Button();
            this.startFrom = new System.Windows.Forms.NumericUpDown();
            this.lastIndex = new System.Windows.Forms.NumericUpDown();
            this.checkBoxSelectIndex = new System.Windows.Forms.CheckBox();
            this.lblCurrentIndex = new System.Windows.Forms.Label();
            this.checkBoxRightToLeft = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.startFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastIndex)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxConvention
            // 
            this.textBoxConvention.Location = new System.Drawing.Point(80, 60);
            this.textBoxConvention.Name = "textBoxConvention";
            this.textBoxConvention.Size = new System.Drawing.Size(274, 22);
            this.textBoxConvention.TabIndex = 2;
            this.textBoxConvention.Click += new System.EventHandler(this.textBoxConvention_Click);
            // 
            // filesList
            // 
            this.filesList.FormattingEnabled = true;
            this.filesList.Location = new System.Drawing.Point(456, 60);
            this.filesList.Name = "filesList";
            this.filesList.Size = new System.Drawing.Size(238, 412);
            this.filesList.Sorted = true;
            this.filesList.TabIndex = 6;
            this.filesList.SelectedIndexChanged += new System.EventHandler(this.filesList_SelectedIndexChanged);
            // 
            // checkBoxSelectAll
            // 
            this.checkBoxSelectAll.AutoSize = true;
            this.checkBoxSelectAll.Checked = true;
            this.checkBoxSelectAll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSelectAll.Location = new System.Drawing.Point(459, 35);
            this.checkBoxSelectAll.Name = "checkBoxSelectAll";
            this.checkBoxSelectAll.Size = new System.Drawing.Size(88, 21);
            this.checkBoxSelectAll.TabIndex = 7;
            this.checkBoxSelectAll.Text = "Select All";
            this.checkBoxSelectAll.UseVisualStyleBackColor = true;
            this.checkBoxSelectAll.CheckedChanged += new System.EventHandler(this.checkBoxSelectAll_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(706, 30);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.browseToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 26);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // browseToolStripMenuItem
            // 
            this.browseToolStripMenuItem.Name = "browseToolStripMenuItem";
            this.browseToolStripMenuItem.Size = new System.Drawing.Size(140, 26);
            this.browseToolStripMenuItem.Text = "Browse";
            this.browseToolStripMenuItem.Click += new System.EventHandler(this.browseToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(140, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // buttonNeiming
            // 
            this.buttonNeiming.Location = new System.Drawing.Point(80, 193);
            this.buttonNeiming.Name = "buttonNeiming";
            this.buttonNeiming.Size = new System.Drawing.Size(110, 54);
            this.buttonNeiming.TabIndex = 9;
            this.buttonNeiming.Text = "Neiming";
            this.buttonNeiming.UseVisualStyleBackColor = true;
            this.buttonNeiming.Click += new System.EventHandler(this.buttonNeiming_Click);
            // 
            // startFrom
            // 
            this.startFrom.Location = new System.Drawing.Point(80, 101);
            this.startFrom.Name = "startFrom";
            this.startFrom.Size = new System.Drawing.Size(74, 22);
            this.startFrom.TabIndex = 10;
            this.startFrom.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lastIndex
            // 
            this.lastIndex.Location = new System.Drawing.Point(304, 102);
            this.lastIndex.Name = "lastIndex";
            this.lastIndex.Size = new System.Drawing.Size(50, 22);
            this.lastIndex.TabIndex = 11;
            // 
            // checkBoxSelectIndex
            // 
            this.checkBoxSelectIndex.AutoSize = true;
            this.checkBoxSelectIndex.Location = new System.Drawing.Point(177, 103);
            this.checkBoxSelectIndex.Name = "checkBoxSelectIndex";
            this.checkBoxSelectIndex.Size = new System.Drawing.Size(106, 21);
            this.checkBoxSelectIndex.TabIndex = 13;
            this.checkBoxSelectIndex.Text = "Select Index";
            this.checkBoxSelectIndex.UseVisualStyleBackColor = true;
            // 
            // lblCurrentIndex
            // 
            this.lblCurrentIndex.AutoSize = true;
            this.lblCurrentIndex.Location = new System.Drawing.Point(360, 104);
            this.lblCurrentIndex.Name = "lblCurrentIndex";
            this.lblCurrentIndex.Size = new System.Drawing.Size(0, 17);
            this.lblCurrentIndex.TabIndex = 14;
            // 
            // checkBoxRightToLeft
            // 
            this.checkBoxRightToLeft.AutoSize = true;
            this.checkBoxRightToLeft.Location = new System.Drawing.Point(177, 131);
            this.checkBoxRightToLeft.Name = "checkBoxRightToLeft";
            this.checkBoxRightToLeft.Size = new System.Drawing.Size(102, 21);
            this.checkBoxRightToLeft.TabIndex = 15;
            this.checkBoxRightToLeft.Text = "Right to left";
            this.checkBoxRightToLeft.UseVisualStyleBackColor = true;
            // 
            // frmNeiming
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 482);
            this.Controls.Add(this.checkBoxRightToLeft);
            this.Controls.Add(this.lblCurrentIndex);
            this.Controls.Add(this.checkBoxSelectIndex);
            this.Controls.Add(this.lastIndex);
            this.Controls.Add(this.startFrom);
            this.Controls.Add(this.buttonNeiming);
            this.Controls.Add(this.checkBoxSelectAll);
            this.Controls.Add(this.filesList);
            this.Controls.Add(this.textBoxConvention);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmNeiming";
            this.Text = "Neiming";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.startFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastIndex)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.TextBox textBoxConvention;
        private System.Windows.Forms.CheckedListBox filesList;
        private System.Windows.Forms.CheckBox checkBoxSelectAll;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem browseToolStripMenuItem;
        private System.Windows.Forms.Button buttonNeiming;
        private System.Windows.Forms.NumericUpDown startFrom;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown lastIndex;
        private System.Windows.Forms.CheckBox checkBoxSelectIndex;
        private System.Windows.Forms.Label lblCurrentIndex;
        private System.Windows.Forms.CheckBox checkBoxRightToLeft;
    }
}

