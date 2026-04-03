using Analogy.Interfaces;
using System;
using System.Collections.Generic;

namespace Analogy.LogViewer.ElasticCommonSchema.IAnalogy
{
    public class EcsDataProvidersFactory : Analogy.LogViewer.Template.DataProvidersFactory
    {
        public override Guid FactoryId { get; set; } = EcsPrimaryFactory.Id;
        public override string Title { get; set; } = "ECS Data Providers";

        public override IEnumerable<IAnalogyDataProvider> DataProviders { get; set; } = new List<IAnalogyDataProvider> { new EcsOfflineDataProvider() };
    }
}