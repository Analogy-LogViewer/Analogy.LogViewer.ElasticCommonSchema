using System.Collections.Generic;

namespace Analogy.LogViewer.ElasticCommonSchema
{

    public class ECSSettings
    {
        public bool ShowAllColumnsFromMetaDataField { get; set; }
        public List<string> AdditionalColumnsFromMetaDataField { get; set; }
        public string FileOpenDialogFilters { get; set; }
        public List<string> SupportFormats { get; set; }
        
        public ECSSettings()
        {
            ShowAllColumnsFromMetaDataField = true;
            AdditionalColumnsFromMetaDataField = new List<string>() { };
            FileOpenDialogFilters = "All Supported formats (*.Clef;*.log;*.gz)|*.clef;*.log;*.gz|Clef format (*.clef)|*.clef|Plain log text file (*.log)|*.log|GZIP file (*.gz)|*.gz";
            SupportFormats = new List<string> { "*.Clef", "*.log", "*.gz" };

        }




    }
}
