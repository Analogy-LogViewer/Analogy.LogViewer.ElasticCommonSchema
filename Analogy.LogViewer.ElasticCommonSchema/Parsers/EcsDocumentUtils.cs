using Analogy.Interfaces;
using Elastic.CommonSchema;
using System;

namespace Analogy.LogViewer.ElasticCommonSchema.Parsers
{
    public static class EcsDocumentUtils
    {
        public static IAnalogyLogMessage ParseLine(string line)
        {
            string GetMessage(EcsDocument ecsDocument)
            {
                if (ecsDocument.Error is not null)
                {
                    return
                        $"{ecsDocument.Message}.{Environment.NewLine}Exception:{ecsDocument.Error.Message}{Environment.NewLine}StackTrace:{ecsDocument.Error.StackTrace}";
                }
                return ecsDocument.Message ?? "";
            }
            var entry = EcsDocument.Deserialize(line);
            AnalogyLogMessage message = new()
            {
                Date = entry.Timestamp?.DateTime ?? DateTime.MinValue,
                Level = AnalogyLogMessage.ParseLogLevelFromString(entry.Log.Level),
                RawText = line,
                RawTextType = AnalogyRowTextType.JSON,
                Text = GetMessage(entry),
                MachineName = entry.Host?.Hostname ?? "",
                ProcessId = (int)(entry.Process?.Pid ?? 0),
                LineNumber = (int)(entry.Log?.OriginFileLine ?? 0),
                MethodName = entry.Log?.OriginFunction ?? "",
                FileName = entry.Log?.OriginFileName ?? "",
                User = entry.User?.Name ?? "Unknown",
            };
            if (entry.Error?.Message != null)
            {
                message.AddOrReplaceAdditionalProperty("Error",entry.Error.Message);
            }
            if (entry.Error?.StackTrace != null)
            {
                message.AddOrReplaceAdditionalProperty("StackTrace", entry.Error.StackTrace);
            }
            return message;
        }
    }
}
