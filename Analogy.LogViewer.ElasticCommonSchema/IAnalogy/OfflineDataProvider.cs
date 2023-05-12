using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Analogy.Interfaces;
using Analogy.LogViewer.ElasticCommonSchema.DataTypes;
using Analogy.LogViewer.ElasticCommonSchema.Managers;
using Analogy.LogViewer.ElasticCommonSchema.Parsers;
using Analogy.LogViewer.Template.Managers;

namespace Analogy.LogViewer.ElasticCommonSchema.IAnalogy
{
    public class OfflineDataProvider : Analogy.LogViewer.Template.OfflineDataProvider
    {
        public override Guid Id { get; set; } = new Guid("8f5b7e86-cb90-4281-8170-4b2342104a60");
        public override Image LargeImage { get; set; } = null;
        public override Image SmallImage { get; set; } = null;
        public override string OptionalTitle { get; set; } = "Serilog offline reader";
        public override bool CanSaveToLogFile { get; set; } = false;
        public override string FileOpenDialogFilters { get; set; } = UserSettingsManager.UserSettings.Settings.FileOpenDialogFilters;
        public override string FileSaveDialogFilters { get; set; } = string.Empty;
        public override IEnumerable<string> SupportFormats { get; set; } = UserSettingsManager.UserSettings.Settings.SupportFormats;
        public override bool DisableFilePoolingOption { get; set; } = false;

        public override string InitialFolderFullPath =>
            (!string.IsNullOrEmpty(UserSettingsManager.UserSettings.Settings.Directory) &&
             Directory.Exists(UserSettingsManager.UserSettings.Settings.Directory))
                ? UserSettingsManager.UserSettings.Settings.Directory
                : Environment.CurrentDirectory;
        private EcsJsonFileParser EcsJsonFileParser { get; }

        public override bool UseCustomColors { get; set; } = false;
        public override IEnumerable<(string originalHeader, string replacementHeader)> GetReplacementHeaders()
            => Array.Empty<(string, string)>();

        public override (Color backgroundColor, Color foregroundColor) GetColorForMessage(IAnalogyLogMessage logMessage)
            => (Color.Empty, Color.Empty);
        public OfflineDataProvider()
        {
            EcsJsonFileParser = new EcsJsonFileParser(new JsonFormatMessageFields());
        }
        public override Task InitializeDataProvider(IAnalogyLogger logger)
        {
            return base.InitializeDataProvider(logger);
        }

        public override async Task<IEnumerable<IAnalogyLogMessage>> Process(string fileName, CancellationToken token, ILogMessageCreatedHandler messagesHandler)
        {
            if (CanOpenFile(fileName))
            {
                return await EcsJsonFileParser.Process(fileName, token, messagesHandler);
            }
            LogManager.Instance.LogError($"Unsupported File {fileName}", nameof(OfflineDataProvider));
            return new List<AnalogyLogMessage>(0);
        }

        public override bool CanOpenFile(string fileName)
        {
            foreach (string pattern in UserSettingsManager.UserSettings.Settings.SupportFormats)
            {
                if (CommonUtilities.Files.FilesPatternMatcher.StrictMatchPattern(pattern, fileName))
                {
                    return true;
                }
            }
            return false;
        }

        protected override List<FileInfo> GetSupportedFilesInternal(DirectoryInfo dirInfo, bool recursive)
        {
            List<FileInfo> files = new List<FileInfo>();
            foreach (string pattern in UserSettingsManager.UserSettings.Settings.SupportFormats)
            {
                files.AddRange(dirInfo.GetFiles(pattern).ToList());
            }

            if (!recursive)
            {
                return files;
            }

            try
            {
                foreach (DirectoryInfo dir in dirInfo.GetDirectories())
                {
                    files.AddRange(GetSupportedFilesInternal(dir, true));
                }
            }
            catch (Exception)
            {
                return files;
            }

            return files;
        }

        //public static FileFormat TryDetectFormat(string fileName)
        //{
        //    string jsonData = string.Empty;
        //    if (fileName.EndsWith(".gz", StringComparison.InvariantCultureIgnoreCase))
        //    {
        //        using (var fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
        //        {
        //            using (var gzStream = new GZipStream(fileStream, CompressionMode.Decompress))
        //            {
        //                using (var streamReader = new StreamReader(gzStream, encoding: Encoding.UTF8))
        //                {
        //                    jsonData = streamReader.ReadToEnd();
        //                }
        //            }
        //        }
        //    }

        //    if (string.IsNullOrEmpty(jsonData))
        //    {
        //        jsonData = SafeReadAllLines(fileName);
        //    }

        //    var format = TryParseAsFile(jsonData);
        //    if (format == FileFormat.Unknown)
        //    {
        //        format = TryParsePerLine(jsonData);
        //    }

        //    return format;
        //}
        //private static FileFormat TryParsePerLine(string jsonData)
        //{
        //    try
        //    {
        //        IMessageFields fields = new JsonFormatMessageFields();
        //        if (jsonData.Contains(fields.Timestamp) && jsonData.Contains(fields.MessageTemplate))
        //        {
        //            return FileFormat.JsonFormatPerLine;
        //        }

        //        fields = new CompactJsonFormatMessageFields();
        //        if (jsonData.Contains(fields.Timestamp) && jsonData.Contains(fields.MessageTemplate))
        //        {
        //            return FileFormat.CompactJsonFormatPerLine;
        //        }

        //        return FileFormat.Unknown;
        //    }
        //    catch (Exception)
        //    {
        //        return FileFormat.Unknown;
        //    }
        //}

        //private static FileFormat TryParseAsFile(string jsonData)
        //{
        //    try
        //    {
        //        var jsonObject = JsonConvert.DeserializeObject(jsonData);
        //        IMessageFields fields = new JsonFormatMessageFields();
        //        if (jsonData.Contains(fields.Timestamp) && jsonData.Contains(fields.MessageTemplate))
        //        {
        //            return FileFormat.JsonFormatFile;
        //        }

        //        fields = new CompactJsonFormatMessageFields();
        //        if (jsonData.Contains(fields.Timestamp) && jsonData.Contains(fields.MessageTemplate))
        //        {
        //            return FileFormat.CompactJsonFormatPerFile;
        //        }

        //        return FileFormat.Unknown;
        //    }
        //    catch (Exception)
        //    {
        //        return FileFormat.Unknown;
        //    }
        //}

        private static string SafeReadAllLines(string path)
        {
            using (var stream = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            using (var sr = new StreamReader(stream))
            {
                string data = sr.ReadToEnd();
                return data;
            }
        }
    }
}
