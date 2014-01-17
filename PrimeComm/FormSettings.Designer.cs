﻿namespace PrimeComm
{
    partial class FormSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSettings));
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.tabControlPreferences = new System.Windows.Forms.TabControl();
            this.tabPageGeneral = new System.Windows.Forms.TabPage();
            this.linkLabelClearWarnings = new System.Windows.Forms.LinkLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageProgram = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabPageImages = new System.Windows.Forms.TabPage();
            this.groupBoxDithering = new System.Windows.Forms.GroupBox();
            this.linkLabelDitheringInfo = new System.Windows.Forms.LinkLabel();
            this.comboBoxImageDitheringMethod = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonIcon = new System.Windows.Forms.RadioButton();
            this.radioButtonDimgrob = new System.Windows.Forms.RadioButton();
            this.radioButtonPixel = new System.Windows.Forms.RadioButton();
            this.tabPageAdvanced = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.numericUpDownRecentFiles = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownFontSize = new System.Windows.Forms.NumericUpDown();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBoxCompressSpaces = new System.Windows.Forms.CheckBox();
            this.checkBoxConversionComment = new System.Windows.Forms.CheckBox();
            this.checkBoxEnableAdditionalProgramProcessing = new System.Windows.Forms.CheckBox();
            this.checkBoxRemoveComments = new System.Windows.Forms.CheckBox();
            this.checkBoxObfuscateVariables = new System.Windows.Forms.CheckBox();
            this.checkBoxImageMethodDimgrobOptimizeBlacks = new System.Windows.Forms.CheckBox();
            this.checkBoxImageMethodDimgrobOptimizeSimilar = new System.Windows.Forms.CheckBox();
            this.linkLabelClearRecent = new System.Windows.Forms.LinkLabel();
            this.tabControlPreferences.SuspendLayout();
            this.tabPageGeneral.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPageProgram.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPageImages.SuspendLayout();
            this.groupBoxDithering.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRecentFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFontSize)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(324, 425);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 24);
            this.buttonCancel.TabIndex = 0;
            this.buttonCancel.Text = "&Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(243, 425);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 24);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "&Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(12, 425);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 24);
            this.buttonReset.TabIndex = 2;
            this.buttonReset.Text = "&Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // tabControlPreferences
            // 
            this.tabControlPreferences.Controls.Add(this.tabPageGeneral);
            this.tabControlPreferences.Controls.Add(this.tabPageProgram);
            this.tabControlPreferences.Controls.Add(this.tabPageImages);
            this.tabControlPreferences.Controls.Add(this.tabPageAdvanced);
            this.tabControlPreferences.Location = new System.Drawing.Point(12, 12);
            this.tabControlPreferences.Name = "tabControlPreferences";
            this.tabControlPreferences.SelectedIndex = 0;
            this.tabControlPreferences.Size = new System.Drawing.Size(387, 408);
            this.tabControlPreferences.TabIndex = 1;
            this.tabControlPreferences.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControlPreferences_Selected);
            // 
            // tabPageGeneral
            // 
            this.tabPageGeneral.Controls.Add(this.linkLabelClearWarnings);
            this.tabPageGeneral.Controls.Add(this.groupBox3);
            this.tabPageGeneral.Controls.Add(this.label1);
            this.tabPageGeneral.Location = new System.Drawing.Point(4, 24);
            this.tabPageGeneral.Name = "tabPageGeneral";
            this.tabPageGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGeneral.Size = new System.Drawing.Size(379, 380);
            this.tabPageGeneral.TabIndex = 0;
            this.tabPageGeneral.Text = "General";
            this.tabPageGeneral.UseVisualStyleBackColor = true;
            // 
            // linkLabelClearWarnings
            // 
            this.linkLabelClearWarnings.AutoSize = true;
            this.linkLabelClearWarnings.Location = new System.Drawing.Point(88, 349);
            this.linkLabelClearWarnings.Name = "linkLabelClearWarnings";
            this.linkLabelClearWarnings.Size = new System.Drawing.Size(74, 15);
            this.linkLabelClearWarnings.TabIndex = 2;
            this.linkLabelClearWarnings.TabStop = true;
            this.linkLabelClearWarnings.Text = "clicking here";
            this.linkLabelClearWarnings.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelClearWarnings_LinkClicked);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(367, 54);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Startup";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(18, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Some notes and warning messages appear only once. You can restore them";
            // 
            // tabPageProgram
            // 
            this.tabPageProgram.Controls.Add(this.groupBox4);
            this.tabPageProgram.Controls.Add(this.groupBox2);
            this.tabPageProgram.Location = new System.Drawing.Point(4, 24);
            this.tabPageProgram.Name = "tabPageProgram";
            this.tabPageProgram.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProgram.Size = new System.Drawing.Size(379, 380);
            this.tabPageProgram.TabIndex = 1;
            this.tabPageProgram.Text = "Program";
            this.tabPageProgram.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.linkLabelClearRecent);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.numericUpDownRecentFiles);
            this.groupBox4.Controls.Add(this.numericUpDownFontSize);
            this.groupBox4.Location = new System.Drawing.Point(6, 191);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(367, 101);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Editor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Default font size:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.checkBoxCompressSpaces);
            this.groupBox2.Controls.Add(this.checkBoxConversionComment);
            this.groupBox2.Controls.Add(this.checkBoxEnableAdditionalProgramProcessing);
            this.groupBox2.Controls.Add(this.checkBoxRemoveComments);
            this.groupBox2.Controls.Add(this.checkBoxObfuscateVariables);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(367, 179);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Program code";
            // 
            // tabPageImages
            // 
            this.tabPageImages.Controls.Add(this.groupBoxDithering);
            this.tabPageImages.Controls.Add(this.groupBox1);
            this.tabPageImages.Location = new System.Drawing.Point(4, 24);
            this.tabPageImages.Name = "tabPageImages";
            this.tabPageImages.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageImages.Size = new System.Drawing.Size(379, 380);
            this.tabPageImages.TabIndex = 3;
            this.tabPageImages.Text = "Images";
            this.tabPageImages.UseVisualStyleBackColor = true;
            // 
            // groupBoxDithering
            // 
            this.groupBoxDithering.Controls.Add(this.linkLabelDitheringInfo);
            this.groupBoxDithering.Controls.Add(this.comboBoxImageDitheringMethod);
            this.groupBoxDithering.Location = new System.Drawing.Point(6, 168);
            this.groupBoxDithering.Name = "groupBoxDithering";
            this.groupBoxDithering.Size = new System.Drawing.Size(367, 69);
            this.groupBoxDithering.TabIndex = 3;
            this.groupBoxDithering.TabStop = false;
            this.groupBoxDithering.Text = "Image processing";
            // 
            // linkLabelDitheringInfo
            // 
            this.linkLabelDitheringInfo.AutoSize = true;
            this.linkLabelDitheringInfo.Location = new System.Drawing.Point(12, 29);
            this.linkLabelDitheringInfo.Name = "linkLabelDitheringInfo";
            this.linkLabelDitheringInfo.Size = new System.Drawing.Size(104, 15);
            this.linkLabelDitheringInfo.TabIndex = 6;
            this.linkLabelDitheringInfo.TabStop = true;
            this.linkLabelDitheringInfo.Text = "Dithering method:";
            this.linkLabelDitheringInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelDitheringInfo_LinkClicked);
            // 
            // comboBoxImageDitheringMethod
            // 
            this.comboBoxImageDitheringMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxImageDitheringMethod.FormattingEnabled = true;
            this.comboBoxImageDitheringMethod.Location = new System.Drawing.Point(121, 26);
            this.comboBoxImageDitheringMethod.Name = "comboBoxImageDitheringMethod";
            this.comboBoxImageDitheringMethod.Size = new System.Drawing.Size(175, 23);
            this.comboBoxImageDitheringMethod.TabIndex = 4;
            this.comboBoxImageDitheringMethod.SelectedIndexChanged += new System.EventHandler(this.comboBoxImageDitheringMethod_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonIcon);
            this.groupBox1.Controls.Add(this.radioButtonDimgrob);
            this.groupBox1.Controls.Add(this.checkBoxImageMethodDimgrobOptimizeBlacks);
            this.groupBox1.Controls.Add(this.radioButtonPixel);
            this.groupBox1.Controls.Add(this.checkBoxImageMethodDimgrobOptimizeSimilar);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 156);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Image output method";
            // 
            // radioButtonIcon
            // 
            this.radioButtonIcon.AutoSize = true;
            this.radioButtonIcon.Enabled = false;
            this.radioButtonIcon.Location = new System.Drawing.Point(15, 122);
            this.radioButtonIcon.Name = "radioButtonIcon";
            this.radioButtonIcon.Size = new System.Drawing.Size(150, 19);
            this.radioButtonIcon.TabIndex = 0;
            this.radioButtonIcon.TabStop = true;
            this.radioButtonIcon.Text = "ICON and BLIT_P (PNG)";
            this.radioButtonIcon.UseVisualStyleBackColor = true;
            this.radioButtonIcon.CheckedChanged += new System.EventHandler(this.something_Changed);
            // 
            // radioButtonDimgrob
            // 
            this.radioButtonDimgrob.AutoSize = true;
            this.radioButtonDimgrob.Location = new System.Drawing.Point(15, 47);
            this.radioButtonDimgrob.Name = "radioButtonDimgrob";
            this.radioButtonDimgrob.Size = new System.Drawing.Size(151, 19);
            this.radioButtonDimgrob.TabIndex = 0;
            this.radioButtonDimgrob.TabStop = true;
            this.radioButtonDimgrob.Text = "DIMGROB_P and BLIT_P";
            this.radioButtonDimgrob.UseVisualStyleBackColor = true;
            this.radioButtonDimgrob.CheckedChanged += new System.EventHandler(this.something_Changed);
            // 
            // radioButtonPixel
            // 
            this.radioButtonPixel.AutoSize = true;
            this.radioButtonPixel.Location = new System.Drawing.Point(15, 22);
            this.radioButtonPixel.Name = "radioButtonPixel";
            this.radioButtonPixel.Size = new System.Drawing.Size(72, 19);
            this.radioButtonPixel.TabIndex = 0;
            this.radioButtonPixel.TabStop = true;
            this.radioButtonPixel.Text = "PIXON_P";
            this.radioButtonPixel.UseVisualStyleBackColor = true;
            this.radioButtonPixel.CheckedChanged += new System.EventHandler(this.something_Changed);
            // 
            // tabPageAdvanced
            // 
            this.tabPageAdvanced.Location = new System.Drawing.Point(4, 24);
            this.tabPageAdvanced.Name = "tabPageAdvanced";
            this.tabPageAdvanced.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAdvanced.Size = new System.Drawing.Size(379, 380);
            this.tabPageAdvanced.TabIndex = 2;
            this.tabPageAdvanced.Text = "Advanced";
            this.tabPageAdvanced.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Maximum recent files:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = global::PrimeComm.Properties.Settings.Default.SkipConflictingProcessChecking;
            this.checkBox1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::PrimeComm.Properties.Settings.Default, "SkipConflictingProcessChecking", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox1.Location = new System.Drawing.Point(15, 22);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(320, 19);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Hide warning about conflicting processes when starting";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // numericUpDownRecentFiles
            // 
            this.numericUpDownRecentFiles.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::PrimeComm.Properties.Settings.Default, "RecentFilesMaximum", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.numericUpDownRecentFiles.Location = new System.Drawing.Point(142, 55);
            this.numericUpDownRecentFiles.Name = "numericUpDownRecentFiles";
            this.numericUpDownRecentFiles.Size = new System.Drawing.Size(48, 23);
            this.numericUpDownRecentFiles.TabIndex = 0;
            this.numericUpDownRecentFiles.Value = global::PrimeComm.Properties.Settings.Default.RecentFilesMaximum;
            // 
            // numericUpDownFontSize
            // 
            this.numericUpDownFontSize.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::PrimeComm.Properties.Settings.Default, "EditorFontSize", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.numericUpDownFontSize.Location = new System.Drawing.Point(142, 26);
            this.numericUpDownFontSize.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDownFontSize.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numericUpDownFontSize.Name = "numericUpDownFontSize";
            this.numericUpDownFontSize.Size = new System.Drawing.Size(48, 23);
            this.numericUpDownFontSize.TabIndex = 0;
            this.numericUpDownFontSize.Value = global::PrimeComm.Properties.Settings.Default.EditorFontSize;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = global::PrimeComm.Properties.Settings.Default.IgnoreInternalName;
            this.checkBox2.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::PrimeComm.Properties.Settings.Default, "IgnoreInternalName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox2.Location = new System.Drawing.Point(15, 22);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(205, 19);
            this.checkBox2.TabIndex = 0;
            this.checkBox2.Text = "Ignore the internal program name";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBoxCompressSpaces
            // 
            this.checkBoxCompressSpaces.AutoSize = true;
            this.checkBoxCompressSpaces.Checked = global::PrimeComm.Properties.Settings.Default.CompressSpaces;
            this.checkBoxCompressSpaces.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::PrimeComm.Properties.Settings.Default, "CompressSpaces", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBoxCompressSpaces.Location = new System.Drawing.Point(35, 122);
            this.checkBoxCompressSpaces.Name = "checkBoxCompressSpaces";
            this.checkBoxCompressSpaces.Size = new System.Drawing.Size(117, 19);
            this.checkBoxCompressSpaces.TabIndex = 0;
            this.checkBoxCompressSpaces.Text = "Compress spaces";
            this.checkBoxCompressSpaces.UseVisualStyleBackColor = true;
            // 
            // checkBoxConversionComment
            // 
            this.checkBoxConversionComment.AutoSize = true;
            this.checkBoxConversionComment.Checked = global::PrimeComm.Properties.Settings.Default.AddCommentOnConversion;
            this.checkBoxConversionComment.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxConversionComment.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::PrimeComm.Properties.Settings.Default, "AddCommentOnConversion", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBoxConversionComment.Location = new System.Drawing.Point(15, 147);
            this.checkBoxConversionComment.Name = "checkBoxConversionComment";
            this.checkBoxConversionComment.Size = new System.Drawing.Size(337, 19);
            this.checkBoxConversionComment.TabIndex = 0;
            this.checkBoxConversionComment.Text = "Add a comment when the file was automatically converted";
            this.checkBoxConversionComment.UseVisualStyleBackColor = true;
            this.checkBoxConversionComment.CheckedChanged += new System.EventHandler(this.something_Changed);
            // 
            // checkBoxEnableAdditionalProgramProcessing
            // 
            this.checkBoxEnableAdditionalProgramProcessing.AutoSize = true;
            this.checkBoxEnableAdditionalProgramProcessing.Checked = global::PrimeComm.Properties.Settings.Default.EnableAdditionalProgramProcessing;
            this.checkBoxEnableAdditionalProgramProcessing.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::PrimeComm.Properties.Settings.Default, "EnableAdditionalProgramProcessing", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBoxEnableAdditionalProgramProcessing.Location = new System.Drawing.Point(15, 47);
            this.checkBoxEnableAdditionalProgramProcessing.Name = "checkBoxEnableAdditionalProgramProcessing";
            this.checkBoxEnableAdditionalProgramProcessing.Size = new System.Drawing.Size(177, 19);
            this.checkBoxEnableAdditionalProgramProcessing.TabIndex = 0;
            this.checkBoxEnableAdditionalProgramProcessing.Text = "Enable additional processing";
            this.checkBoxEnableAdditionalProgramProcessing.UseVisualStyleBackColor = true;
            this.checkBoxEnableAdditionalProgramProcessing.CheckedChanged += new System.EventHandler(this.something_Changed);
            // 
            // checkBoxRemoveComments
            // 
            this.checkBoxRemoveComments.AutoSize = true;
            this.checkBoxRemoveComments.Checked = global::PrimeComm.Properties.Settings.Default.RemoveComments;
            this.checkBoxRemoveComments.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::PrimeComm.Properties.Settings.Default, "RemoveComments", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBoxRemoveComments.Location = new System.Drawing.Point(35, 97);
            this.checkBoxRemoveComments.Name = "checkBoxRemoveComments";
            this.checkBoxRemoveComments.Size = new System.Drawing.Size(129, 19);
            this.checkBoxRemoveComments.TabIndex = 0;
            this.checkBoxRemoveComments.Text = "Remove comments";
            this.checkBoxRemoveComments.UseVisualStyleBackColor = true;
            // 
            // checkBoxObfuscateVariables
            // 
            this.checkBoxObfuscateVariables.AutoSize = true;
            this.checkBoxObfuscateVariables.Checked = global::PrimeComm.Properties.Settings.Default.ObfuscateVariables;
            this.checkBoxObfuscateVariables.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::PrimeComm.Properties.Settings.Default, "ObfuscateVariables", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBoxObfuscateVariables.Location = new System.Drawing.Point(35, 72);
            this.checkBoxObfuscateVariables.Name = "checkBoxObfuscateVariables";
            this.checkBoxObfuscateVariables.Size = new System.Drawing.Size(162, 19);
            this.checkBoxObfuscateVariables.TabIndex = 0;
            this.checkBoxObfuscateVariables.Text = "Obfuscate variable names";
            this.checkBoxObfuscateVariables.UseVisualStyleBackColor = true;
            // 
            // checkBoxImageMethodDimgrobOptimizeBlacks
            // 
            this.checkBoxImageMethodDimgrobOptimizeBlacks.AutoSize = true;
            this.checkBoxImageMethodDimgrobOptimizeBlacks.Checked = global::PrimeComm.Properties.Settings.Default.ImageMethodDimgrobOptimizeBlacks;
            this.checkBoxImageMethodDimgrobOptimizeBlacks.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxImageMethodDimgrobOptimizeBlacks.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::PrimeComm.Properties.Settings.Default, "ImageMethodDimgrobOptimizeBlacks", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBoxImageMethodDimgrobOptimizeBlacks.Location = new System.Drawing.Point(35, 97);
            this.checkBoxImageMethodDimgrobOptimizeBlacks.Name = "checkBoxImageMethodDimgrobOptimizeBlacks";
            this.checkBoxImageMethodDimgrobOptimizeBlacks.Size = new System.Drawing.Size(183, 19);
            this.checkBoxImageMethodDimgrobOptimizeBlacks.TabIndex = 1;
            this.checkBoxImageMethodDimgrobOptimizeBlacks.Text = "Use short form for black color";
            this.checkBoxImageMethodDimgrobOptimizeBlacks.UseVisualStyleBackColor = true;
            // 
            // checkBoxImageMethodDimgrobOptimizeSimilar
            // 
            this.checkBoxImageMethodDimgrobOptimizeSimilar.AutoSize = true;
            this.checkBoxImageMethodDimgrobOptimizeSimilar.Checked = global::PrimeComm.Properties.Settings.Default.ImageMethodDimgrobOptimizeSimilar;
            this.checkBoxImageMethodDimgrobOptimizeSimilar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxImageMethodDimgrobOptimizeSimilar.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::PrimeComm.Properties.Settings.Default, "ImageMethodDimgrobOptimizeSimilar", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBoxImageMethodDimgrobOptimizeSimilar.Location = new System.Drawing.Point(35, 72);
            this.checkBoxImageMethodDimgrobOptimizeSimilar.Name = "checkBoxImageMethodDimgrobOptimizeSimilar";
            this.checkBoxImageMethodDimgrobOptimizeSimilar.Size = new System.Drawing.Size(205, 19);
            this.checkBoxImageMethodDimgrobOptimizeSimilar.TabIndex = 1;
            this.checkBoxImageMethodDimgrobOptimizeSimilar.Text = "Optimize similar blocks if possible";
            this.checkBoxImageMethodDimgrobOptimizeSimilar.UseVisualStyleBackColor = true;
            // 
            // linkLabelClearRecent
            // 
            this.linkLabelClearRecent.AutoSize = true;
            this.linkLabelClearRecent.Location = new System.Drawing.Point(204, 57);
            this.linkLabelClearRecent.Name = "linkLabelClearRecent";
            this.linkLabelClearRecent.Size = new System.Drawing.Size(92, 15);
            this.linkLabelClearRecent.TabIndex = 3;
            this.linkLabelClearRecent.TabStop = true;
            this.linkLabelClearRecent.Text = "clear recent files";
            this.linkLabelClearRecent.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelClearRecent_LinkClicked);
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 461);
            this.Controls.Add(this.tabControlPreferences);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonCancel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Preferences";
            this.Load += new System.EventHandler(this.FormSettings_Load);
            this.tabControlPreferences.ResumeLayout(false);
            this.tabPageGeneral.ResumeLayout(false);
            this.tabPageGeneral.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPageProgram.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPageImages.ResumeLayout(false);
            this.groupBoxDithering.ResumeLayout(false);
            this.groupBoxDithering.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRecentFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFontSize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.TabControl tabControlPreferences;
        private System.Windows.Forms.TabPage tabPageGeneral;
        private System.Windows.Forms.TabPage tabPageProgram;
        private System.Windows.Forms.TabPage tabPageAdvanced;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBoxCompressSpaces;
        private System.Windows.Forms.CheckBox checkBoxRemoveComments;
        private System.Windows.Forms.CheckBox checkBoxObfuscateVariables;
        private System.Windows.Forms.CheckBox checkBoxEnableAdditionalProgramProcessing;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TabPage tabPageImages;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonPixel;
        private System.Windows.Forms.CheckBox checkBoxImageMethodDimgrobOptimizeBlacks;
        private System.Windows.Forms.CheckBox checkBoxImageMethodDimgrobOptimizeSimilar;
        private System.Windows.Forms.RadioButton radioButtonDimgrob;
        private System.Windows.Forms.RadioButton radioButtonIcon;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.LinkLabel linkLabelClearWarnings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxConversionComment;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownFontSize;
        private System.Windows.Forms.GroupBox groupBoxDithering;
        private System.Windows.Forms.ComboBox comboBoxImageDitheringMethod;
        private System.Windows.Forms.LinkLabel linkLabelDitheringInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownRecentFiles;
        private System.Windows.Forms.LinkLabel linkLabelClearRecent;
    }
}