using Analogy.LogViewer.ElasticCommonSchema.Managers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Analogy.LogViewer.ElasticCommonSchema.UserControls
{
    public partial class ECSUCSettings : UserControl
    {
        private ECSSettings Settings => UserSettingsManager.UserSettings.Settings;
        public ECSUCSettings()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveSettings();
        }
        public void SaveSettings()
        {
            Settings.ShowAllColumnsFromMetaDataField = cbShowAllMetadataFields.Checked;
            Settings.AdditionalColumnsFromMetaDataField = lstbAdditionalColumn.Items.Count > 0 ? lstbAdditionalColumn.Items.Cast<string>().ToList() : new List<string>();
            UserSettingsManager.UserSettings.Save();
        }

        private void btnExportSettings_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Analogy Serilog Settings (*.serilogsettings)|*.serilogsettings";
            saveFileDialog.Title = @"Export settings";

            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                SaveSettings();
                try
                {
                    File.WriteAllText(saveFileDialog.FileName, JsonConvert.SerializeObject(Settings));
                    MessageBox.Show("File Saved", @"Export settings", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Export: " + ex.Message, @"Error Saving file", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Analogy Serilog Settings (*.Json)|*.json";
            openFileDialog1.Title = @"Import Serilog settings";
            openFileDialog1.Multiselect = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var json = File.ReadAllText(openFileDialog1.FileName);
                    ECSSettings settings = JsonConvert.DeserializeObject<ECSSettings>(json);
                    LoadSettings(settings);
                    MessageBox.Show("File Imported. Save settings if desired", @"Import settings", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Import: " + ex.Message, @"Error Import file", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void LoadSettings(ECSSettings logSettings)
        {
            cbShowAllMetadataFields.Checked = logSettings.ShowAllColumnsFromMetaDataField;
            lstbAdditionalColumn.Items.Clear();
            lstbAdditionalColumn.Items.AddRange(logSettings.AdditionalColumnsFromMetaDataField.ToArray());
        }

        private void SerilogUCSettings_Load(object sender, EventArgs e)
        {
            LoadSettings(UserSettingsManager.UserSettings.Settings);
        }

        private void btnIgnoreColumn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbIgnoreColumn.Text))
            {
                return;
            }

            lstbAdditionalColumn.Items.Add(txtbIgnoreColumn.Text);
        }

        private void btnDeleteIgnoreColumn_Click(object sender, EventArgs e)
        {
            if (lstbAdditionalColumn.SelectedItem is string ignore)
            {
                lstbAdditionalColumn.Items.Remove(lstbAdditionalColumn.SelectedItem);
            }
        }
    }
}