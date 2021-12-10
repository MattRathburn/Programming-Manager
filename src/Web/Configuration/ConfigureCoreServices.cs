using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using Infrastructure.Data;
using Infrastructure.Logging;
using Infrastructure.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Configuration
{
    public static class ConfigureCoreServices
    {
        public static IServiceCollection AddCoreServices(this IServiceCollection services, IConfiguration configuration)
        {
            //services.AddScoped(typeof(IAsyncRepository<>), typeof(EfRepository<>));
            //services.AddScoped<IBasketService, BasketService>();
            //services.AddScoped<IOrderService, OrderService>();
            //services.AddScoped<IOrderRepository, OrderRepository>();
            //services.AddSingleton<IUriComposer>(new UriComposer(configuration.Get<CatalogSettings>()));
            services.AddScoped(typeof(IAppLogger<>), typeof(LoggerAdapter<>));
            services.AddTransient<IEmailSender, EmailSender>();
            services.Configure<MessageSenderOptions>(configuration);

            return services;
        }
    }
}
