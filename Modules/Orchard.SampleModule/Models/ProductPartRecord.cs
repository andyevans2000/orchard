using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orchard.ContentManagement.Records;

namespace Orchard.SampleModule.Models
{
    public class ProductPartRecord:ContentPartRecord
    {
        public virtual decimal UnitPrice { get; set; }
        public virtual string Sku { get; set; }
    }
}
