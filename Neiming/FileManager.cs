using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Neiming
{
    static class FileManager
    {
        public static Dictionary<FileInfo, bool> files { get; set; } = null;
        public static string SelectedPath { get; set; }

        public static void ChangeNames(string nameConvention, string startFrom)
        {
            int counter = Int32.Parse(startFrom);

            foreach (var file in files.Where(x => x.Value).Select(x => x.Key).ToArray())
            {
                var extension = file.Extension;
                string episode = (counter < 10) ? episode = $"0{counter}" : episode = counter.ToString();
                
                File.Move(file.FullName, file.FullName.Replace(file.Name, $"{nameConvention} {episode}{extension}"));
                counter++;
            }
        }

        public static void LoadDictionary(FileInfo[] files)
        {
            FileManager.files = new Dictionary<FileInfo, bool>();

            foreach (var file in files)
                FileManager.files.Add(file, true);
         
        }

        public static void RefreshFileList(CheckedListBox filesList)
        {
            DirectoryInfo directory = new DirectoryInfo(SelectedPath);
            var files = directory.GetFiles();
            LoadDictionary(files);

            filesList.Items.Clear();
            foreach (var file in files)
                filesList.Items.Add(file.Name.Remove(file.Name.IndexOf('.')), true);
        }
    }
}
