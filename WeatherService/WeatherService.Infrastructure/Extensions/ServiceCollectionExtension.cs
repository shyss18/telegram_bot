using Microsoft.Extensions.DependencyInjection;
using WeatherService.Application.Contracts;
using WeatherService.Infrastructure.Services;

namespace WeatherService.Infrastructure.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection ConfigureInfrastructureServiceCollection(this IServiceCollection services)
        {
            services.AddHttpClient();
            
            services.AddSingleton<ITelegramClientService, TelegramClientService>();
            services.AddTransient<IBotCommandsService, BotCommandsService>();
            services.AddTransient<IWeatherService, Services.WeatherService>();

            return services;
        }
    }
}