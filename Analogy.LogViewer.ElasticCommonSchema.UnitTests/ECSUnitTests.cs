using Elastic.CommonSchema;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analogy.LogViewer.ElasticCommonSchema.UnitTests
{
    [TestClass]
    public class ECSUnitTests
    {
        [TestMethod]
        public void ECSTestLine()
        {
            string json = """{"@timestamp":"2022-11-08T09:36:37.249Z","log.level":"info","message":"['vo_phi_pkg\\\\runtime_recon.py']","ecs":{"version":"1.6.0"},"log":{"logger":"root","origin":{"file":{"line":90,"name":"main.py"},"function":"prepare_logging"},"original":"['vo_phi_pkg\\\\runtime_recon.py']"},"process":{"name":"MainProcess","pid":35436,"thread":{"id":13180,"name":"MainThread"}}}""";
            var entry1 = System.Text.Json.JsonSerializer.Deserialize<EcsDocument>(json);
        }
    }
}