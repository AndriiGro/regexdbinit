using Grondzal.RegexESDBInit.Services;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grondzal.RegexESDBInit
{
    public partial class Main : MetroForm
    {
        public Main()
        {
            InitializeComponent();
        }

        FileService _fileService = new FileService();
        RegexService _regexService = new RegexService();
        private string _pathToFile = null;
        private string _textToProcess = null;

        private void btn_LoadFile_Click(object sender, EventArgs e)
        {
            _pathToFile = _fileService.GetFilePath();

            if(_pathToFile != null)
            {
                txtbox_PathToFile.Text = _pathToFile;
                btn_ProcessData.Enabled = true;
                txtbox_Pattern.Enabled = true;
                txtbox_Pattern.Text = ESDBInitConsts.DefaultRegExPattern;
            }
            else
            {
                txtbox_PathToFile.Text = ESDBInitConsts.FilePathIsNullErrorMessage;
            }            
        }

        private void btn_ProcessData_Click(object sender, EventArgs e)
        {
            _textToProcess = _fileService.GetTextFileContent(_pathToFile);
            if(_textToProcess != null)
            {
                string _pattern = _regexService.IsValidRegex(txtbox_Pattern.Text) ? txtbox_Pattern.Text : "";
                MatchCollection matches = Regex.Matches(_textToProcess, _pattern);
            }
            else 
            {

            }
        }    
        
    }
}
