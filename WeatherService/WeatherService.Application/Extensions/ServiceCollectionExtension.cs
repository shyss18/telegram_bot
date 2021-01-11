using System;
using AutoMapper;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace WeatherService.Application.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection ConfigureApplicationServiceCollection(this IServiceCollection services)
        {
            services.AddMediatR(AppDomain.CurrentDomain.GetAssemblies());
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            return services;
        }
    }
}