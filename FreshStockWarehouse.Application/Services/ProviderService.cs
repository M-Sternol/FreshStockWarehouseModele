using FreshStockWarehouse.Application.Interfaces;
using FreshStockWarehouse.Application.ViewModel.Provider;
using FreshStockWarehouse.Domain.Model.ProviderModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshStockWarehouse.Application.Services
{
    public class ProviderService : IProviderService
    {
        public void CreateProvider(NewProviderVm provider)
        {
            throw new NotImplementedException();
        }

        public void DeleteProvider(int providerId)
        {
            throw new NotImplementedException();
        }

        public List<ListProviderForListVm> GetAllProviders(int pageSize, int pageNumber, string searchString)
        {
            throw new NotImplementedException();
        }

        public ProviderDetailsVm GetProviderDetails(int providerId)
        {
            throw new NotImplementedException();
        }

        public void UpdateProvider(int providerId, Providers provider)
        {
            throw new NotImplementedException();
        }
    }
}
