using AutoMapper;
using FreshStockWarehouse.Application.Mapping;
using FreshStockWarehouse.Application.ViewModel.Customer;
using FreshStockWarehouse.Application.ViewModel.Warehouse.WarehouseProducts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshStockWarehouse.Application.ViewModel.Warehouse.WarehouseOrder
{
    public class DeliveryCompanyVm : IMapFrom<FreshStockWarehouse.Domain.Model.WarehouseModel.WarehouseDeliveryModel.DeliveryCompany>
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string DeliveryCategory { get; set; }
        public List<ProductForListVm> Products { get; set; }
        public string DeliveryStatus { get; set; }
        public DateTime ScheduledDeliveryDate { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<FreshStockWarehouse.Domain.Model.WarehouseModel.WarehouseDeliveryModel.DeliveryCompany, DeliveryCompanyVm>();
        }
    }
}
