using FreshStockWarehouse.Application.Interfaces;
using FreshStockWarehouse.Application.Services;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace FreshStockWarehouse.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddTransient<ICustomerService, CustomerService>();
            services.AddTransient<IProviderService, ProviderService>();
            services.AddTransient<IWarehouseService, WarehouseService>();
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}