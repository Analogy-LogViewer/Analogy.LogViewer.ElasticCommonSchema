using Analogy.Interfaces;
using Analogy.LogViewer.ElasticCommonSchema.DataTypes;
using Analogy.LogViewer.ElasticCommonSchema.Managers;
using Elastic.CommonSchema;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Analogy.LogViewer.ElasticCommonSchema.Parsers
{
    public class EcsJsonFileParser
    {
        private IMessageFields messageFields;
        private JsonSerializerSettings JsonSerializerSettings;

        public EcsJsonFileParser(IMessageFields messageFields)
        {
            this.messageFields = messageFields;
            JsonSerializerSettings = new JsonSerializerSettings
            {
                DateParseHandling = DateParseHandling.DateTimeOffset,
                DateFormatHandling = DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = DateTimeZoneHandling.Utc,
            };
        }

        public async Task<IEnumerable<IAnalogyLogMessage>> Process(string fileName, CancellationToken token,
            ILogMessageCreatedHandler messagesHandler)
        {
            if (string.IsNullOrEmpty(fileName))
            {
                AnalogyLogMessage empty = new AnalogyLogMessage($"File is null or empty. Aborting.",
                    AnalogyLogLevel.Critical, AnalogyLogClass.General, "Analogy", "None")
                {
                    Source = "Analogy",
                    Module = System.Diagnostics.Process.GetCurrentProcess().ProcessName,
                };
                messagesHandler.AppendMessage(empty, fileName);
                return new List<IAnalogyLogMessage> { empty };
            }

            List<IAnalogyLogMessage> messages = new();
            try
            {
                using (var stream = System.IO.File.Open(fileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    long count = 0;
                    using (var reader = new StreamReader(stream))
                    {
                        while (!reader.EndOfStream && !token.IsCancellationRequested)
                        {
                            var line = await reader.ReadLineAsync();
                            var message = EcsDocumentUtils.ParseLine(line,
                                UserSettingsManager.UserSettings.Settings.ShowAllColumnsFromMetaDataField,
                                UserSettingsManager.UserSettings.Settings.AdditionalColumnsFromMetaDataField);
                            messages.Add(message);
                            messagesHandler.AppendMessage(message, fileName);
                        }

                        return messages;
                    }
                }
            }
            catch (Exception e)
            {
                AnalogyLogMessage empty = new AnalogyLogMessage(
                    $"Error occurred processing file {fileName}. Reason: {e.Message}",
                    AnalogyLogLevel.Critical, AnalogyLogClass.General, "Analogy", "None")
                {
                    Source = "Analogy",
                    Module = System.Diagnostics.Process.GetCurrentProcess().ProcessName,
                };
                messagesHandler.AppendMessage(empty, fileName);
                return new List<AnalogyLogMessage> { empty };
            }
        }
    }
}