using System;
using System.IO;
using Analogy.LogViewer.Template.Managers;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace Analogy.LogViewer.ElasticCommonSchema.Managers
{
    public class UserSettingsManager
    {

        private static readonly Lazy<UserSettingsManager> _instance =
            new Lazy<UserSettingsManager>(() => new UserSettingsManager());
        public static UserSettingsManager UserSettings { get; set; } = _instance.Value;
        private string LocalSettingFileName { get; } = "Analogy.ElasticCommonSchema.Settings.json";

        public string SerilogPerUserFileSetting => Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Analogy.LogViewer", LocalSettingFileName);
        public ECSSettings Settings { get; set; }

        public UserSettingsManager()
        {

            //check if local file exist:
            var loaded = LoadFileSettings(LocalSettingFileName, true);
            if (!loaded)
            {
                LoadFileSettings(SerilogPerUserFileSetting, false);
            }

        }

        private bool LoadFileSettings(string localSettingFileName, bool optional)
        {
            if (File.Exists(localSettingFileName))
            {
                try
                {
                    var settings = new JsonSerializerSettings
                    {
                        ObjectCreationHandling = ObjectCreationHandling.Replace
                    };
                    string data = File.ReadAllText(localSettingFileName);
                    Settings = JsonConvert.DeserializeObject<ECSSettings>(data, settings);
                    if (string.IsNullOrEmpty(Settings.FileOpenDialogFilters))
                    {
                        Settings.FileOpenDialogFilters = "All Supported formats (*.Clef;*.log;*.gz)|*.clef;*.log;*.gz|Clef format (*.clef)|*.clef|Plain log text file (*.log)|*.log|GZIP file (*.gz)|*.gz";

                    }
                    return true;
                }
                catch (Exception ex)
                {
                    LogManager.Instance.LogWarning($"Error loading user setting file: {ex.Message}", "Analogy Serilog Parser");
                    Settings = new ECSSettings();
                    if (string.IsNullOrEmpty(Settings.FileOpenDialogFilters))
                    {
                        Settings.FileOpenDialogFilters = "All Supported formats (*.Clef;*.log;*.gz)|*.clef;*.log;*.gz|Clef format (*.clef)|*.clef|Plain log text file (*.log)|*.log|GZIP file (*.gz)|*.gz";

                    }
                    return true;
                }
            }
            else
            {
                if (!optional)
                {
                    Settings = new ECSSettings();
                    if (string.IsNullOrEmpty(Settings.FileOpenDialogFilters))
                    {
                        Settings.FileOpenDialogFilters = "All Supported formats (*.Clef;*.log;*.gz)|*.clef;*.log;*.gz|Clef format (*.clef)|*.clef|Plain log text file (*.log)|*.log|GZIP file (*.gz)|*.gz";

                    }
                    return false;
                }
            }

            return false;
        }

        public void Save()
        {
            try
            {

                if (File.Exists(LocalSettingFileName))
                {
                    try
                    {
                        File.Delete(LocalSettingFileName);
                    }
                    catch (Exception e)
                    {
                        LogManager.Instance.LogError($"Error deleting local file: {e.Message}");
                    }
                }
                File.WriteAllText(SerilogPerUserFileSetting, JsonConvert.SerializeObject(Settings));
            }
            catch (Exception e)
            {
                LogManager.Instance.LogError(e, "Error saving settings: " + e.Message);
            }
        }
    }
}
