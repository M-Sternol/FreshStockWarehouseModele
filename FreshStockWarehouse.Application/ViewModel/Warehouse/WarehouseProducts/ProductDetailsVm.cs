using AutoMapper;
using FreshStockWarehouse.Application.Mapping;
using FreshStockWarehouse.Application.ViewModel.Customer;
using FreshStockWarehouse.Domain.Model.WarehouseModel.WarehouseProductsModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Type = FreshStockWarehouse.Domain.Model.WarehouseModel.WarehouseProductsModel.Type;

namespace FreshStockWarehouse.Application.ViewModel.Warehouse.WarehouseProducts
{
    public class ProductDetailsVm : IMapFrom<FreshStockWarehouse.Domain.Model.WarehouseModel.WarehouseProductsModel.Product>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public DateTime ExpiryDate { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public bool IsActive { get; set; }
        public Type Type { get; set; }
        public ICollection<ProductTag> ProductTags { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<FreshStockWarehouse.Domain.Model.WarehouseModel.WarehouseProductsModel.Product, ProductDetailsVm>();
        }
    }

}
