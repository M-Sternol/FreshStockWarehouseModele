using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshStockWarehouse.Domain.Model.ProviderModel
{
    public class ProviderInformation
    {
        public int Id { get; set; }
        public string WarehouseName { get; set; }
        public string ProviderName { get; set; }
        public string ProviderType { get; set; }

        public Providers Providers { get; set; }

    }
}
