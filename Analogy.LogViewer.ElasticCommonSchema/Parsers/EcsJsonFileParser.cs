using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Analogy.Interfaces;
using Analogy.Interfaces.DataTypes;
using Analogy.LogViewer.Elastic.CommonSchema.Serilog.DataTypes;
using Elastic.CommonSchema;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Serilog;

namespace Analogy.LogViewer.Elastic.CommonSchema.Serilog.Parsers
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
        public async Task<IEnumerable<IAnalogyLogMessage>> Process(string fileName, CancellationToken token, ILogMessageCreatedHandler messagesHandler)
        {
            if (string.IsNullOrEmpty(fileName))
            {
                AnalogyLogMessage empty = new AnalogyLogMessage($"File is null or empty. Aborting.",
                    AnalogyLogLevel.Critical, AnalogyLogClass.General, "Analogy", "None")
                {
                    Source = "Analogy",
                    Module = System.Diagnostics.Process.GetCurrentProcess().ProcessName
                };
                messagesHandler.AppendMessage(empty, fileName);
                return new List<IAnalogyLogMessage> { empty };
            }
            List<IAnalogyLogMessage> messages = new List<IAnalogyLogMessage>();
            try
            {
                var jsonLines = System.IO.File.ReadAllLines(fileName);
                foreach (var line in jsonLines)
                {
                    var entry = EcsDocument.Deserialize(line);
                    AnalogyLogMessage message = new AnalogyLogMessage()
                    {
                        Date = entry.Timestamp?.DateTime ?? DateTime.MinValue,
                        Level = AnalogyLogMessage.ParseLogLevelFromString(entry.Log.Level),
                        RawText = line,
                        RawTextType = AnalogyRowTextType.JSON,
                        Text = entry.Message,
                        MachineName = entry.Host?.Hostname ?? "",
                        ProcessId = (int)(entry.Process?.Pid ?? 0),
                        LineNumber = (int)(entry.Log?.OriginFileLine ?? 0),
                        MethodName = entry.Log?.OriginFunction ?? "",
                        FileName = entry.Log?.OriginFileName ?? "",


                    };
                    messages.Add(message);
                    messagesHandler.AppendMessage(message, fileName);

                }
                return messages;
            }
            catch (Exception e)
            {
                AnalogyLogMessage empty = new AnalogyLogMessage($"Error occurred processing file {fileName}. Reason: {e.Message}",
                    AnalogyLogLevel.Critical, AnalogyLogClass.General, "Analogy", "None")
                {
                    Source = "Analogy",
                    Module = System.Diagnostics.Process.GetCurrentProcess().ProcessName
                };
                messagesHandler.AppendMessage(empty, fileName);
                return new List<AnalogyLogMessage> { empty
    };
            }
        }
    }
}
