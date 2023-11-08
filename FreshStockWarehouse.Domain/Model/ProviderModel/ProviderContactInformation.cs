using FreshStockWarehouse.Domain.Model.CustomerModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshStockWarehouse.Domain.Model.ProviderModel
{
    public class ProviderContactInformation
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }

        public int ProviderRef { get; set; }

        public Providers Providers { get; set; }
    }
}
