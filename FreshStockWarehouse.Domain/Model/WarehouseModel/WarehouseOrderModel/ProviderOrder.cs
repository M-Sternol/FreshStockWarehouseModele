using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FreshStockWarehouse.Domain.Model.ProviderModel;
using FreshStockWarehouse.Domain.Model.WarehouseModel.WarehouseProductsModel;

namespace FreshStockWarehouse.Domain.Model.WarehouseModel.WarehouseOrderModel
{
    public class ProviderOrder
    {
        public int Id { get; set; }
        public string ProviderName { get; set; }
        public List<Product> Products { get; set; }
        public DateTime OrderDate { get; set; }
        public int TotalQuantity { get; set; }
        public decimal TotalPrice { get; set; }
        public string OrderStatus { get; set; }

        public int ProviderId { get; set; }
        public Providers Provider { get; set; }
    }
}
