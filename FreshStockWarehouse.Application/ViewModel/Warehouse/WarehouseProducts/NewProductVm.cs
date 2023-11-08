using AutoMapper;
using FreshStockWarehouse.Application.Mapping;
using FreshStockWarehouse.Application.ViewModel.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshStockWarehouse.Application.ViewModel.Warehouse.WarehouseProducts
{
    public class NewProductVm : IMapFrom<FreshStockWarehouse.Domain.Model.WarehouseModel.WarehouseProductsModel.Product>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public DateTime ExpiryDate { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public bool IsActive { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<NewProductVm,FreshStockWarehouse.Domain.Model.WarehouseModel.WarehouseProductsModel.Product>();
        }
    }

}
