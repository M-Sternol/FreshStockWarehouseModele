using AutoMapper;
using FreshStockWarehouse.Application.Mapping;
using FreshStockWarehouse.Application.ViewModel.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshStockWarehouse.Application.ViewModel.Warehouse.WarehouseManagement
{
    public class WarehouseDetailsVm : IMapFrom<FreshStockWarehouse.Domain.Model.WarehouseModel.WarehouseManagementModel.Warehouse>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string NIP { get; set; }
        public string REGON { get; set; }
        public string CEOFullName { get; set; }
        public string FirstLineOFContactInformation { get; set; }
        public List<WarehouseAddressForListVm> Addresses { get; set; }
        public List<WarehouseContactDetailListVm> Emails { get; set; }
        public List<WarehouseContactDetailListVm> PhoneNumbers { get; set; }
        public List<WarehouseInformationVm> WarehouseInformation { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<FreshStockWarehouse.Domain.Model.WarehouseModel.WarehouseManagementModel.Warehouse, WarehouseDetailsVm>()
                .ForMember(s => s.CEOFullName, opt => opt.MapFrom(d => d.CEOName + " " + d.CEOLastName))
                .ForMember(s => s.FirstLineOFContactInformation, opt => opt.MapFrom(d => d.WarehouseContactInformation.FirstName + " " + d.WarehouseContactInformation.LastName))
                .ForMember(s => s.Addresses, opt => opt.MapFrom(d => d.Addresses))
                .ForMember(s => s.Emails, opt => opt.MapFrom(d => d.WarehouseContactDetails.Where(c => c.ContactDetailType.Name == "Email").Select(c => new WarehouseContactDetailListVm { Email = c.ContactDetailInformation }).ToList()))
                .ForMember(s => s.PhoneNumbers, opt => opt.MapFrom(d => d.WarehouseContactDetails.Where(c => c.ContactDetailType.Name == "PhoneNumber").Select(c => new WarehouseContactDetailListVm { PhoneNumber = c.ContactDetailInformation }).ToList()));
        }

    }
}