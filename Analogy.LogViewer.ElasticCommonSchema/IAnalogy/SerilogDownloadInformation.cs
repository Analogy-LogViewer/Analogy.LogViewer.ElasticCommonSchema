﻿using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.Versioning;

namespace Analogy.LogViewer.ElasticCommonSchema.IAnalogy
{
    public class SerilogDownloadInformation : Analogy.LogViewer.Template.AnalogyDownloadInformation
    {
        protected override string RepositoryURL { get; set; } = "https://api.github.com/repos/Analogy-LogViewer/Analogy.LogViewer.ElasticCommonSchema";
        public override TargetFrameworkAttribute CurrentFrameworkAttribute { get; set; } = (TargetFrameworkAttribute)Assembly.GetExecutingAssembly().GetCustomAttribute(typeof(TargetFrameworkAttribute));

        public override Guid FactoryId { get; set; } = PrimaryFactory.Id;
        public override string Name { get; set; } = "Elastic Common Schema Data Provider";

        private string? _installedVersionNumber;
        public override string InstalledVersionNumber
        {
            get
            {
                if (_installedVersionNumber != null)
                {
                    return _installedVersionNumber;
                }
                Assembly assembly = Assembly.GetExecutingAssembly();
                FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
                _installedVersionNumber = fvi.FileVersion;
                return _installedVersionNumber;
            }
        }
    }
}