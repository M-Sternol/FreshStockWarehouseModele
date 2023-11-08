using AutoMapper;
using FreshStockWarehouse.Application.Mapping;
using FreshStockWarehouse.Domain.Model.CustomerModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshStockWarehouse.Application.ViewModel.Customer
{
    public class NewCustomerVm : IMapFrom<FreshStockWarehouse.Domain.Model.CustomerModel.Customers>
    {
       public int Id { get; set; }
       public List<CustomerDetailsVm>CustomerDetailsVm { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<NewCustomerVm,FreshStockWarehouse.Domain.Model.CustomerModel.Customers>();
        }

    }

}
