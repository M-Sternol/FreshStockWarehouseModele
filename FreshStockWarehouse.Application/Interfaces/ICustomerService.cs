using FreshStockWarehouse.Application.ViewModel.Customer;
using FreshStockWarehouse.Application.ViewModel.Warehouse.WarehouseOrder;
using FreshStockWarehouse.Domain.Model.WarehouseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshStockWarehouse.Application.Interfaces
{
    public interface ICustomerService
    {
        ListCustomerForListVm GetAllCustomers(int pageSize, int pageNumber, string searchString);
        CustomerDetailsVm GetCustomerDetails(int customerId);
        void CreateNewCustomer(NewCustomerVm customer);
        void UpdateCustomer(int customerId, CustomerDetailsVm customer);
        void DeleteCustomer(int customerId);
        OrderHistoryVm GetCustomerOrders(int customerId, int pageSize, int pageNumber);
        void PlaceNewOrder(int customerId, CustomerToWarehouseOrderVm order);
    }


}
