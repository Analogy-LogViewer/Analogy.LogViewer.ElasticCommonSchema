using Analogy.Interfaces;
using Analogy.LogViewer.ElasticCommonSchema.Properties;
using Analogy.LogViewer.ElasticCommonSchema.UserControls;
using Microsoft.Extensions.Logging;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Analogy.LogViewer.ElasticCommonSchema.IAnalogy
{
    public class UserSettingsFactory : Analogy.LogViewer.Template.TemplateUserSettingsFactory
    {
        public override string Title { get; set; } = "Elastic Common Schema User Settings";
        public override UserControl DataProviderSettings { get; set; }
        public override Image SmallImage { get; set; } = Resources.AnalogyECS16x16;
        public override Image LargeImage { get; set; } = Resources.AnalogyECS32x32;
        public override Guid FactoryId { get; set; } = PrimaryFactory.Id;
        public override Guid Id { get; set; } = new Guid("498f5f6f-08f7-41b0-98ae-cc30ca687074");

        public override void CreateUserControl(ILogger logger)
        {
            DataProviderSettings = new ECSUCSettings();
        }

        public override Task SaveSettingsAsync()
        {
            ((ECSUCSettings)DataProviderSettings)?.SaveSettings();
            return Task.CompletedTask;
        }
    }
}