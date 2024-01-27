using Microsoft.Extensions.DependencyInjection;
using Nurbnb.Hospedaje.Domain.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Nurbnb.Hospedaje.Application
{
    public static class Extensions
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
           services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

            services.AddSingleton<ICheckinFactory, CheckinFactory>();
            services.AddSingleton<ICheckoutFactory, CheckoutFactory>();

            return services;
        }
    }
}
