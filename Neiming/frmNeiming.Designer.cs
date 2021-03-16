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
            this.button1 = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.textBoxConvention = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBoxStartFrom = new System.Windows.Forms.TextBox();
            this.buttonNeiming = new System.Windows.Forms.Button();
            this.filesList = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 52);
            this.button1.TabIndex = 0;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxConvention
            // 
            this.textBoxConvention.Location = new System.Drawing.Point(26, 126);
            this.textBoxConvention.Name = "textBoxConvention";
            this.textBoxConvention.Size = new System.Drawing.Size(274, 22);
            this.textBoxConvention.TabIndex = 2;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(317, 128);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(98, 21);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBoxStartFrom
            // 
            this.textBoxStartFrom.Location = new System.Drawing.Point(26, 187);
            this.textBoxStartFrom.Name = "textBoxStartFrom";
            this.textBoxStartFrom.Size = new System.Drawing.Size(274, 22);
            this.textBoxStartFrom.TabIndex = 4;
            // 
            // buttonNeiming
            // 
            this.buttonNeiming.Location = new System.Drawing.Point(26, 261);
            this.buttonNeiming.Name = "buttonNeiming";
            this.buttonNeiming.Size = new System.Drawing.Size(274, 78);
            this.buttonNeiming.TabIndex = 5;
            this.buttonNeiming.Text = "Neiming";
            this.buttonNeiming.UseVisualStyleBackColor = true;
            this.buttonNeiming.Click += new System.EventHandler(this.buttonNeiming_Click);
            // 
            // filesList
            // 
            this.filesList.FormattingEnabled = true;
            this.filesList.Location = new System.Drawing.Point(456, 12);
            this.filesList.Name = "filesList";
            this.filesList.Size = new System.Drawing.Size(238, 429);
            this.filesList.TabIndex = 6;
            this.filesList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.filesList_ItemCheck);
            // 
            // frmNeiming
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 462);
            this.Controls.Add(this.filesList);
            this.Controls.Add(this.buttonNeiming);
            this.Controls.Add(this.textBoxStartFrom);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBoxConvention);
            this.Controls.Add(this.button1);
            this.Name = "frmNeiming";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.TextBox textBoxConvention;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBoxStartFrom;
        private System.Windows.Forms.Button buttonNeiming;
        private System.Windows.Forms.CheckedListBox filesList;
    }
}

