﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PrimeComm.Properties;
using PrimeLib;

namespace PrimeComm
{
    public partial class FormSettings : Form
    {
        public FormSettings(int startTab = 0)
        {
            InitializeComponent();

            if (Environment.OSVersion.Version.Major < 6)
                groupBoxDithering.Visible = false;

            foreach (var d in Enum.GetValues(typeof(DitherType)))
                comboBoxImageDitheringMethod.Items.Add(d);

            comboBoxImageDitheringMethod.SelectedItem = Settings.Default.ImageDitheringMethod;

            if (startTab < tabControlPreferences.TabCount)
                tabControlPreferences.SelectedIndex = startTab;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveAndExit();
        }

        private void SaveAndExit()
        {
            Utilities.UpdateRecentFiles();
            Settings.Default.Save();
            DialogResult = DialogResult.OK;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to reset all settings to the default value?", "Reset settings",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Settings.Default.Reset();
                LoadSettings();
                //SaveAndExit();
            }
        }

        private void something_Changed(object sender, EventArgs e)
        {
            UpdateGui();
        }

        private void UpdateGui()
        {
            // Program options
            checkBoxCompressSpaces.Enabled = checkBoxEnableAdditionalProgramProcessing.Checked;
            checkBoxObfuscateVariables.Enabled = checkBoxEnableAdditionalProgramProcessing.Checked;
            checkBoxRemoveComments.Enabled = checkBoxEnableAdditionalProgramProcessing.Checked;

            // Image output
            if (radioButtonPixel.Checked)
                Settings.Default.ImageMethod = ImageProcessingMode.Pixels;
            else if (radioButtonIcon.Checked)
                Settings.Default.ImageMethod = ImageProcessingMode.Icon;
            else
                Settings.Default.ImageMethod = ImageProcessingMode.DimgrobPieces;

            checkBoxImageMethodDimgrobOptimizeBlacks.Enabled = Settings.Default.ImageMethod == ImageProcessingMode.DimgrobPieces;
            checkBoxImageMethodDimgrobOptimizeSimilar.Enabled = Settings.Default.ImageMethod == ImageProcessingMode.DimgrobPieces;
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            LoadSettings();
        }

        private void LoadSettings()
        {
            // Output method
            switch (Settings.Default.ImageMethod)
            {
                case ImageProcessingMode.Pixels:
                    radioButtonPixel.Checked = true;
                    break;

                case ImageProcessingMode.Icon:
                    radioButtonIcon.Checked = true;
                    break;

                default:
                    radioButtonDimgrob.Checked = true;
                    break;
            }

            // Image reduction
            comboBoxImageDitheringMethod.SelectedItem = Settings.Default.ImageDitheringMethod;
        }

        private void CreateAdvancedSettings(TabPage tabPage)
        {
            var advancedSettings = new List<String>(new[] { "VariableRefactoringStartingSeed", "ProgramTemplate" });
            foreach (SettingsProperty r in Settings.Default.Properties)
                if (r.Name.StartsWith("Regex"))
                    advancedSettings.Add(r.Name);

            advancedSettings.Sort();

            var table = new TableLayoutPanel {ColumnCount = 2, RowCount = advancedSettings.Count() + 1, Dock = DockStyle.Fill};
            
            var row = 0;
            foreach (var s in advancedSettings)
            {
                var l = new Label { Text = s, Anchor = AnchorStyles.Left, AutoSize = true };
                table.Controls.Add(l);
                table.SetRow(l, row);
                table.SetColumn(l, 0);

                var t = new TextBox { Dock = DockStyle.Fill, Multiline = true, ScrollBars = ScrollBars.Vertical, Height=38 };
                t.DataBindings.Add(new Binding("Text", Settings.Default, s, true,DataSourceUpdateMode.OnPropertyChanged));
                table.Controls.Add(t);
                table.SetRow(t, row++);
                table.SetColumn(t, 1);
            }


            for (var i = 0; i < table.ColumnCount; i++)
                table.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));

            for (var i = 0; i < table.RowCount; i++)
                table.RowStyles.Add(new RowStyle(SizeType.AutoSize));

            tabPage.Controls.Add(table);
        }

        private void tabControlPreferences_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPage == tabPageAdvanced && tabPageAdvanced.Controls.Count == 0)
                CreateAdvancedSettings(e.TabPage);
        }

        private void linkLabelClearWarnings_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Settings.Default.SkipFullscreenWarning = false;
            linkLabelClearWarnings.Enabled = false;
        }

        private void comboBoxImageDitheringMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            Settings.Default.ImageDitheringMethod = (DitherType)comboBoxImageDitheringMethod.SelectedItem;
        }

        private void linkLabelDitheringInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://msdn.microsoft.com/en-us/library/windows/desktop/ms534106(v=vs.85).aspx");
        }

        private void linkLabelClearRecent_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Settings.Default.RecentOpenedFiles.Clear();
            linkLabelClearRecent.Enabled = false;
        }
    }
}
