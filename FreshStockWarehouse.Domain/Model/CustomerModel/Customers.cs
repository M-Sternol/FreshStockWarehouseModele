using FreshStockWarehouse.Domain.Model.WarehouseModel.WarehouseOrderModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshStockWarehouse.Domain.Model.CustomerModel
{
    public class Customers
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string NIP { get; set; }
        public string REGON { get; set; }
        public string CEOName { get; set; }
        public string CEOLastName { get; set; }
        public bool IsActive { get; set; }

        public CustomerContactInformation CustomerContactInformation { get; set; }

        public virtual ICollection<CustomerContactDetail> ContactDetail { get; set; }

        public virtual ICollection<CustomerAddress> Addresses { get; set; }

        public virtual ICollection<CustomerOrderHistory> OrderHistories { get; set; }

    }
}
