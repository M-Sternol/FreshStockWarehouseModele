using FreshStockWarehouse.Application.ViewModel.Provider;
using FreshStockWarehouse.Domain.Model.ProviderModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshStockWarehouse.Application.Interfaces
{
    public interface IProviderService
    {
        List<ListProviderForListVm> GetAllProviders(int pageSize, int pageNumber, string searchString);
        ProviderDetailsVm GetProviderDetails(int providerId);
        void CreateProvider(NewProviderVm provider);
        void UpdateProvider(int providerId, Providers provider);
        void DeleteProvider(int providerId);
    }
}
