using FreshStockWarehouse.Domain.Interfaces;
using FreshStockWarehouse.Domain.Model.CustomerModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshStockWarehouse.Infrastructure.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        public int AddCustomer(Customers customer)
        {
            throw new NotImplementedException();
        }

        public void DeleteCustomer(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Customers> GetAllActiveCustomers()
        {
            throw new NotImplementedException();
        }

        public Customers GetCustomer(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateCustomer(Customers customer)
        {
            throw new NotImplementedException();
        }
    }
}
