using AutoMapper;
using FreshStockWarehouse.Application.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshStockWarehouse.Application.ViewModel.Provider
{
    public class NewProviderVm : IMapFrom<FreshStockWarehouse.Domain.Model.ProviderModel.Providers>
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email {  get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<NewProviderVm, FreshStockWarehouse.Domain.Model.ProviderModel.Providers>();
        }
    }
}
