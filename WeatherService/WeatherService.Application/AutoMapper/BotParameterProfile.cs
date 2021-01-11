using System;
using AutoMapper;
using WeatherService.Domain.BotParameters;

namespace WeatherService.Application.AutoMapper
{
    public class BotParameterProfile : Profile
    {
        public BotParameterProfile()
        {
            CreateMap<BotParameter, string>()
                .ConvertUsing(src => Enum.GetName(typeof(BotParameter), src));
        }
    }
}