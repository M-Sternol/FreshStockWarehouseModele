using FreshStockWarehouse.Domain.Interfaces;
using FreshStockWarehouse.Domain.Model.ProviderModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshStockWarehouse.Infrastructure.Repositories
{
    public class ProviderRepository : IProviderRepository
    {
        public int AddProvider(Providers provider)
        {
            throw new NotImplementedException();
        }

        public void DeleteProvider(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Providers> GetAllProviders()
        {
            throw new NotImplementedException();
        }

        public Providers GetProvider(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateProvider(Providers provider)
        {
            throw new NotImplementedException();
        }
    }
}
