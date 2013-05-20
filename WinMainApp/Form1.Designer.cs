namespace AutoFigPro
{
    partial class Form1
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
            this.butLoadProfile = new System.Windows.Forms.Button();
            this.butSaveProfile = new System.Windows.Forms.Button();
            this.groupSingle = new System.Windows.Forms.GroupBox();
            this.butView = new System.Windows.Forms.Button();
            this.radioSingleFromClipboard = new System.Windows.Forms.RadioButton();
            this.radioSingleSourceFile = new System.Windows.Forms.RadioButton();
            this.butSingleTargetBrowse = new System.Windows.Forms.Button();
            this.butSinglePaste = new System.Windows.Forms.Button();
            this.butSingleSourceBrowse = new System.Windows.Forms.Button();
            this.textSingleTargetFile = new System.Windows.Forms.TextBox();
            this.textSingleSourceFile = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.butSingleSave = new System.Windows.Forms.Button();
            this.groupBatch = new System.Windows.Forms.GroupBox();
            this.comboBatchTargetType = new System.Windows.Forms.ComboBox();
            this.comboBatchSourceType = new System.Windows.Forms.ComboBox();
            this.butBatchTargetBrowse = new System.Windows.Forms.Button();
            this.butBatchSourceBrowse = new System.Windows.Forms.Button();
            this.textBatchTargetFolder = new System.Windows.Forms.TextBox();
            this.textBatchSourceFolder = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioBatchProcessing = new System.Windows.Forms.RadioButton();
            this.radioSingleProcessing = new System.Windows.Forms.RadioButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkSingleYItalic = new System.Windows.Forms.CheckBox();
            this.checkSingleXItalic = new System.Windows.Forms.CheckBox();
            this.checkSingleYBold = new System.Windows.Forms.CheckBox();
            this.checkSingleXBold = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textYFontSize = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.comboSingleYFont = new System.Windows.Forms.ComboBox();
            this.comboYValue = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textXFontSize = new System.Windows.Forms.TextBox();
            this.comboSingleXFont = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textSingleYLabel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textSingleXLabel = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.comboAccuracy = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.checkCurveTextItalic = new System.Windows.Forms.CheckBox();
            this.checkCurveTextBold = new System.Windows.Forms.CheckBox();
            this.textCutOff = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.comboCurveTextDir = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.textCurveTextFontSize = new System.Windows.Forms.TextBox();
            this.comboCurveTextFont = new System.Windows.Forms.ComboBox();
            this.groupSingle.SuspendLayout();
            this.groupBatch.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // butLoadProfile
            // 
            this.butLoadProfile.Location = new System.Drawing.Point(113, 376);
            this.butLoadProfile.Name = "butLoadProfile";
            this.butLoadProfile.Size = new System.Drawing.Size(95, 23);
            this.butLoadProfile.TabIndex = 26;
            this.butLoadProfile.Text = "Load Profile...";
            this.butLoadProfile.UseVisualStyleBackColor = true;
            this.butLoadProfile.Click += new System.EventHandler(this.butLoadProfile_Click);
            // 
            // butSaveProfile
            // 
            this.butSaveProfile.Location = new System.Drawing.Point(12, 376);
            this.butSaveProfile.Name = "butSaveProfile";
            this.butSaveProfile.Size = new System.Drawing.Size(95, 23);
            this.butSaveProfile.TabIndex = 24;
            this.butSaveProfile.Text = "Save Profile...";
            this.butSaveProfile.UseVisualStyleBackColor = true;
            this.butSaveProfile.Click += new System.EventHandler(this.butSaveProfile_Click);
            // 
            // groupSingle
            // 
            this.groupSingle.Controls.Add(this.butView);
            this.groupSingle.Controls.Add(this.radioSingleFromClipboard);
            this.groupSingle.Controls.Add(this.radioSingleSourceFile);
            this.groupSingle.Controls.Add(this.butSingleTargetBrowse);
            this.groupSingle.Controls.Add(this.butSinglePaste);
            this.groupSingle.Controls.Add(this.butSingleSourceBrowse);
            this.groupSingle.Controls.Add(this.textSingleTargetFile);
            this.groupSingle.Controls.Add(this.textSingleSourceFile);
            this.groupSingle.Controls.Add(this.label3);
            this.groupSingle.Location = new System.Drawing.Point(6, 37);
            this.groupSingle.Name = "groupSingle";
            this.groupSingle.Size = new System.Drawing.Size(287, 115);
            this.groupSingle.TabIndex = 0;
            this.groupSingle.TabStop = false;
            this.groupSingle.Text = "Single Processing";
            // 
            // butView
            // 
            this.butView.Location = new System.Drawing.Point(204, 53);
            this.butView.Name = "butView";
            this.butView.Size = new System.Drawing.Size(75, 23);
            this.butView.TabIndex = 27;
            this.butView.Text = "View";
            this.butView.UseVisualStyleBackColor = true;
            this.butView.Click += new System.EventHandler(this.butView_Click);
            // 
            // radioSingleFromClipboard
            // 
            this.radioSingleFromClipboard.AutoSize = true;
            this.radioSingleFromClipboard.Checked = true;
            this.radioSingleFromClipboard.Location = new System.Drawing.Point(10, 58);
            this.radioSingleFromClipboard.Name = "radioSingleFromClipboard";
            this.radioSingleFromClipboard.Size = new System.Drawing.Size(98, 17);
            this.radioSingleFromClipboard.TabIndex = 3;
            this.radioSingleFromClipboard.TabStop = true;
            this.radioSingleFromClipboard.Text = "From Clipboard:";
            this.radioSingleFromClipboard.UseVisualStyleBackColor = true;
            this.radioSingleFromClipboard.CheckedChanged += new System.EventHandler(this.radioSingleFromClipboard_CheckedChanged);
            // 
            // radioSingleSourceFile
            // 
            this.radioSingleSourceFile.AutoSize = true;
            this.radioSingleSourceFile.Location = new System.Drawing.Point(10, 30);
            this.radioSingleSourceFile.Name = "radioSingleSourceFile";
            this.radioSingleSourceFile.Size = new System.Drawing.Size(70, 17);
            this.radioSingleSourceFile.TabIndex = 0;
            this.radioSingleSourceFile.Text = "From File:";
            this.radioSingleSourceFile.UseVisualStyleBackColor = true;
            this.radioSingleSourceFile.CheckedChanged += new System.EventHandler(this.radioSingleSourceFile_CheckedChanged);
            // 
            // butSingleTargetBrowse
            // 
            this.butSingleTargetBrowse.Location = new System.Drawing.Point(204, 82);
            this.butSingleTargetBrowse.Name = "butSingleTargetBrowse";
            this.butSingleTargetBrowse.Size = new System.Drawing.Size(75, 23);
            this.butSingleTargetBrowse.TabIndex = 6;
            this.butSingleTargetBrowse.Text = "Browse...";
            this.butSingleTargetBrowse.UseVisualStyleBackColor = true;
            this.butSingleTargetBrowse.Click += new System.EventHandler(this.butSingleTargetBrowse_Click);
            // 
            // butSinglePaste
            // 
            this.butSinglePaste.Location = new System.Drawing.Point(121, 54);
            this.butSinglePaste.Name = "butSinglePaste";
            this.butSinglePaste.Size = new System.Drawing.Size(75, 23);
            this.butSinglePaste.TabIndex = 4;
            this.butSinglePaste.Text = "Paste";
            this.butSinglePaste.UseVisualStyleBackColor = true;
            this.butSinglePaste.Click += new System.EventHandler(this.butSinglePaste_Click);
            // 
            // butSingleSourceBrowse
            // 
            this.butSingleSourceBrowse.Enabled = false;
            this.butSingleSourceBrowse.Location = new System.Drawing.Point(204, 25);
            this.butSingleSourceBrowse.Name = "butSingleSourceBrowse";
            this.butSingleSourceBrowse.Size = new System.Drawing.Size(75, 23);
            this.butSingleSourceBrowse.TabIndex = 2;
            this.butSingleSourceBrowse.Text = "Browse...";
            this.butSingleSourceBrowse.UseVisualStyleBackColor = true;
            this.butSingleSourceBrowse.Click += new System.EventHandler(this.butSingleSourceBrowse_Click);
            // 
            // textSingleTargetFile
            // 
            this.textSingleTargetFile.Location = new System.Drawing.Point(82, 84);
            this.textSingleTargetFile.Name = "textSingleTargetFile";
            this.textSingleTargetFile.Size = new System.Drawing.Size(113, 20);
            this.textSingleTargetFile.TabIndex = 5;
            // 
            // textSingleSourceFile
            // 
            this.textSingleSourceFile.Enabled = false;
            this.textSingleSourceFile.Location = new System.Drawing.Point(82, 28);
            this.textSingleSourceFile.Name = "textSingleSourceFile";
            this.textSingleSourceFile.Size = new System.Drawing.Size(113, 20);
            this.textSingleSourceFile.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Target File:";
            // 
            // butSingleSave
            // 
            this.butSingleSave.Location = new System.Drawing.Point(289, 185);
            this.butSingleSave.Name = "butSingleSave";
            this.butSingleSave.Size = new System.Drawing.Size(75, 23);
            this.butSingleSave.TabIndex = 26;
            this.butSingleSave.Text = "Save";
            this.butSingleSave.UseVisualStyleBackColor = true;
            this.butSingleSave.Click += new System.EventHandler(this.butSingleSave_Click);
            // 
            // groupBatch
            // 
            this.groupBatch.Controls.Add(this.comboBatchTargetType);
            this.groupBatch.Controls.Add(this.comboBatchSourceType);
            this.groupBatch.Controls.Add(this.butBatchTargetBrowse);
            this.groupBatch.Controls.Add(this.butBatchSourceBrowse);
            this.groupBatch.Controls.Add(this.textBatchTargetFolder);
            this.groupBatch.Controls.Add(this.textBatchSourceFolder);
            this.groupBatch.Controls.Add(this.label6);
            this.groupBatch.Controls.Add(this.label8);
            this.groupBatch.Enabled = false;
            this.groupBatch.Location = new System.Drawing.Point(299, 39);
            this.groupBatch.Name = "groupBatch";
            this.groupBatch.Size = new System.Drawing.Size(383, 115);
            this.groupBatch.TabIndex = 2;
            this.groupBatch.TabStop = false;
            this.groupBatch.Text = "Batch Processing";
            // 
            // comboBatchTargetType
            // 
            this.comboBatchTargetType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBatchTargetType.FormattingEnabled = true;
            this.comboBatchTargetType.Items.AddRange(new object[] {
            "AI",
            "EPS"});
            this.comboBatchTargetType.Location = new System.Drawing.Point(247, 84);
            this.comboBatchTargetType.Name = "comboBatchTargetType";
            this.comboBatchTargetType.Size = new System.Drawing.Size(48, 21);
            this.comboBatchTargetType.TabIndex = 15;
            // 
            // comboBatchSourceType
            // 
            this.comboBatchSourceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBatchSourceType.FormattingEnabled = true;
            this.comboBatchSourceType.Items.AddRange(new object[] {
            "Text Files"});
            this.comboBatchSourceType.Location = new System.Drawing.Point(247, 28);
            this.comboBatchSourceType.Name = "comboBatchSourceType";
            this.comboBatchSourceType.Size = new System.Drawing.Size(48, 21);
            this.comboBatchSourceType.TabIndex = 13;
            // 
            // butBatchTargetBrowse
            // 
            this.butBatchTargetBrowse.Location = new System.Drawing.Point(301, 82);
            this.butBatchTargetBrowse.Name = "butBatchTargetBrowse";
            this.butBatchTargetBrowse.Size = new System.Drawing.Size(75, 23);
            this.butBatchTargetBrowse.TabIndex = 7;
            this.butBatchTargetBrowse.Text = "Browse...";
            this.butBatchTargetBrowse.UseVisualStyleBackColor = true;
            // 
            // butBatchSourceBrowse
            // 
            this.butBatchSourceBrowse.Location = new System.Drawing.Point(301, 28);
            this.butBatchSourceBrowse.Name = "butBatchSourceBrowse";
            this.butBatchSourceBrowse.Size = new System.Drawing.Size(75, 23);
            this.butBatchSourceBrowse.TabIndex = 5;
            this.butBatchSourceBrowse.Text = "Browse...";
            this.butBatchSourceBrowse.UseVisualStyleBackColor = true;
            // 
            // textBatchTargetFolder
            // 
            this.textBatchTargetFolder.Location = new System.Drawing.Point(85, 84);
            this.textBatchTargetFolder.Name = "textBatchTargetFolder";
            this.textBatchTargetFolder.Size = new System.Drawing.Size(154, 20);
            this.textBatchTargetFolder.TabIndex = 4;
            // 
            // textBatchSourceFolder
            // 
            this.textBatchSourceFolder.Location = new System.Drawing.Point(85, 28);
            this.textBatchSourceFolder.Name = "textBatchSourceFolder";
            this.textBatchSourceFolder.Size = new System.Drawing.Size(154, 20);
            this.textBatchSourceFolder.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Target Folder:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Source Folder:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioBatchProcessing);
            this.groupBox2.Controls.Add(this.radioSingleProcessing);
            this.groupBox2.Controls.Add(this.groupSingle);
            this.groupBox2.Controls.Add(this.groupBatch);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(689, 167);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "General Setting";
            // 
            // radioBatchProcessing
            // 
            this.radioBatchProcessing.AutoSize = true;
            this.radioBatchProcessing.Location = new System.Drawing.Point(299, 16);
            this.radioBatchProcessing.Name = "radioBatchProcessing";
            this.radioBatchProcessing.Size = new System.Drawing.Size(108, 17);
            this.radioBatchProcessing.TabIndex = 4;
            this.radioBatchProcessing.Text = "Batch Processing";
            this.radioBatchProcessing.UseVisualStyleBackColor = true;
            this.radioBatchProcessing.CheckedChanged += new System.EventHandler(this.radioBatchProcessing_CheckedChanged);
            // 
            // radioSingleProcessing
            // 
            this.radioSingleProcessing.AutoSize = true;
            this.radioSingleProcessing.Checked = true;
            this.radioSingleProcessing.Location = new System.Drawing.Point(6, 16);
            this.radioSingleProcessing.Name = "radioSingleProcessing";
            this.radioSingleProcessing.Size = new System.Drawing.Size(109, 17);
            this.radioSingleProcessing.TabIndex = 3;
            this.radioSingleProcessing.TabStop = true;
            this.radioSingleProcessing.Text = "Single Processing";
            this.radioSingleProcessing.UseVisualStyleBackColor = true;
            this.radioSingleProcessing.CheckedChanged += new System.EventHandler(this.radioSingleProcessing_CheckedChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 207);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(689, 163);
            this.tabControl1.TabIndex = 27;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.textBox4);
            this.tabPage1.Controls.Add(this.textBox5);
            this.tabPage1.Controls.Add(this.textBox6);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.checkSingleYItalic);
            this.tabPage1.Controls.Add(this.checkSingleXItalic);
            this.tabPage1.Controls.Add(this.checkSingleYBold);
            this.tabPage1.Controls.Add(this.checkSingleXBold);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.textYFontSize);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.comboSingleYFont);
            this.tabPage1.Controls.Add(this.comboYValue);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.textXFontSize);
            this.tabPage1.Controls.Add(this.comboSingleXFont);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.textSingleYLabel);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.textSingleXLabel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(681, 137);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Axis Setting";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(259, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 51;
            this.label9.Text = "Step By";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(156, 107);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(10, 13);
            this.label10.TabIndex = 50;
            this.label10.Text = "-";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(309, 104);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(81, 20);
            this.textBox4.TabIndex = 49;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(172, 104);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(81, 20);
            this.textBox5.TabIndex = 48;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(69, 104);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(81, 20);
            this.textBox6.TabIndex = 47;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 107);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 13);
            this.label11.TabIndex = 46;
            this.label11.Text = "YAxis Tick:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(259, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 45;
            this.label7.Text = "Step By";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "-";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(309, 42);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(81, 20);
            this.textBox3.TabIndex = 43;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(172, 42);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(81, 20);
            this.textBox2.TabIndex = 42;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(69, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(81, 20);
            this.textBox1.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "XAxis Tick:";
            // 
            // checkSingleYItalic
            // 
            this.checkSingleYItalic.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkSingleYItalic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkSingleYItalic.Location = new System.Drawing.Point(350, 74);
            this.checkSingleYItalic.Name = "checkSingleYItalic";
            this.checkSingleYItalic.Size = new System.Drawing.Size(21, 20);
            this.checkSingleYItalic.TabIndex = 34;
            this.checkSingleYItalic.Text = "I";
            this.checkSingleYItalic.UseVisualStyleBackColor = true;
            this.checkSingleYItalic.CheckedChanged += new System.EventHandler(this.checkSingleYItalic_CheckedChanged);
            // 
            // checkSingleXItalic
            // 
            this.checkSingleXItalic.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkSingleXItalic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkSingleXItalic.Location = new System.Drawing.Point(350, 10);
            this.checkSingleXItalic.Name = "checkSingleXItalic";
            this.checkSingleXItalic.Size = new System.Drawing.Size(21, 20);
            this.checkSingleXItalic.TabIndex = 28;
            this.checkSingleXItalic.Text = "I";
            this.checkSingleXItalic.UseVisualStyleBackColor = true;
            this.checkSingleXItalic.CheckedChanged += new System.EventHandler(this.checkSingleXItalic_CheckedChanged);
            // 
            // checkSingleYBold
            // 
            this.checkSingleYBold.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkSingleYBold.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkSingleYBold.Location = new System.Drawing.Point(323, 74);
            this.checkSingleYBold.Name = "checkSingleYBold";
            this.checkSingleYBold.Size = new System.Drawing.Size(21, 20);
            this.checkSingleYBold.TabIndex = 33;
            this.checkSingleYBold.Text = "B";
            this.checkSingleYBold.UseVisualStyleBackColor = true;
            this.checkSingleYBold.CheckedChanged += new System.EventHandler(this.checkSingleYBold_CheckedChanged);
            // 
            // checkSingleXBold
            // 
            this.checkSingleXBold.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkSingleXBold.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkSingleXBold.Location = new System.Drawing.Point(323, 10);
            this.checkSingleXBold.Name = "checkSingleXBold";
            this.checkSingleXBold.Size = new System.Drawing.Size(21, 20);
            this.checkSingleXBold.TabIndex = 27;
            this.checkSingleXBold.Text = "B";
            this.checkSingleXBold.UseVisualStyleBackColor = true;
            this.checkSingleXBold.CheckedChanged += new System.EventHandler(this.checkSingleXBold_CheckedChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(415, 76);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(16, 13);
            this.label16.TabIndex = 39;
            this.label16.Text = "pt";
            // 
            // textYFontSize
            // 
            this.textYFontSize.Location = new System.Drawing.Point(377, 74);
            this.textYFontSize.Name = "textYFontSize";
            this.textYFontSize.Size = new System.Drawing.Size(34, 20);
            this.textYFontSize.TabIndex = 36;
            this.textYFontSize.TextChanged += new System.EventHandler(this.textYFontSize_TextChanged);
            this.textYFontSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textYFontSize_KeyPress);
            this.textYFontSize.Leave += new System.EventHandler(this.textYFontSize_Leave);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(416, 13);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(16, 13);
            this.label14.TabIndex = 35;
            this.label14.Text = "pt";
            // 
            // comboSingleYFont
            // 
            this.comboSingleYFont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSingleYFont.FormattingEnabled = true;
            this.comboSingleYFont.Location = new System.Drawing.Point(156, 74);
            this.comboSingleYFont.Name = "comboSingleYFont";
            this.comboSingleYFont.Size = new System.Drawing.Size(157, 21);
            this.comboSingleYFont.TabIndex = 32;
            this.comboSingleYFont.SelectedIndexChanged += new System.EventHandler(this.comboSingleYFont_SelectedIndexChanged);
            // 
            // comboYValue
            // 
            this.comboYValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboYValue.FormattingEnabled = true;
            this.comboYValue.Items.AddRange(new object[] {
            "Percentage",
            "Absolute value"});
            this.comboYValue.Location = new System.Drawing.Point(539, 74);
            this.comboYValue.Name = "comboYValue";
            this.comboYValue.Size = new System.Drawing.Size(78, 21);
            this.comboYValue.TabIndex = 38;
            this.comboYValue.SelectedIndexChanged += new System.EventHandler(this.comboYValue_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(437, 78);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Y Axis Value Type:";
            // 
            // textXFontSize
            // 
            this.textXFontSize.Location = new System.Drawing.Point(377, 10);
            this.textXFontSize.Name = "textXFontSize";
            this.textXFontSize.Size = new System.Drawing.Size(34, 20);
            this.textXFontSize.TabIndex = 29;
            this.textXFontSize.TextChanged += new System.EventHandler(this.textXFontSize_TextChanged);
            this.textXFontSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textXFontSize_KeyPress);
            this.textXFontSize.Leave += new System.EventHandler(this.textXFontSize_Leave);
            // 
            // comboSingleXFont
            // 
            this.comboSingleXFont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSingleXFont.FormattingEnabled = true;
            this.comboSingleXFont.Location = new System.Drawing.Point(156, 10);
            this.comboSingleXFont.Name = "comboSingleXFont";
            this.comboSingleXFont.Size = new System.Drawing.Size(157, 21);
            this.comboSingleXFont.TabIndex = 25;
            this.comboSingleXFont.TabIndexChanged += new System.EventHandler(this.comboSingleXFont_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "XLabel:";
            // 
            // textSingleYLabel
            // 
            this.textSingleYLabel.Location = new System.Drawing.Point(55, 74);
            this.textSingleYLabel.Name = "textSingleYLabel";
            this.textSingleYLabel.Size = new System.Drawing.Size(95, 20);
            this.textSingleYLabel.TabIndex = 30;
            this.textSingleYLabel.TextChanged += new System.EventHandler(this.textSingleYLabel_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "YLabel:";
            // 
            // textSingleXLabel
            // 
            this.textSingleXLabel.Location = new System.Drawing.Point(55, 10);
            this.textSingleXLabel.Name = "textSingleXLabel";
            this.textSingleXLabel.Size = new System.Drawing.Size(95, 20);
            this.textSingleXLabel.TabIndex = 24;
            this.textSingleXLabel.TextChanged += new System.EventHandler(this.textSingleXLabel_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(681, 137);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Curve Setting";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.comboAccuracy);
            this.tabPage3.Controls.Add(this.label23);
            this.tabPage3.Controls.Add(this.checkCurveTextItalic);
            this.tabPage3.Controls.Add(this.checkCurveTextBold);
            this.tabPage3.Controls.Add(this.textCutOff);
            this.tabPage3.Controls.Add(this.label21);
            this.tabPage3.Controls.Add(this.comboCurveTextDir);
            this.tabPage3.Controls.Add(this.label20);
            this.tabPage3.Controls.Add(this.label18);
            this.tabPage3.Controls.Add(this.textCurveTextFontSize);
            this.tabPage3.Controls.Add(this.comboCurveTextFont);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(681, 137);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Annotation Setting";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // comboAccuracy
            // 
            this.comboAccuracy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAccuracy.FormattingEnabled = true;
            this.comboAccuracy.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4"});
            this.comboAccuracy.Location = new System.Drawing.Point(72, 52);
            this.comboAccuracy.Name = "comboAccuracy";
            this.comboAccuracy.Size = new System.Drawing.Size(61, 21);
            this.comboAccuracy.TabIndex = 43;
            this.comboAccuracy.SelectedIndexChanged += new System.EventHandler(this.comboAccuracy_SelectedIndexChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(9, 56);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(55, 13);
            this.label23.TabIndex = 42;
            this.label23.Text = "Accuracy:";
            // 
            // checkCurveTextItalic
            // 
            this.checkCurveTextItalic.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkCurveTextItalic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkCurveTextItalic.Location = new System.Drawing.Point(150, 14);
            this.checkCurveTextItalic.Name = "checkCurveTextItalic";
            this.checkCurveTextItalic.Size = new System.Drawing.Size(21, 21);
            this.checkCurveTextItalic.TabIndex = 34;
            this.checkCurveTextItalic.Text = "I";
            this.checkCurveTextItalic.UseVisualStyleBackColor = true;
            this.checkCurveTextItalic.CheckedChanged += new System.EventHandler(this.checkCurveTextItalic_CheckedChanged);
            // 
            // checkCurveTextBold
            // 
            this.checkCurveTextBold.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkCurveTextBold.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkCurveTextBold.Location = new System.Drawing.Point(123, 14);
            this.checkCurveTextBold.Name = "checkCurveTextBold";
            this.checkCurveTextBold.Size = new System.Drawing.Size(21, 21);
            this.checkCurveTextBold.TabIndex = 33;
            this.checkCurveTextBold.Text = "B";
            this.checkCurveTextBold.UseVisualStyleBackColor = true;
            this.checkCurveTextBold.CheckedChanged += new System.EventHandler(this.checkCurveTextBold_CheckedChanged);
            // 
            // textCutOff
            // 
            this.textCutOff.Location = new System.Drawing.Point(95, 83);
            this.textCutOff.Name = "textCutOff";
            this.textCutOff.Size = new System.Drawing.Size(37, 20);
            this.textCutOff.TabIndex = 38;
            this.textCutOff.TextChanged += new System.EventHandler(this.textCutOff_TextChanged);
            this.textCutOff.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textCutOff_KeyPress);
            this.textCutOff.Leave += new System.EventHandler(this.textCutOff_Leave);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(9, 88);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(76, 13);
            this.label21.TabIndex = 40;
            this.label21.Text = "Cut Threshold:";
            // 
            // comboCurveTextDir
            // 
            this.comboCurveTextDir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCurveTextDir.FormattingEnabled = true;
            this.comboCurveTextDir.Items.AddRange(new object[] {
            "Horizontal",
            "Vertical"});
            this.comboCurveTextDir.Location = new System.Drawing.Point(294, 13);
            this.comboCurveTextDir.Name = "comboCurveTextDir";
            this.comboCurveTextDir.Size = new System.Drawing.Size(74, 21);
            this.comboCurveTextDir.TabIndex = 36;
            this.comboCurveTextDir.SelectedIndexChanged += new System.EventHandler(this.comboCurveTextDir_SelectedIndexChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(239, 17);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(52, 13);
            this.label20.TabIndex = 39;
            this.label20.Text = "Direction:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(217, 17);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(16, 13);
            this.label18.TabIndex = 37;
            this.label18.Text = "pt";
            // 
            // textCurveTextFontSize
            // 
            this.textCurveTextFontSize.Location = new System.Drawing.Point(177, 14);
            this.textCurveTextFontSize.Name = "textCurveTextFontSize";
            this.textCurveTextFontSize.Size = new System.Drawing.Size(34, 20);
            this.textCurveTextFontSize.TabIndex = 35;
            this.textCurveTextFontSize.TextChanged += new System.EventHandler(this.textCurveTextFontSize_TextChanged);
            this.textCurveTextFontSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textCurveTextFontSize_KeyPress);
            this.textCurveTextFontSize.Leave += new System.EventHandler(this.textCurveTextFontSize_Leave);
            // 
            // comboCurveTextFont
            // 
            this.comboCurveTextFont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCurveTextFont.FormattingEnabled = true;
            this.comboCurveTextFont.Location = new System.Drawing.Point(12, 14);
            this.comboCurveTextFont.Name = "comboCurveTextFont";
            this.comboCurveTextFont.Size = new System.Drawing.Size(104, 21);
            this.comboCurveTextFont.TabIndex = 32;
            this.comboCurveTextFont.SelectedIndexChanged += new System.EventHandler(this.comboCurveTextFont_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 403);
            this.Controls.Add(this.butLoadProfile);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.butSaveProfile);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.butSingleSave);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "AutoFigPro";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupSingle.ResumeLayout(false);
            this.groupSingle.PerformLayout();
            this.groupBatch.ResumeLayout(false);
            this.groupBatch.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupSingle;
        private System.Windows.Forms.Button butSingleTargetBrowse;
        private System.Windows.Forms.Button butSinglePaste;
        private System.Windows.Forms.Button butSingleSourceBrowse;
        private System.Windows.Forms.TextBox textSingleTargetFile;
        private System.Windows.Forms.TextBox textSingleSourceFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBatch;
        private System.Windows.Forms.Button butBatchTargetBrowse;
        private System.Windows.Forms.Button butBatchSourceBrowse;
        private System.Windows.Forms.TextBox textBatchTargetFolder;
        private System.Windows.Forms.TextBox textBatchSourceFolder;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton radioSingleFromClipboard;
        private System.Windows.Forms.RadioButton radioSingleSourceFile;
        private System.Windows.Forms.Button butSingleSave;
        private System.Windows.Forms.ComboBox comboBatchSourceType;
        private System.Windows.Forms.ComboBox comboBatchTargetType;
        private System.Windows.Forms.Button butLoadProfile;
        private System.Windows.Forms.Button butSaveProfile;
        private System.Windows.Forms.Button butView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioBatchProcessing;
        private System.Windows.Forms.RadioButton radioSingleProcessing;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.CheckBox checkSingleYItalic;
        private System.Windows.Forms.CheckBox checkSingleXItalic;
        private System.Windows.Forms.CheckBox checkSingleYBold;
        private System.Windows.Forms.CheckBox checkSingleXBold;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textYFontSize;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboSingleYFont;
        private System.Windows.Forms.ComboBox comboYValue;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textXFontSize;
        private System.Windows.Forms.ComboBox comboSingleXFont;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textSingleYLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textSingleXLabel;
        private System.Windows.Forms.ComboBox comboAccuracy;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.CheckBox checkCurveTextItalic;
        private System.Windows.Forms.CheckBox checkCurveTextBold;
        private System.Windows.Forms.TextBox textCutOff;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox comboCurveTextDir;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textCurveTextFontSize;
        private System.Windows.Forms.ComboBox comboCurveTextFont;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}

