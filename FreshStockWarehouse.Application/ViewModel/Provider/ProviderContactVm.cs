using AutoMapper;
using FreshStockWarehouse.Application.Mapping;
using FreshStockWarehouse.Application.ViewModel.Customer;

namespace FreshStockWarehouse.Application.ViewModel.Provider
{
    public class ProviderContactVm : IMapFrom<FreshStockWarehouse.Domain.Model.ProviderModel.Providers>
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<FreshStockWarehouse.Domain.Model.ProviderModel.Providers, ProviderContactVm>();
        }
    }
}