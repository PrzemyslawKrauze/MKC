using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MKC
{
    public partial class MainForm : Form
    {
        #region Properties
        public string ProjectPath { get {return _ProjectPath; } }
        public string FirmPath { get { return _FirmPath; } }
        public bool Overwrite { get { return _Overwrite; } }
            #endregion
        public MainForm()
        {
            InitializeComponent();

            string firmFileName = "MK_Matchkey_conversion.txt";
            List<string> firmPaths = new List<string>();
            Tekla.Structures.TeklaStructuresSettings.GetAdvancedOptionPaths("XS_FIRM", out firmPaths, null);
            _FirmPath = System.IO.Path.Combine(firmPaths[0], firmFileName);

            string projectFileName = "Project_Matchkey_conversion.txt";
            List<string> projectPaths = new List<string>();
            Tekla.Structures.TeklaStructuresSettings.GetAdvancedOptionPaths("XS_PROJECT", out projectPaths, null);
            string fileToFind = System.IO.Path.Combine(projectPaths[0], projectFileName);
            _ProjectPath = fileToFind;
        }

        private void OnFirmFolderBroswerButtonClick(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Title = "Browse txt file",
                CheckFileExists = true,
                CheckPathExists = true,
                Filter = "Txt file|*.txt"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                firmFolderPathTextBox.Text = openFileDialog.FileName;
            }
        }

        private void OnProjectBroswerButtonClick(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Title = "Browse txt file",
                CheckFileExists = true,
                CheckPathExists = true,
                Filter = "Txt file|*.txt"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                projectFolderPathTextBox.Text = openFileDialog.FileName;
            }
        }      

        private void OnRunButtonClick(object sender, EventArgs e)
        {
            _FirmPath = projectFolderPathTextBox.Text;
            _ProjectPath = projectFolderPathTextBox.Text;

            Converter.Run(FirmPath, ProjectPath, Overwrite);
        }

        private void OnOverwriteCheckboxChanged(object sender, EventArgs e)
        {
            _Overwrite = overwriteCheckbox.Checked;
        }

        #region Fields
        private string _ProjectPath = string.Empty;
        private string _FirmPath = string.Empty;
        private bool _Overwrite = false;
        #endregion
    }
}
