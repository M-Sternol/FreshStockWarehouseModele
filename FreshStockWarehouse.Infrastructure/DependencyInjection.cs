using FreshStockWarehouse.Domain.Interfaces;
using FreshStockWarehouse.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace FreshStockWarehouse.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddTransient<ICustomerRepository, CustomerRepository>();
            services.AddTransient<IProviderRepository, ProviderRepository>();
            services.AddTransient<IWarehouseRepository, WarehouseRepository>();
            services.AddTransient<IProductRepository, ProductRepository>();
            return services;
        }
    }
}