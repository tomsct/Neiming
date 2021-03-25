using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Neiming
{
    public partial class frmNeiming : Form
    {
        public frmNeiming()
        {
            InitializeComponent();
        }

        private void checkBoxSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSelectAll.Checked)
                CheckUncheckAll(true);
            else
                CheckUncheckAll(false);
        }

        private void CheckUncheckAll(bool state)
        {
            for (int i = 0; i < filesList.Items.Count; i++)
                filesList.SetItemChecked(i, state);
        }

        private void browseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
            {
                FileManager.SelectedPath = folderBrowserDialog.SelectedPath;
                FileManager.RefreshFileList(filesList);
            }
        }

        private void filesList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            string name = filesList.Items[e.Index].ToString();

            var key = FileManager.files.Where(x => x.Key.Name == name).Select(x => x.Key).FirstOrDefault();
            FileManager.files[key] = Convert.ToBoolean(e.NewValue);
        }

        private void buttonNeiming_Click(object sender, EventArgs e)
        {
            FileManager.ChangeNames(textBoxConvention.Text, startFrom.Value.ToString());
            FileManager.RefreshFileList(filesList);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void filesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxConvention.Text = filesList.SelectedItem.ToString();
        }
    }
}
