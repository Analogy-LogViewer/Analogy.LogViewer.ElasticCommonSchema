﻿using System;
using System.Collections.Generic;
using Analogy.Interfaces;

namespace Analogy.LogViewer.Elastic.CommonSchema.Serilog.IAnalogy
{
    public class DataProvidersFactory : Analogy.LogViewer.Template.DataProvidersFactory
    {
        public override Guid FactoryId { get; set; } = PrimaryFactory.Id;
        public override string Title { get; set; } = "Elastic Common Scheme Serilog Parser";

        public override IEnumerable<IAnalogyDataProvider> DataProviders { get; set; } =
            new List<IAnalogyDataProvider> { new OfflineDataProvider() };

    }
}
