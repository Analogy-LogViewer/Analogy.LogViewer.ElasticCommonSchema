namespace Analogy.LogViewer.Elastic.CommonSchema.Serilog.DataTypes
{
    public enum FileFormat
    {
        Unknown,
        CompactJsonFormatPerLine,
        JsonFormatPerLine,
        CompactJsonFormatPerFile,
        JsonFormatFile,
    }

    public enum FileFormatDetection
    {
        Automatic,
        Manual
    }
}
