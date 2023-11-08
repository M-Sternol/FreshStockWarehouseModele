using FreshStockWarehouse.Domain.Model.WarehouseModel.WarehouseDeliveryModel;
using FreshStockWarehouse.Domain.Model.WarehouseModel.WarehouseOrderModel;
using FreshStockWarehouse.Domain.Model.WarehouseModel.WarehouseProductsModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshStockWarehouse.Domain.Model.WarehouseModel.WarehouseManagementModel
{
    public class Warehouse
    {
        public int Id { get; set; }
        public string WarehouseName { get; set; }
        public string NIP { get; set; }
        public string REGON { get; set; }
        public string CEOName { get; set; }
        public string CEOLastName { get; set; }
        public bool IsOpen { get; set; }

        public WarehouseContactInformation WarehouseContactInformation { get; set; }
        public virtual ICollection<WarehouseContactDetail> WarehouseContactDetails { get; set; }
        public virtual ICollection<WarehouseAddress> Addresses { get; set; }
        public ICollection<Product> Products { get; set; }

        public virtual ICollection<WarehouseOrderHistory> OrderHistories { get; set; }
    }
}
