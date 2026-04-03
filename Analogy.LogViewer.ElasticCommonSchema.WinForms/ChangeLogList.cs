using Analogy.Interfaces;
using Analogy.Interfaces.DataTypes;
using System;
using System.Collections.Generic;

namespace Analogy.LogViewer.ElasticCommonSchema
{
    public static class ChangeLogList
    {
        public static IEnumerable<AnalogyChangeLog> GetChangeLog() =>
        new List<AnalogyChangeLog>
        {
            new AnalogyChangeLog("Initial version", AnalogChangeLogType.None, "Lior Banai", new DateTime(2023, 05, 12), ""),
        };
    }
}