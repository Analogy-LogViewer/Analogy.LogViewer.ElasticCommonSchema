using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analogy.LogViewer.ElasticCommonSchema.DataTypes
{
    public class DynamicsColumnsSettings
    {
        public bool AddAllMetadataFields { get; set; }
        public List<string> AddSpecificMetadataFields { get; set; }
        public bool AddAllLabelFields { get; set; }
        public List<string> AddSpecificLabelFields { get; set; }
    }
}
