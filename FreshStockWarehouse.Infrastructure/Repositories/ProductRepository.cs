using FreshStockWarehouse.Domain.Interfaces;
using FreshStockWarehouse.Domain.Model.WarehouseModel.WarehouseProductsModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshStockWarehouse.Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public int AddProductToWarehouse(int warehouseId, Product product)
        {
            throw new NotImplementedException();
        }

        public void DeleteProductFromWarehouse(int warehouseId, int productId)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Product> GetAllProductsInWarehouse(int warehouseId)
        {
            throw new NotImplementedException();
        }

        public Product GetProductInWarehouse(int warehouseId, int productId)
        {
            throw new NotImplementedException();
        }

        public void UpdateProductInWarehouse(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
