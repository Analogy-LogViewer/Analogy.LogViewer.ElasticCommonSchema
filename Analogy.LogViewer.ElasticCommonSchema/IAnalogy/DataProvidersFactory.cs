using Analogy.Interfaces;
using Analogy.Interfaces.WinForms;
using System;
using System.Collections.Generic;

namespace Analogy.LogViewer.ElasticCommonSchema.IAnalogy
{
    public class DataProvidersFactory : Analogy.LogViewer.Template.DataProvidersFactoryWinForms
    {
        public override Guid FactoryId { get; set; } = PrimaryFactory.Id;
        public override string Title { get; set; } = "ECS Data Providers";

        public override IEnumerable<IAnalogyDataProviderWinForms> DataProviders { get; set; } =
            new List<IAnalogyDataProviderWinForms> { new OfflineDataProvider() };
    }
}