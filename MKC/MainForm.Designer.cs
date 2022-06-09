
namespace MKC
{
    partial class MainForm
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
            this.firmFolderPathTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FirmFolderBroswerButton = new System.Windows.Forms.Button();
            this.projectFolderPathTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.projectFolderBroswerButton = new System.Windows.Forms.Button();
            this.overwriteCheckbox = new System.Windows.Forms.CheckBox();
            this.runButton = new System.Windows.Forms.Button();
            this.RewriteButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // firmFolderPathTextBox
            // 
            this.firmFolderPathTextBox.Location = new System.Drawing.Point(224, 41);
            this.firmFolderPathTextBox.Name = "firmFolderPathTextBox";
            this.firmFolderPathTextBox.Size = new System.Drawing.Size(257, 20);
            this.firmFolderPathTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Firm folder path";
            // 
            // FirmFolderBroswerButton
            // 
            this.FirmFolderBroswerButton.Location = new System.Drawing.Point(523, 36);
            this.FirmFolderBroswerButton.Name = "FirmFolderBroswerButton";
            this.FirmFolderBroswerButton.Size = new System.Drawing.Size(75, 23);
            this.FirmFolderBroswerButton.TabIndex = 3;
            this.FirmFolderBroswerButton.Text = "Broswer";
            this.FirmFolderBroswerButton.UseVisualStyleBackColor = true;
            this.FirmFolderBroswerButton.Click += new System.EventHandler(this.OnFirmFolderBroswerButtonClick);
            // 
            // projectFolderPathTextBox
            // 
            this.projectFolderPathTextBox.Location = new System.Drawing.Point(224, 67);
            this.projectFolderPathTextBox.Name = "projectFolderPathTextBox";
            this.projectFolderPathTextBox.Size = new System.Drawing.Size(257, 20);
            this.projectFolderPathTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Project folder path";
            // 
            // projectFolderBroswerButton
            // 
            this.projectFolderBroswerButton.Location = new System.Drawing.Point(523, 65);
            this.projectFolderBroswerButton.Name = "projectFolderBroswerButton";
            this.projectFolderBroswerButton.Size = new System.Drawing.Size(75, 23);
            this.projectFolderBroswerButton.TabIndex = 6;
            this.projectFolderBroswerButton.Text = "Broswer";
            this.projectFolderBroswerButton.UseVisualStyleBackColor = true;
            this.projectFolderBroswerButton.Click += new System.EventHandler(this.OnProjectBroswerButtonClick);
            // 
            // overwriteCheckbox
            // 
            this.overwriteCheckbox.AutoSize = true;
            this.overwriteCheckbox.Location = new System.Drawing.Point(224, 390);
            this.overwriteCheckbox.Name = "overwriteCheckbox";
            this.overwriteCheckbox.Size = new System.Drawing.Size(155, 17);
            this.overwriteCheckbox.TabIndex = 7;
            this.overwriteCheckbox.Text = "Overwrite existing attributes";
            this.overwriteCheckbox.UseVisualStyleBackColor = true;
            this.overwriteCheckbox.CheckedChanged += new System.EventHandler(this.OnOverwriteCheckboxChanged);
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(523, 94);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(75, 23);
            this.runButton.TabIndex = 8;
            this.runButton.Text = "Run";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.OnRunButtonClick);
            // 
            // RewriteButton
            // 
            this.RewriteButton.Location = new System.Drawing.Point(523, 172);
            this.RewriteButton.Name = "RewriteButton";
            this.RewriteButton.Size = new System.Drawing.Size(75, 23);
            this.RewriteButton.TabIndex = 9;
            this.RewriteButton.Text = "Rewrite";
            this.RewriteButton.UseVisualStyleBackColor = true;
            this.RewriteButton.Click += new System.EventHandler(this.RewriteButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Rewrite part Matchkey to assemblies";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RewriteButton);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.overwriteCheckbox);
            this.Controls.Add(this.projectFolderBroswerButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.projectFolderPathTextBox);
            this.Controls.Add(this.FirmFolderBroswerButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.firmFolderPathTextBox);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firmFolderPathTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button FirmFolderBroswerButton;
        private System.Windows.Forms.TextBox projectFolderPathTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button projectFolderBroswerButton;
        private System.Windows.Forms.CheckBox overwriteCheckbox;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.Button RewriteButton;
        private System.Windows.Forms.Label label3;
    }
}