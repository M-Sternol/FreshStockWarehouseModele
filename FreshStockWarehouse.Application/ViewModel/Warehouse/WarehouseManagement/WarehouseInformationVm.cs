using AutoMapper;
using FreshStockWarehouse.Application.Mapping;
using FreshStockWarehouse.Application.ViewModel.Provider;
using FreshStockWarehouse.Application.ViewModel.Warehouse.WarehouseProducts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshStockWarehouse.Application.ViewModel.Warehouse.WarehouseManagement
{
    public class WarehouseInformationVm : IMapFrom<FreshStockWarehouse.Domain.Model.WarehouseModel.WarehouseManagementModel.Warehouse>
    {
        public int Id { get; set; }
        public List<ProductForListVm> Products { get; set; }
        public List<ProviderDetailsVm> Providers { get; set; }
        public string Description { get; set; }
        public int Capacity { get; set; }
        public DateTime LastUpdated { get; set; }

        public WarehouseDetailsVm WarehouseDetailsVm { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<FreshStockWarehouse.Domain.Model.WarehouseModel.WarehouseManagementModel.Warehouse, WarehouseInformationVm>();
        }
    }
}
