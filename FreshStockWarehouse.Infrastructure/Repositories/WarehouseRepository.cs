using FreshStockWarehouse.Domain.Interfaces;
using FreshStockWarehouse.Domain.Model.WarehouseModel.WarehouseManagementModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshStockWarehouse.Infrastructure.Repositories
{
    public class WarehouseRepository : IWarehouseRepository
    {
        public int AddWarehouse(Warehouse warehouse)
        {
            throw new NotImplementedException();
        }

        public void DeleteWarehouse(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Warehouse> GetAllWarehouses()
        {
            throw new NotImplementedException();
        }

        public Warehouse GetWarehouse(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateWarehouse(Warehouse warehouse)
        {
            throw new NotImplementedException();
        }
    }
}
