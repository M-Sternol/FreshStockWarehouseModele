using AutoMapper;
using FreshStockWarehouse.Application.Mapping;
using FreshStockWarehouse.Application.ViewModel.Customer;

namespace FreshStockWarehouse.Application.ViewModel.Provider
{
    public class ProviderInformationVm : IMapFrom<FreshStockWarehouse.Domain.Model.ProviderModel.Providers>
    {
        public int Id { get; set; }
        public string WarehouseName { get; set; }
        public string ProviderName { get; set; }
        public string ProviderType { get; set; }
        public string ContactEmail { get; set; }
        public string ContactPhone { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<FreshStockWarehouse.Domain.Model.ProviderModel.Providers, ProviderInformationVm>();
        }
    }
}