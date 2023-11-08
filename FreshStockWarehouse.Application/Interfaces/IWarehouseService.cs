using FreshStockWarehouse.Application.ViewModel.Customer;
using FreshStockWarehouse.Application.ViewModel.Warehouse.WarehouseManagement;
using FreshStockWarehouse.Application.ViewModel.Warehouse.WarehouseProducts;
using FreshStockWarehouse.Domain.Model.CustomerModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshStockWarehouse.Application.Interfaces
{
    public interface IWarehouseService
    {
        List<ListWarehouseForListVm> GetAllWarehouses();
        WarehouseDetailsVm GetWarehouseDetails(int warehouseId);
        void CreateWarehouse(NewWarehouseVm warehouse);
        void UpdateWarehouse(int warehouseId, WarehouseDetailsVm warehouse);
        void DeleteWarehouse(int warehouseId);

        List<ListWarehouseProductsForListVm> GetAllProductsInWarehouse(int warehouseId);
        ProductDetailsVm GetProductDetailsInWarehouse(int warehouseId, int productId);
        void AddProductToWarehouse(int warehouseId, NewProductVm product);
        void UpdateProductInWarehouse(int warehouseId, int productId, ProductDetailsVm product);
        void DeleteProductFromWarehouse(int warehouseId, int productId);

        List<ListCustomerForListVm> GetAllCustomersInWarehouse(int warehouseId);
        CustomerDetailsVm GetCustomerDetailsInWarehouse(int warehouseId, int customerId);
        void AddCustomerToWarehouse(int warehouseId, NewCustomerVm customer);
        void UpdateCustomerInWarehouse(int warehouseId, int customerId, CustomerDetailsVm customer);
        void DeleteCustomerFromWarehouse(int warehouseId, int customerId);
    }


}
