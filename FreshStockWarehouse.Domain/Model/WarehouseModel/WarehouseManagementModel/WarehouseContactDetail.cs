using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshStockWarehouse.Domain.Model.WarehouseModel.WarehouseManagementModel
{
    public class WarehouseContactDetail
    {
        public int Id { get; set; }
        public string ContactDetailInformation { get; set; }
        public int ContactDetailTypId { get; set; }

        public WarehouseContactDetailType ContactDetailType { get; set; }

        public int WarehouseId { get; set; }
        public Warehouse Warehouse { get; set; }

    }
}
