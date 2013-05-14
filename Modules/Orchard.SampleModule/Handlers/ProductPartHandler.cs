using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orchard.ContentManagement.Handlers;
using Orchard.Data;
using Orchard.SampleModule.Models;

namespace Orchard.SampleModule.Handlers
{
    public class ProductPartHandler : ContentHandler
    {
        public ProductPartHandler(IRepository<ProductPartRecord> repository)
        {
            Filters.Add(StorageFilter.For(repository));
        }
    }
}
