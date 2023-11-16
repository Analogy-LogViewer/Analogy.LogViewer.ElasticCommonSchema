using Analogy.Interfaces;
using System;
using System.Collections.Generic;

namespace Analogy.LogViewer.ElasticCommonSchema.IAnalogy
{
    public class DataProvidersFactory : Analogy.LogViewer.Template.DataProvidersFactory
    {
        public override Guid FactoryId { get; set; } = PrimaryFactory.Id;
        public override string Title { get; set; } = "ECS Data Providers";

        public override IEnumerable<IAnalogyDataProvider> DataProviders { get; set; } =
            new List<IAnalogyDataProvider> { new OfflineDataProvider() };
    }
}