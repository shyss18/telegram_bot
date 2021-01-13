using Microsoft.Extensions.DependencyInjection;
using WeatherService.Application.Contracts;
using WeatherService.Infrastructure.Services;

namespace WeatherService.Infrastructure.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection ConfigureInfrastructureServiceCollection(this IServiceCollection services)
        {
            services.AddSingleton<ITelegramClientService, TelegramClientService>();
            services.AddTransient<IBotCommandsService, BotCommandsService>();
            return services;
        }
    }
}