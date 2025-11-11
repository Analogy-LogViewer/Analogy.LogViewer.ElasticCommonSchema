using Analogy.Interfaces;
using Analogy.Interfaces.DataTypes;
using Analogy.LogViewer.ElasticCommonSchema.DataTypes;
using Analogy.LogViewer.ElasticCommonSchema.Managers;
using Analogy.LogViewer.ElasticCommonSchema.Parsers;
using Analogy.LogViewer.ElasticCommonSchema.Properties;
using Analogy.LogViewer.Template.Managers;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Analogy.LogViewer.ElasticCommonSchema.IAnalogy
{
    public class OfflineDataProvider : Analogy.LogViewer.Template.OfflineDataProviderWinForms
    {
        public override Guid Id { get; set; } = new Guid("1e3e3bb2-3130-4311-8c47-740a5f692d6d");
        public override Image LargeImage { get; set; } = Resources.AnalogyECS32x32;
        public override Image SmallImage { get; set; } = Resources.AnalogyECS16x16;
        public override string OptionalTitle { get; set; } = "Elastic Common Schema parser";
        public override bool CanSaveToLogFile { get; set; }
        public override string FileOpenDialogFilters { get; set; } = UserSettingsManager.UserSettings.Settings.FileOpenDialogFilters;
        public override string FileSaveDialogFilters { get; set; } = string.Empty;
        public override IEnumerable<string> SupportFormats { get; set; } = UserSettingsManager.UserSettings.Settings.SupportFormats;
        public override bool DisableFilePoolingOption { get; set; }

        public override string InitialFolderFullPath => Environment.CurrentDirectory;
        private EcsJsonFileParser EcsJsonFileParser { get; }

        public override bool UseCustomColors { get; set; }
        public override IEnumerable<(string OriginalHeader, string ReplacementHeader)> GetReplacementHeaders()
            => Array.Empty<(string, string)>();

        public override (Color BackgroundColor, Color ForegroundColor) GetColorForMessage(IAnalogyLogMessage logMessage)
            => (Color.Empty, Color.Empty);
        public OfflineDataProvider()
        {
            EcsJsonFileParser = new EcsJsonFileParser(new JsonFormatMessageFields());
        }
        public override Task InitializeDataProvider(ILogger logger)
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
    }
}