using FreshStockWarehouse.Domain.Model.WarehouseModel.WarehouseManagementModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshStockWarehouse.Domain.Interfaces
{
    public interface IWarehouseRepository
    {
        IQueryable<Warehouse> GetAllWarehouses();
        Warehouse GetWarehouse(int id);
        int AddWarehouse(Warehouse warehouse);
        void UpdateWarehouse(Warehouse warehouse);
        void DeleteWarehouse(int id);
    }
}
