using FreshStockWarehouse.Domain.Model.WarehouseModel.WarehouseProductsModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshStockWarehouse.Domain.Model.WarehouseModel.WarehouseOrderModel
{
    public class CustomerOrder
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public List<Product> Products { get; set; }
        public DateTime OrderDate { get; set; }
        public int TotalQuantity { get; set; }
        public decimal TotalPrice { get; set; }
        public string OrderStatus { get; set; }

        public int CustomerId { get; set; }
        public CustomerModel.Customers Customer { get; set; }
    }
}
