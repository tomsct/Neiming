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
                
                File.Move(file.FullName, file.FullName.Replace(file.Name, $"{nameConvention}{episode}{extension}"));
                counter++;
            }
        }

        public static void ChangeNamesIndex(string nameConvention, string startFrom, int lastIndex, bool rightToLeft)
        {
            int counter = Int32.Parse(startFrom);

            foreach (var file in files.Where(x => x.Value).Select(x => x.Key).ToArray())
            {
                string extension = file.Extension;

                string episode = (counter < 10) ? episode = $"0{counter}" : episode = counter.ToString();

                var nameAux = file.Name.Replace(file.Extension, "");

                if (rightToLeft)
                {
                    var auxArray = nameAux.ToCharArray();
                    Array.Reverse(auxArray);

                    var aux = new String(auxArray);
                    aux = aux.Remove(0, lastIndex);

                    auxArray = aux.ToCharArray();

                    Array.Reverse(auxArray);

                    nameAux = new string(auxArray);
                }
                else
                {
                    nameAux = nameAux.Remove(0, lastIndex);
                    nameAux = nameAux.Insert(0, nameConvention.Replace("{E}", episode));
                }
                nameAux = nameAux.Trim(); 
                File.Move(file.FullName, file.FullName.Replace(file.Name, $"{nameAux}{extension}"));
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
                filesList.Items.Add(file.Name.Remove(file.Name.LastIndexOf('.')), true);
        }
    }
}
