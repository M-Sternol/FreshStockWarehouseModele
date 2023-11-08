using FreshStockWarehouse.Domain.Model.ProviderModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshStockWarehouse.Domain.Interfaces
{
    public interface IProviderRepository
    {
        IQueryable<Providers> GetAllProviders();
        Providers GetProvider(int id);
        int AddProvider(Providers provider);
        void UpdateProvider(Providers provider);
        void DeleteProvider(int id);
    }
}
