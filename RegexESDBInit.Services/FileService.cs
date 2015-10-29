using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grondzal.RegexESDBInit.Services
{
    public class FileService
    {
        public string GetFilePath()
        {
            string filePath = null;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.CheckFileExists = true;
            openFileDialog.AddExtension = true;
            openFileDialog.Multiselect = false;
            openFileDialog.Filter = "C# files (*.cs)|*.cs";

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
            }

            return filePath;
        }

        public string GetTextFileContent(string filePath)
        {
            string fileContent = null;

            try
            {   
                using (StreamReader sr = new StreamReader(filePath))
                {
                    fileContent = sr.ReadToEnd();
                }
            }
            catch (Exception)
            {
                
            }

            return fileContent;
        }
    }
}
