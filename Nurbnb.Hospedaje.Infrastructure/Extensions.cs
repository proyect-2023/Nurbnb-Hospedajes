using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nurbnb.Hospedaje.Application;
using Nurbnb.Hospedaje.Infrastructure.EF.Contexts;
using Restaurant.SharedKernel.Core;
using Microsoft.EntityFrameworkCore;
using Nurbnb.Hospedaje.Domain.Repositories;
using System.Reflection;
using Nurbnb.Hospedaje.Infrastructure.EF.Repositories;
using Nurbnb.Hospedaje.Infrastructure.EF;

namespace Nurbnb.Hospedaje.Infrastructure
{
    public static class Extensions
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services,
           IConfiguration configuration, bool isDevelopment)
        {
            services.AddApplication();
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

            AddDatabase(services, configuration, isDevelopment);

            //AddAuthentication(services, configuration);

            //AddMassTransitWithRabbitMq(services, configuration);

            return services;
        }
        private static void AddDatabase(IServiceCollection services, IConfiguration configuration, bool isDevelopment)
        {
            var connectionString =
                    configuration.GetConnectionString("NurbnbDbConnectionString");
            services.AddDbContext<ReadDbContext>(context =>
                    context.UseSqlServer(connectionString));
            services.AddDbContext<WriteDbContext>(context =>
                context.UseSqlServer(connectionString));

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<ICheckinRepository, CheckinRepository>();
            services.AddScoped<ICheckoutRepository, CheckoutRepository>();



            using var scope = services.BuildServiceProvider().CreateScope();
            if (!isDevelopment)
            {
                var context = scope.ServiceProvider.GetRequiredService<ReadDbContext>();
                context.Database.Migrate();
            }
        }
    }
}
