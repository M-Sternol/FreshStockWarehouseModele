using AutoMapper;
using FreshStockWarehouse.Application.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshStockWarehouse.Application.ViewModel.Customer
{
    public class CustomerDetailsVm : IMapFrom<FreshStockWarehouse.Domain.Model.CustomerModel.Customers>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string NIP { get; set; }
        public string REGON { get; set; }
        public string CEOFullName { get; set; }
        public string FirstLineOfContactInformation { get; set; }
        public List<CustomerAddressForListVm> Addresses { get; set; }
        public List<CustomerContactDetailListVm> Emails { get; set; }
        public List<CustomerContactDetailListVm> PhoneNumbers { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<FreshStockWarehouse.Domain.Model.CustomerModel.Customers, CustomerDetailsVm>()
                .ForMember(s => s.CEOFullName, opt => opt.MapFrom(d => d.CEOName + " " + d.CEOLastName))
                .ForMember(s => s.FirstLineOfContactInformation, opt => opt.MapFrom(d => d.CustomerContactInformation.FirstName + " " + d.CustomerContactInformation.LastName))
                .ForMember(s => s.Emails, opt => opt.MapFrom(d => d.ContactDetail
                    .Where(c => c.CustomerContactDetailType.Name == "Email")
                    .Select(c => new CustomerContactDetailListVm { Email = c.ContactDetailInformation })))
                .ForMember(s => s.PhoneNumbers, opt => opt.MapFrom(d => d.ContactDetail
                    .Where(c => c.CustomerContactDetailType.Name == "PhoneNumber")
                    .Select(c => new CustomerContactDetailListVm { PhoneNumber = c.ContactDetailInformation })))
                .ForMember(s => s.Addresses, opt => opt.MapFrom(d => d.Addresses.Select(a => new CustomerAddressForListVm
                {
                    Country = a.Country,
                    City = a.City,
                    Region = a.Region
                })));
        }
    }
}
