using Analogy.Interfaces;
using Analogy.LogViewer.ElasticCommonSchema.Properties;
using Analogy.LogViewer.Template.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace Analogy.LogViewer.ElasticCommonSchema.IAnalogy
{
    public class PrimaryFactory : PrimaryFactoryWinForms
    {
        internal static Guid Id { get; } = new Guid("0423c76e-7753-43f4-94c5-2608c40dcf77");
        public override Guid FactoryId { get; set; } = Id;
        public override string Title { get; set; } = "Elastic Common Schema";
        public override IEnumerable<IAnalogyChangeLog> ChangeLog { get; set; } = ChangeLogList.GetChangeLog();
        public override IEnumerable<string> Contributors { get; set; } = new List<string> { "Lior Banai" };
        public override string About { get; set; } = "Elastic Common Schema Parsers for Analogy Log Viewer";
        public override Image SmallImage { get; set; } = Resources.AnalogyECS16x16;
        public override Image LargeImage { get; set; } = Resources.AnalogyECS32x32;
    }
}