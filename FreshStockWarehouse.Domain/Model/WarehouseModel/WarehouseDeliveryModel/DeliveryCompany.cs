using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FreshStockWarehouse.Domain.Model.ProviderModel;
using FreshStockWarehouse.Domain.Model.WarehouseModel.WarehouseProductsModel;

namespace FreshStockWarehouse.Domain.Model.WarehouseModel.WarehouseDeliveryModel
{
    public class DeliveryCompany
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string DeliveryCategory { get; set; }
        public List<Product> Products { get; set; }
        public string DeliveryStatus { get; set; }
        public DateTime ScheduledDeliveryDate { get; set; }

        public int ProviderId { get; set; }
        public Providers Provider { get; set; }
    }
}
