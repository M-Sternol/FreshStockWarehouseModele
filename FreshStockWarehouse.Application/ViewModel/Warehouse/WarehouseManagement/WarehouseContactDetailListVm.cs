using AutoMapper;
using FreshStockWarehouse.Application.Mapping;
using FreshStockWarehouse.Application.ViewModel.Customer;

namespace FreshStockWarehouse.Application.ViewModel.Warehouse.WarehouseManagement
{
    public class WarehouseContactDetailListVm : IMapFrom<FreshStockWarehouse.Domain.Model.WarehouseModel.WarehouseManagementModel.WarehouseContactDetail>
    {
        public int Id { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<FreshStockWarehouse.Domain.Model.WarehouseModel.WarehouseManagementModel.WarehouseContactDetail, WarehouseContactDetailListVm>();
        }

    }
}