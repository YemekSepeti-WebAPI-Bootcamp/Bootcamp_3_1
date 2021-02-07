using Bootcamp_3_1.Ordering.Data.Repositories.Derived;
using Bootcamp_3_1.Ordering.Data.Repositories.Interface;
using Bootcamp_3_1.Ordering.Services.Interfaces;
using Bootcamp_3_1.Ordering.Services.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Bootcamp_3_1.Ordering.DI.Extensions
{
    public static class ServicesConfigurationExtensions
    {
        public static void AddProjectRepositories(this IServiceCollection services)
        {
            services.AddScoped<ICustomerRepository, CustomerRepository>();
        }

        public static void AddProjectServices(this IServiceCollection services)
        {
            services.AddTransient<ICustomerService, CustomerService>();
        }
    }
}