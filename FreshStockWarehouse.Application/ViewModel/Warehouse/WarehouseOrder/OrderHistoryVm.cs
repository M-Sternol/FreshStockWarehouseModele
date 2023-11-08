using AutoMapper;
using FreshStockWarehouse.Domain.Model.WarehouseModel.WarehouseOrderModel;
using FreshStockWarehouse.Domain.Model.WarehouseModel.WarehouseProductsModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshStockWarehouse.Application.ViewModel.Warehouse.WarehouseOrder
{
    public class OrderHistoryVm
    {
        public int OrderId { get; set; }
        public string OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public List<OrderItemVm> OrderItems { get; set; }
        public decimal TotalPrice { get; set; }
        public string Status { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<CustomerOrderHistory, OrderHistoryVm>()
                .ForMember(dest => dest.OrderId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.OrderStatus));
            profile.CreateMap<ProviderOrderHistory, OrderHistoryVm>()
                .ForMember(dest => dest.OrderId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.OrderStatus));
            profile.CreateMap<WarehouseOrderHistory, OrderHistoryVm>()
                .ForMember(dest => dest.OrderId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.OrderStatus));
            profile.CreateMap<Product, OrderItemVm>()
                .ForMember(dest => dest.ProductId, opt => opt.MapFrom(src => src.Id));
        }
    }
}
