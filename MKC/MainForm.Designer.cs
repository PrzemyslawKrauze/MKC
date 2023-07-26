
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
            this.RewriteMatchkeyButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CalculatePartAreaButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.RewriteUDAButton = new System.Windows.Forms.Button();
            this.CalculateAssemblyAreaButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.RewritePhaseButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.oldPrefixTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.newPrefixTextBox = new System.Windows.Forms.TextBox();
            this.changePrefixButton = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.rebarSeqStartNumber = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.rebarSeqPrefix = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.rebarSeqButton = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.rebarSeqEndNumber = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.rebarSeqSeq = new System.Windows.Forms.TextBox();
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
            this.overwriteCheckbox.Location = new System.Drawing.Point(326, 100);
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
            // RewriteMatchkeyButton
            // 
            this.RewriteMatchkeyButton.Location = new System.Drawing.Point(523, 172);
            this.RewriteMatchkeyButton.Name = "RewriteMatchkeyButton";
            this.RewriteMatchkeyButton.Size = new System.Drawing.Size(75, 23);
            this.RewriteMatchkeyButton.TabIndex = 9;
            this.RewriteMatchkeyButton.Text = "Rewrite";
            this.RewriteMatchkeyButton.UseVisualStyleBackColor = true;
            this.RewriteMatchkeyButton.Click += new System.EventHandler(this.RewriteButton_Click);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(221, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(207, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Assign project matchkey based on classes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(103, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Calculate part area";
            // 
            // CalculatePartAreaButton
            // 
            this.CalculatePartAreaButton.Location = new System.Drawing.Point(523, 275);
            this.CalculatePartAreaButton.Name = "CalculatePartAreaButton";
            this.CalculatePartAreaButton.Size = new System.Drawing.Size(75, 23);
            this.CalculatePartAreaButton.TabIndex = 13;
            this.CalculatePartAreaButton.Text = "Calculate";
            this.CalculatePartAreaButton.UseVisualStyleBackColor = true;
            this.CalculatePartAreaButton.Click += new System.EventHandler(this.CalculatePartAreaButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(103, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(304, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Rewrite IFC_BUILDING and IFC_BUILDING_STOREY to UDA";
            // 
            // RewriteUDAButton
            // 
            this.RewriteUDAButton.Location = new System.Drawing.Point(523, 201);
            this.RewriteUDAButton.Name = "RewriteUDAButton";
            this.RewriteUDAButton.Size = new System.Drawing.Size(75, 23);
            this.RewriteUDAButton.TabIndex = 14;
            this.RewriteUDAButton.Text = "Rewrite";
            this.RewriteUDAButton.UseVisualStyleBackColor = true;
            this.RewriteUDAButton.Click += new System.EventHandler(this.RewriteUDAButton_Click);
            // 
            // CalculateAssemblyAreaButton
            // 
            this.CalculateAssemblyAreaButton.Location = new System.Drawing.Point(523, 304);
            this.CalculateAssemblyAreaButton.Name = "CalculateAssemblyAreaButton";
            this.CalculateAssemblyAreaButton.Size = new System.Drawing.Size(75, 23);
            this.CalculateAssemblyAreaButton.TabIndex = 17;
            this.CalculateAssemblyAreaButton.Text = "Calculate";
            this.CalculateAssemblyAreaButton.UseVisualStyleBackColor = true;
            this.CalculateAssemblyAreaButton.Click += new System.EventHandler(this.CalculateAssemblyAreaButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(103, 309);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Calculate assembly area";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(103, 235);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Rewrite PHASE to USER_PHASE";
            // 
            // RewritePhaseButton
            // 
            this.RewritePhaseButton.Location = new System.Drawing.Point(523, 230);
            this.RewritePhaseButton.Name = "RewritePhaseButton";
            this.RewritePhaseButton.Size = new System.Drawing.Size(75, 23);
            this.RewritePhaseButton.TabIndex = 18;
            this.RewritePhaseButton.Text = "Rewrite";
            this.RewritePhaseButton.UseVisualStyleBackColor = true;
            this.RewritePhaseButton.Click += new System.EventHandler(this.RewritePhaseButton_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(103, 353);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Change RebarSet prefix";
            // 
            // oldPrefixTextBox
            // 
            this.oldPrefixTextBox.Location = new System.Drawing.Point(275, 350);
            this.oldPrefixTextBox.Name = "oldPrefixTextBox";
            this.oldPrefixTextBox.Size = new System.Drawing.Size(59, 20);
            this.oldPrefixTextBox.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(243, 353);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Old:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(367, 353);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "New:";
            // 
            // newPrefixTextBox
            // 
            this.newPrefixTextBox.Location = new System.Drawing.Point(399, 350);
            this.newPrefixTextBox.Name = "newPrefixTextBox";
            this.newPrefixTextBox.Size = new System.Drawing.Size(59, 20);
            this.newPrefixTextBox.TabIndex = 23;
            // 
            // changePrefixButton
            // 
            this.changePrefixButton.Location = new System.Drawing.Point(523, 343);
            this.changePrefixButton.Name = "changePrefixButton";
            this.changePrefixButton.Size = new System.Drawing.Size(75, 23);
            this.changePrefixButton.TabIndex = 25;
            this.changePrefixButton.Text = "Run";
            this.changePrefixButton.UseVisualStyleBackColor = true;
            this.changePrefixButton.Click += new System.EventHandler(this.changePrefixButton_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(341, 382);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "Start number";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // rebarSeqStartNumber
            // 
            this.rebarSeqStartNumber.Location = new System.Drawing.Point(414, 379);
            this.rebarSeqStartNumber.Name = "rebarSeqStartNumber";
            this.rebarSeqStartNumber.Size = new System.Drawing.Size(59, 20);
            this.rebarSeqStartNumber.TabIndex = 29;
            this.rebarSeqStartNumber.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(236, 382);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "Prefix:";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // rebarSeqPrefix
            // 
            this.rebarSeqPrefix.Location = new System.Drawing.Point(276, 379);
            this.rebarSeqPrefix.Name = "rebarSeqPrefix";
            this.rebarSeqPrefix.Size = new System.Drawing.Size(59, 20);
            this.rebarSeqPrefix.TabIndex = 27;
            this.rebarSeqPrefix.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(104, 382);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(109, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "Set rebar SeqNumber";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // rebarSeqButton
            // 
            this.rebarSeqButton.Location = new System.Drawing.Point(644, 379);
            this.rebarSeqButton.Name = "rebarSeqButton";
            this.rebarSeqButton.Size = new System.Drawing.Size(75, 23);
            this.rebarSeqButton.TabIndex = 31;
            this.rebarSeqButton.Text = "Run";
            this.rebarSeqButton.UseVisualStyleBackColor = true;
            this.rebarSeqButton.Click += new System.EventHandler(this.rebarSeqButton_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(479, 382);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 13);
            this.label15.TabIndex = 32;
            this.label15.Text = "End number";
            // 
            // rebarSeqEndNumber
            // 
            this.rebarSeqEndNumber.Location = new System.Drawing.Point(549, 379);
            this.rebarSeqEndNumber.Name = "rebarSeqEndNumber";
            this.rebarSeqEndNumber.Size = new System.Drawing.Size(59, 20);
            this.rebarSeqEndNumber.TabIndex = 33;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(236, 409);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(26, 13);
            this.label16.TabIndex = 34;
            this.label16.Text = "Seq";
            // 
            // rebarSeqSeq
            // 
            this.rebarSeqSeq.Location = new System.Drawing.Point(275, 406);
            this.rebarSeqSeq.Name = "rebarSeqSeq";
            this.rebarSeqSeq.Size = new System.Drawing.Size(59, 20);
            this.rebarSeqSeq.TabIndex = 35;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rebarSeqSeq);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.rebarSeqEndNumber);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.rebarSeqButton);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.rebarSeqStartNumber);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.rebarSeqPrefix);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.changePrefixButton);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.newPrefixTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.oldPrefixTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.RewritePhaseButton);
            this.Controls.Add(this.CalculateAssemblyAreaButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.RewriteUDAButton);
            this.Controls.Add(this.CalculatePartAreaButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RewriteMatchkeyButton);
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
            this.Load += new System.EventHandler(this.MainForm_Load);
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
        private System.Windows.Forms.Button RewriteMatchkeyButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button CalculatePartAreaButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button RewriteUDAButton;
        private System.Windows.Forms.Button CalculateAssemblyAreaButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button RewritePhaseButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox oldPrefixTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox newPrefixTextBox;
        private System.Windows.Forms.Button changePrefixButton;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox rebarSeqStartNumber;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox rebarSeqPrefix;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button rebarSeqButton;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox rebarSeqEndNumber;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox rebarSeqSeq;
    }
}