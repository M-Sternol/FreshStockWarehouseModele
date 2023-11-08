using FreshStockWarehouse.Domain.Model.CustomerModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshStockWarehouse.Domain.Interfaces
{
    public interface ICustomerRepository
    {
        IQueryable<Customers> GetAllActiveCustomers();
        Customers GetCustomer(int id);
        int AddCustomer(Customers customer);
        void UpdateCustomer(Customers customer);
        void DeleteCustomer(int id);
    }
}
