using AutoMapper;
using FreshStockWarehouse.Application.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshStockWarehouse.Application.ViewModel.Customer
{
    public class CustomerAddressForListVm : IMapFrom<FreshStockWarehouse.Domain.Model.CustomerModel.Customers>
    {
        public int Id { get; set; }
        public string Country {  get; set; }
        public string City { get; set; }
        public string Region { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<FreshStockWarehouse.Domain.Model.CustomerModel.Customers, CustomerForListVm>();
        }

    }
}
