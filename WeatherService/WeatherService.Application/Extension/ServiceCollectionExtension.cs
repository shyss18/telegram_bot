using System;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace WeatherService.Application.Extension
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection ConfigureApplicationServiceCollection(this IServiceCollection services)
        {
            services.AddMediatR(AppDomain.CurrentDomain.GetAssemblies());
            
            return services;
        }
    }
}