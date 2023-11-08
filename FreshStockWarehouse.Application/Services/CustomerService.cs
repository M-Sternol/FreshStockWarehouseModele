using FreshStockWarehouse.Application.Interfaces;
using FreshStockWarehouse.Application.ViewModel.Customer;
using FreshStockWarehouse.Application.ViewModel.Warehouse.WarehouseOrder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshStockWarehouse.Application.Services
{
    public class CustomerService : ICustomerService
    {
        public void CreateNewCustomer(NewCustomerVm customer)
        {
            throw new NotImplementedException();
        }

        public void DeleteCustomer(int customerId)
        {
            
        }

        public ListCustomerForListVm GetAllCustomers(int pageSize, int pageNumber, string searchString)
        {
            throw new NotImplementedException();
        }

        public CustomerDetailsVm GetCustomerDetails(int customerId)
        {
            throw new NotImplementedException();
        }

        public OrderHistoryVm GetCustomerOrders(int customerId, int pageSize, int pageNumber)
        {
            throw new NotImplementedException();
        }

        public void PlaceNewOrder(int customerId, CustomerToWarehouseOrderVm order)
        {
            throw new NotImplementedException();
        }

        public void UpdateCustomer(int customerId, CustomerDetailsVm customer)
        {
            throw new NotImplementedException();
        }
    }
}
