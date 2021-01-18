using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WeatherService.Application.Configuration.Options;
using WeatherService.Application.Extensions;
using WeatherService.Infrastructure.Extensions;
using WeatherService.Service.Service;

namespace WeatherService.Service.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection ConfigureServiceCollection(this IServiceCollection services)
        {
            services.AddHostedService<WeatherWorker>();

            services.ConfigureApplicationServiceCollection();
            services.ConfigureInfrastructureServiceCollection();

            return services;
        }

        public static IServiceCollection BindOptions(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<TelegramSettings>(configuration.GetSection("TelegramSettings"));
            services.Configure<WeatherApiSettings>(configuration.GetSection("WeatherApiSettings"));
            return services;
        }
    }
}