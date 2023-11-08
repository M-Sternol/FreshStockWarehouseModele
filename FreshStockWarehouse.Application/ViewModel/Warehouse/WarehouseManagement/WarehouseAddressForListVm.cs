using AutoMapper;
using FreshStockWarehouse.Application.Mapping;
using FreshStockWarehouse.Application.ViewModel.Customer;

namespace FreshStockWarehouse.Application.ViewModel.Warehouse.WarehouseManagement
{
    public class WarehouseAddressForListVm : IMapFrom<FreshStockWarehouse.Domain.Model.WarehouseModel.WarehouseManagementModel.WarehouseAddress>
    {
        public int Id { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Region { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<FreshStockWarehouse.Domain.Model.WarehouseModel.WarehouseManagementModel.WarehouseAddress, WarehouseAddressForListVm>();
        }
    }
}