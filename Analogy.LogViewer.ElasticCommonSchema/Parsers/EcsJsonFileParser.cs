using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Analogy.Interfaces;
using Analogy.LogViewer.ElasticCommonSchema.DataTypes;
using Elastic.CommonSchema;
using Newtonsoft.Json;

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
                    Source = "Analogy", Module = System.Diagnostics.Process.GetCurrentProcess().ProcessName
                };
                messagesHandler.AppendMessage(empty, fileName);
                return new List<IAnalogyLogMessage> { empty };
            }

            List<IAnalogyLogMessage> messages = new List<IAnalogyLogMessage>();
            try
            {
#if NET
                var jsonLines = await System.IO.File.ReadAllLinesAsync(fileName, token);
#else
                var jsonLines = System.IO.File.ReadAllLines(fileName);
#endif
                foreach (var line in jsonLines)
                {
                    var message = EcsDocumentUtils.ParseLine(line);
                    messages.Add(message);
                    messagesHandler.AppendMessage(message, fileName);
                }
                return messages;
            }
            catch (Exception e)
            {
                AnalogyLogMessage empty = new AnalogyLogMessage(
                    $"Error occurred processing file {fileName}. Reason: {e.Message}",
                    AnalogyLogLevel.Critical, AnalogyLogClass.General, "Analogy", "None")
                {
                    Source = "Analogy", Module = System.Diagnostics.Process.GetCurrentProcess().ProcessName
                };
                messagesHandler.AppendMessage(empty, fileName);
                return new List<AnalogyLogMessage> { empty };
            }
        }
    }
}
