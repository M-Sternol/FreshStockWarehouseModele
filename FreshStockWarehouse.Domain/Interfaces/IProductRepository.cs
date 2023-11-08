using FreshStockWarehouse.Domain.Model.WarehouseModel.WarehouseProductsModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshStockWarehouse.Domain.Interfaces
{
    public interface IProductRepository
    {
        IQueryable<Product> GetAllProductsInWarehouse(int warehouseId);
        Product GetProductInWarehouse(int warehouseId, int productId);
        int AddProductToWarehouse(int warehouseId, Product product);
        void UpdateProductInWarehouse(Product product);
        void DeleteProductFromWarehouse(int warehouseId, int productId);
    }
}
