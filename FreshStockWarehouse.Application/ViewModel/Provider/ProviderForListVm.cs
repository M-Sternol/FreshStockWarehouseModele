using AutoMapper;
using FreshStockWarehouse.Application.Mapping;
using FreshStockWarehouse.Application.ViewModel.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshStockWarehouse.Application.ViewModel.Provider
{
    public class ProviderForListVm : IMapFrom<FreshStockWarehouse.Domain.Model.ProviderModel.Providers>
    {
        public int Id { get; set; }
        public string WarehouseName { get; set; }
        public string ProviderName { get; set; }
        public string ProviderType { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<FreshStockWarehouse.Domain.Model.ProviderModel.Providers, ProviderForListVm>();
        }
    }

}
