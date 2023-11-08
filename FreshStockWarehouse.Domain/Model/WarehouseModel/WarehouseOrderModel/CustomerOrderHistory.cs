using FreshStockWarehouse.Domain.Model.CustomerModel;
using FreshStockWarehouse.Domain.Model.WarehouseModel.WarehouseProductsModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshStockWarehouse.Domain.Model.WarehouseModel.WarehouseOrderModel
{
    public class CustomerOrderHistory
    {
        public int Id { get; set; }
        public string OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public string OrderStatus { get; set; }
        public List<Product> Products { get; set; }
        public int CustomerId { get; set; }
        public Customers Customer { get; set; }
    }
}
