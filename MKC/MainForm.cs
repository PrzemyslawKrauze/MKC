using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tekla.Structures;
using Tekla.Structures.Model;

namespace MKC
{
    public partial class MainForm : Form
    {
        #region Properties
        public string ProjectPath { get { return _ProjectPath; } }
        public string FirmPath { get { return _FirmPath; } }
        public bool Overwrite { get { return _Overwrite; } }
        #endregion
        public MainForm()
        {
            InitializeComponent();

            string firmFileName = "MK_Matchkey_conversion.txt";
            List<string> firmPaths = new List<string>();
            Tekla.Structures.TeklaStructuresSettings.GetAdvancedOptionPaths("XS_FIRM", out firmPaths, null);
            if (firmPaths.Count > 0)
            {
                _FirmPath = System.IO.Path.Combine(firmPaths[0], firmFileName);
                firmFolderPathTextBox.Text = _FirmPath;
            }
            else
            {
                _FirmPath = String.Empty;
            }

            string projectFileName = "Project_Matchkey_conversion.txt";
            List<string> projectPaths = new List<string>();
            Tekla.Structures.TeklaStructuresSettings.GetAdvancedOptionPaths("XS_PROJECT", out projectPaths, null);
            if (projectPaths.Count > 0)
            {
                string fileToFind = System.IO.Path.Combine(projectPaths[0], projectFileName);
                _ProjectPath = fileToFind;
                projectFolderPathTextBox.Text = _ProjectPath;
            }
            else
            {
                _ProjectPath = String.Empty;
            }
        }
        private void DisplayOparationStatusMessage(bool succes)
        {
            string message = succes ? "Operation successful" : "Operation faild";
            MessageBox.Show(message);
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
        private void RewriteButton_Click(object sender, EventArgs e)
        {
            if (firmFolderPathTextBox.Text.Length > 1)
            {
                _FirmPath = firmFolderPathTextBox.Text;
            }
            if (projectFolderPathTextBox.Text.Length > 1)
            {
                _ProjectPath = projectFolderPathTextBox.Text;
            }

            bool succes = Engine.RewriteMatchkeyToAssembly(Overwrite);
            DisplayOparationStatusMessage(succes);
        }
        private void RewriteUDAButton_Click(object sender, EventArgs e)
        {
            if (firmFolderPathTextBox.Text.Length > 1)
            {
                _FirmPath = firmFolderPathTextBox.Text;
            }
            if (projectFolderPathTextBox.Text.Length > 1)
            {
                _ProjectPath = projectFolderPathTextBox.Text;
            }

            bool succes = Engine.RewriteIFCBUILDINGAndIFCBUILDINGSTOREYToAssembly(Overwrite);
            DisplayOparationStatusMessage(succes);
        }
        private void OnRunButtonClick(object sender, EventArgs e)
        {
            if (firmFolderPathTextBox.Text.Length > 1)
            {
                _FirmPath = firmFolderPathTextBox.Text;
            }
            if (projectFolderPathTextBox.Text.Length > 1)
            {
                _ProjectPath = projectFolderPathTextBox.Text;
            }
            else
            {
                _ProjectPath = String.Empty;
            }

            bool succes = Engine.Run(FirmPath, ProjectPath, Overwrite);
            DisplayOparationStatusMessage(succes);
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

        private void CalculatePartAreaButton_Click(object sender, EventArgs e)
        {
            bool succes = Engine.CalculateCorrectArea(Overwrite);
            DisplayOparationStatusMessage(succes);
        }

        private void CalculateAssemblyAreaButton_Click(object sender, EventArgs e)
        {
            bool succes = Engine.CallculateCorrectAreaForAssembly(Overwrite);
            DisplayOparationStatusMessage(succes);
        }

        private void RewritePhaseButton_Click(object sender, EventArgs e)
        {
            bool succes = Engine.RewritePhaseToUDA(Overwrite);
            DisplayOparationStatusMessage(succes);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void changePrefixButton_Click(object sender, EventArgs e)
        {
            string oldPrefix = oldPrefixTextBox.Text;
            string newPrefix = newPrefixTextBox.Text;
            RebarSet[] rebarSets =  Utility.PickRebarSets();
            bool succes =  Engine.ChangePrefix(rebarSets,oldPrefix,newPrefix);
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
        private void rebarSeqButton_Click(object sender, EventArgs e)
        {
            string prefix = rebarSeqPrefix.Text;
            int startNumber = Convert.ToInt32(rebarSeqStartNumber.Text);
            int endNumber = Convert.ToInt32(rebarSeqEndNumber.Text);
            int seqNumber = Convert.ToInt32(rebarSeqSeq.Text);
            bool succes = Engine.SetRebarSeqNumber(prefix, startNumber, endNumber, seqNumber);
        }
    }
}
