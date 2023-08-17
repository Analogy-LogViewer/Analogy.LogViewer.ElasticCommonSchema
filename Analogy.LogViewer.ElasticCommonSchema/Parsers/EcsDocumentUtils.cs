using Analogy.Interfaces;
using Elastic.CommonSchema;
using System;
using System.Collections.Generic;

namespace Analogy.LogViewer.ElasticCommonSchema.Parsers
{
    public static class EcsDocumentUtils
    {
        public static IAnalogyLogMessage ParseLine(string line,bool addAllMetadataFields, List<string> addSpecificMetadataFields)
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

            try
            {
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
                ThreadId = (int)(entry.Process?.ThreadId ?? 0),
                LineNumber = (int)(entry.Log?.OriginFileLine ?? 0),
                MethodName = entry.Log?.OriginFunction ?? "",
                FileName = entry.Log?.OriginFileName ?? "",
                Module = entry.Process?.Name ?? string.Empty,
                Source = entry.Log?.Logger ?? string.Empty,
                User = entry.User?.Name ?? "",
            };
            if (entry.Error?.Message is not null)
            {
                message.AddOrReplaceAdditionalProperty("Error", entry.Error.Message);
            }
            if (entry.Error?.StackTrace is not null)
            {
                message.AddOrReplaceAdditionalProperty("StackTrace", entry.Error.StackTrace);
            }
            if (entry.Log?.Logger is not null)
            {
                message.AddOrReplaceAdditionalProperty("Logger", entry.Log.Logger);
            }

                //if (entry.Labels is not null)
                //{
                //    foreach (KeyValuePair<string, string> label in entry.Labels)
                //    {
                //        message.AddOrReplaceAdditionalProperty(label.Key, label.Value);
                //    }
                //}
                if (entry.Metadata is not null)
                {
                    foreach (KeyValuePair<string, object?> md in entry.Metadata)
                    {
                        if (md.Value is not null && (addAllMetadataFields || addSpecificMetadataFields.Contains(md.Key)))
                        {
                            message.AddOrReplaceAdditionalProperty(md.Key, md.Value.ToString());
                        }
                    }
                }

                return message;
            }
            catch (Exception e)
            {
                AnalogyErrorMessage aem = new($"Error parsing line: {line}. Error: {e.Message}", line,
                    AnalogyRowTextType.PlainText);
                return aem;
            }
        }
    }
}
