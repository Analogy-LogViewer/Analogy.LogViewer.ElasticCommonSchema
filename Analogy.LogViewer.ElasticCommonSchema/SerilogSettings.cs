﻿using System.Collections.Generic;

namespace Analogy.LogViewer.ElasticCommonSchema
{

    public class SerilogSettings
    {
        public bool UseApplicationFolderForSettings { get; set; }
        public string FileOpenDialogFilters { get; set; }
        public string FileSaveDialogFilters { get; } = string.Empty;
        public List<string> SupportFormats { get; set; }
        public string Directory { get; set; }
        public List<string> IgnoredAttributes { get; set; }

        public SerilogSettings()
        {
            Directory = string.Empty;
            IgnoredAttributes = new List<string>() { "N" };
            FileOpenDialogFilters = "All Supported formats (*.Clef;*.log;*.gz)|*.clef;*.log;*.gz|Clef format (*.clef)|*.clef|Plain log text file (*.log)|*.log|GZIP file (*.gz)|*.gz";
            SupportFormats = new List<string> { "*.Clef", "*.log", "*.gz" };
        }




    }
}
