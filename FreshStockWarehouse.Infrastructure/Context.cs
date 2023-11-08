using FreshStockWarehouse.Domain.Model.CustomerModel;
using FreshStockWarehouse.Domain.Model.ProviderModel;
using FreshStockWarehouse.Domain.Model.WarehouseModel.WarehouseDeliveryModel;
using FreshStockWarehouse.Domain.Model.WarehouseModel.WarehouseManagementModel;
using FreshStockWarehouse.Domain.Model.WarehouseModel.WarehouseOrderModel;
using FreshStockWarehouse.Domain.Model.WarehouseModel.WarehouseProductsModel;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshStockWarehouse.Infrastructure
{
    public class Context : IdentityDbContext
    {
        public DbSet<CustomerAddress> CustomerAddresses { get; set; }
        public DbSet<CustomerContactDetail> CustomerContactDetails { get; set; }
        public DbSet<CustomerContactDetailType> CustomerContactDetailTypes { get; set; }
        public DbSet<CustomerContactInformation> CustomerContactInformation { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<CompanyAddress> CompanyAddresses { get; set; }
        public DbSet<DeliveryInformation> DeliveryInformation { get; set; }
        public DbSet<ProviderContactInformation> ProviderContactInformation { get; set; }
        public DbSet<ProviderInformation> ProviderInformation { get; set; }
        public DbSet<Providers> Providers { get; set; }
        public DbSet<DeliveryCompany> DeliveryCompanies { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductTag> ProductTags { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<FreshStockWarehouse.Domain.Model.WarehouseModel.WarehouseProductsModel.Type> Types { get; set; }
        public DbSet<CustomerOrder> CustomerOrders { get; set; }
        public DbSet<ProviderOrder> ProviderOrders { get; set; }
        public DbSet<WarehouseOrderHistory> WarehouseOrderHistories { get; set; }
        public DbSet<ProviderOrderHistory> ProviderOrderHistories { get; set; }
        public DbSet<CustomerOrderHistory> CustomerOrderHistories { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }
        public DbSet<WarehouseAddress> WarehouseAddresses { get; set; }
        public DbSet<WarehouseContactDetail> WarehouseContactDetails { get; set; }
        public DbSet<WarehouseContactDetailType> WarehouseContactDetailTypes { get; set; }
        public DbSet<WarehouseContactInformation> WarehouseContactInformation { get; set; }

        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<CustomerOrder>()
                .Property(co => co.TotalPrice)
                .HasColumnType("decimal(18, 2)");

            builder.Entity<ProviderOrder>()
                .Property(po => po.TotalPrice)
                .HasColumnType("decimal(18, 2)");

            builder.Entity<Product>()
                .Property(p => p.Price)
                .HasColumnType("decimal(18, 2)");

            builder.Entity<Customers>()
                .HasMany(c => c.Addresses)
                .WithOne(a => a.Customers)
                .HasForeignKey(a => a.CustomerId);

            builder.Entity<Customers>()
                .HasMany(c => c.ContactDetail)
                .WithOne(cd => cd.Customers)
                .HasForeignKey(cd => cd.CustomerId);

            builder.Entity<Customers>()
                .HasOne(c => c.CustomerContactInformation)
                .WithOne(cci => cci.Customers)
                .HasForeignKey<CustomerContactInformation>(cci => cci.CustomerRef);

            builder.Entity<CompanyAddress>()
                .HasOne(ca => ca.Providers)
                .WithMany(p => p.CompanyAddresses)
                .HasForeignKey(ca => ca.ProviderId);

            builder.Entity<DeliveryInformation>()
                .HasOne(di => di.Providers)
                .WithMany(p => p.DeliveryInformation)
                .HasForeignKey(di => di.ProviderId);

            builder.Entity<Providers>()
                .HasOne(pci => pci.ProviderContactInformation)
                .WithOne(p => p.Providers)
                .HasForeignKey<ProviderContactInformation>(pci => pci.ProviderRef);

            builder.Entity<ProviderInformation>()
                .HasOne(pi => pi.Providers)
                .WithOne(p => p.ProviderInformation)
                .HasForeignKey<Providers>(pi => pi.Id);

            builder.Entity<Warehouse>()
                .HasMany(w => w.Addresses)
                .WithOne(a => a.Warehouse)
                .HasForeignKey(a => a.WarehouseId);

            builder.Entity<Warehouse>()
                .HasMany(w => w.WarehouseContactDetails)
                .WithOne(wcd => wcd.Warehouse)
                .HasForeignKey(wcd => wcd.WarehouseId);

            builder.Entity<WarehouseContactInformation>()
                .HasOne(wci => wci.Warehouse)
                .WithOne(w => w.WarehouseContactInformation)
                .HasForeignKey<WarehouseContactInformation>(wci => wci.WarehouseRef);

            builder.Entity<WarehouseContactDetail>()
                .HasOne(wcd => wcd.Warehouse)
                .WithMany(w => w.WarehouseContactDetails)
                .HasForeignKey(wcd => wcd.WarehouseId);

            builder.Entity<Warehouse>()
                .HasMany(w => w.WarehouseContactDetails)
                .WithOne(wcd => wcd.Warehouse)
                .HasForeignKey(wcd => wcd.WarehouseId);

            builder.Entity<WarehouseAddress>()
                .HasOne(wa => wa.Warehouse)
                .WithMany(w => w.Addresses)
                .HasForeignKey(wa => wa.WarehouseId);

            builder.Entity<ProductTag>()
                .HasKey(pt => new { pt.ProductId, pt.TagId });

            builder.Entity<ProductTag>()
                .HasOne(pt => pt.Product)
                .WithMany(p => p.ProductTags)
                .HasForeignKey(pt => pt.ProductId);

            builder.Entity<ProductTag>()
                .HasOne(pt => pt.Tag)
                .WithMany(t => t.ProductTags)
                .HasForeignKey(pt => pt.TagId);

            builder.Entity<FreshStockWarehouse.Domain.Model.WarehouseModel.WarehouseProductsModel.Type>()
                .HasMany(t => t.Products)
                .WithOne(p => p.Type)
                .HasForeignKey(p => p.Id);

            builder.Entity<WarehouseOrderHistory>()
                  .HasOne(o => o.Warehouse)
                  .WithMany(w => w.OrderHistories)
                  .HasForeignKey(o => o.WarehouseId);

            builder.Entity<ProviderOrderHistory>()
                .HasOne(o => o.Provider)
                .WithMany(p => p.OrderHistories)
                .HasForeignKey(o => o.ProviderId);


            builder.Entity<CustomerOrderHistory>()
                .HasOne(o => o.Customer)
                .WithMany(c => c.OrderHistories)
                .HasForeignKey(o => o.CustomerId);
            
        }

    }

}
