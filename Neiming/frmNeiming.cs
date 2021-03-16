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

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
            {
                DirectoryInfo directory = new DirectoryInfo(folderBrowserDialog.SelectedPath);
                var files = directory.GetFiles();
                FileManager.LoadDictionary(files);

                foreach (var file in files)
                    filesList.Items.Add(file.Name, true);
            }
        }

        private void buttonNeiming_Click(object sender, EventArgs e)
        {
            FileManager.ChangeNames(textBoxConvention.Text, textBoxStartFrom.Text);
        }

        private void filesList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            string name = filesList.Items[e.Index].ToString();

            var key = FileManager.files.Where(x => x.Key.Name == name).Select(x => x.Key).FirstOrDefault();
            FileManager.files[key] = Convert.ToBoolean(e.NewValue);
        }
    }
}
