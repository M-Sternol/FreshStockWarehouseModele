using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshStockWarehouse.Domain.Model.CustomerModel
{
    public class CustomerContactDetail
    {
        public int Id { get; set; }
        public string ContactDetailInformation { get; set; }
        public int CustomerContactDetailTypeId { get; set; }

        public CustomerContactDetailType CustomerContactDetailType { get; set; }

        public int CustomerId { get; set; }
        public Customers Customers { get; set; }
    }
}
