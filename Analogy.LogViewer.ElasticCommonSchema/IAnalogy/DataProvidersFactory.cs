using Analogy.Interfaces;
using Analogy.LogViewer.Template.WinForms;
using System;
using System.Collections.Generic;

namespace Analogy.LogViewer.ElasticCommonSchema.IAnalogy
{
    public class DataProvidersFactory : DataProvidersFactoryWinForms
    {
        public override Guid FactoryId { get; set; } = PrimaryFactory.Id;
        public override string Title { get; set; } = "ECS Data Providers";

        public override IEnumerable<IAnalogyDataProvider> DataProviders { get; set; } = new List<IAnalogyDataProvider> { new OfflineDataProvider() };
    }
}