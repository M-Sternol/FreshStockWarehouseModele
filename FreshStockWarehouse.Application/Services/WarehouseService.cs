using FreshStockWarehouse.Application.Interfaces;
using FreshStockWarehouse.Application.ViewModel.Customer;
using FreshStockWarehouse.Application.ViewModel.Warehouse.WarehouseManagement;
using FreshStockWarehouse.Application.ViewModel.Warehouse.WarehouseProducts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshStockWarehouse.Application.Services
{
    public class WarehouseService : IWarehouseService
    {
        public void AddCustomerToWarehouse(int warehouseId, NewCustomerVm customer)
        {
            throw new NotImplementedException();
        }

        public void AddProductToWarehouse(int warehouseId, NewProductVm product)
        {
            throw new NotImplementedException();
        }

        public void CreateWarehouse(NewWarehouseVm warehouse)
        {
            throw new NotImplementedException();
        }

        public void DeleteCustomerFromWarehouse(int warehouseId, int customerId)
        {
            throw new NotImplementedException();
        }

        public void DeleteProductFromWarehouse(int warehouseId, int productId)
        {
            throw new NotImplementedException();
        }

        public void DeleteWarehouse(int warehouseId)
        {
            throw new NotImplementedException();
        }

        public List<ListCustomerForListVm> GetAllCustomersInWarehouse(int warehouseId)
        {
            throw new NotImplementedException();
        }

        public List<ListWarehouseProductsForListVm> GetAllProductsInWarehouse(int warehouseId)
        {
            throw new NotImplementedException();
        }

        public List<ListWarehouseForListVm> GetAllWarehouses()
        {
            throw new NotImplementedException();
        }

        public CustomerDetailsVm GetCustomerDetailsInWarehouse(int warehouseId, int customerId)
        {
            throw new NotImplementedException();
        }

        public ProductDetailsVm GetProductDetailsInWarehouse(int warehouseId, int productId)
        {
            throw new NotImplementedException();
        }

        public WarehouseDetailsVm GetWarehouseDetails(int warehouseId)
        {
            throw new NotImplementedException();
        }

        public void UpdateCustomerInWarehouse(int warehouseId, int customerId, CustomerDetailsVm customer)
        {
            throw new NotImplementedException();
        }

        public void UpdateProductInWarehouse(int warehouseId, int productId, ProductDetailsVm product)
        {
            throw new NotImplementedException();
        }

        public void UpdateWarehouse(int warehouseId, WarehouseDetailsVm warehouse)
        {
            throw new NotImplementedException();
        }
    }
}
