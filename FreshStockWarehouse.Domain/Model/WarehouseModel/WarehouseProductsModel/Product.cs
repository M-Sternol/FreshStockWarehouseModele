using FreshStockWarehouse.Domain.Model.WarehouseModel.WarehouseManagementModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshStockWarehouse.Domain.Model.WarehouseModel.WarehouseProductsModel
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public DateTime ExpiryDate { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public bool IsActive { get; set; }

        public virtual Type Type { get; set; }
        public int WarehouseId { get; set; }
        public Warehouse Warehouse { get; set; }
        public ICollection<ProductTag> ProductTags { get; set; }
    }
}
