using Microsoft.Extensions.DependencyInjection;
using WeatherService.Application.Contracts;
using WeatherService.Infrastructure.ClientStorage;

namespace WeatherService.Infrastructure.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection ConfigureInfrastructureServiceCollection(this IServiceCollection services)
        {
            services.AddSingleton<ITelegramClientWrapper, TelegramClientWrapper>();

            return services;
        }
    }
}