using AutoMapper;
using FreshStockWarehouse.Application.Mapping;
using FreshStockWarehouse.Application.ViewModel.Customer;

namespace FreshStockWarehouse.Application.ViewModel.Provider
{
    public class ProviderAddressVm : IMapFrom<FreshStockWarehouse.Domain.Model.ProviderModel.Providers>
    {
        public int Id { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Street { get; set; }
        public string BuildingNumber { get; set; }
        public string FlatNumber { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<FreshStockWarehouse.Domain.Model.ProviderModel.Providers, ProviderAddressVm>();
        }
    }
}