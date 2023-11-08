using AutoMapper;
using FreshStockWarehouse.Application.Mapping;
using FreshStockWarehouse.Application.ViewModel.Customer;
using FreshStockWarehouse.Application.ViewModel.Warehouse.WarehouseManagement;
using FreshStockWarehouse.Application.ViewModel.Warehouse.WarehouseProducts;
using FreshStockWarehouse.Domain.Model.CustomerModel;
using FreshStockWarehouse.Domain.Model.WarehouseModel.WarehouseManagementModel;
using FreshStockWarehouse.Domain.Model.WarehouseModel.WarehouseProductsModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshStockWarehouse.Application.ViewModel.Warehouse.WarehouseOrder
{
    public class CustomerToWarehouseOrderVm
    {
        public int Id { get; set; }
        public CustomerDetailsVm Customer { get; set; }
        public WarehouseDetailsVm Warehouse { get; set; }
        public DateTime OrderDate { get; set; }
        public List<ProductDetailsVm> Products { get; set; }
        public int TotalQuantity { get; set; }
        public decimal TotalPrice { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Product, ProductDetailsVm>().ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id));
            profile.CreateMap<FreshStockWarehouse.Domain.Model.WarehouseModel.WarehouseManagementModel.Warehouse, WarehouseDetailsVm>()
                .ForMember(dest => dest.CEOFullName, opt => opt.MapFrom(src => src.CEOName + " " + src.CEOLastName))
                .ForMember(dest => dest.FirstLineOFContactInformation, opt => opt.MapFrom(src => src.WarehouseContactInformation.FirstName + " " + src.WarehouseContactInformation.LastName))
                .ForMember(dest => dest.Addresses, opt => opt.MapFrom(src => src.Addresses))
                .ForMember(dest => dest.Emails, opt => opt.MapFrom(src => src.WarehouseContactDetails.Where(c => c.ContactDetailType.Name == "Email").Select(c => new WarehouseContactDetailListVm { Email = c.ContactDetailInformation }).ToList()))
                .ForMember(dest => dest.PhoneNumbers, opt => opt.MapFrom(src => src.WarehouseContactDetails.Where(c => c.ContactDetailType.Name == "PhoneNumber").Select(c => new WarehouseContactDetailListVm { PhoneNumber = c.ContactDetailInformation }).ToList()));
        }
    }
}
