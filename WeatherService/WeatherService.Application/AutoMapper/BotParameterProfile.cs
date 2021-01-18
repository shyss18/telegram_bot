using System;
using AutoMapper;
using WeatherService.Domain.BotCommands;

namespace WeatherService.Application.AutoMapper
{
    public class BotParameterProfile : Profile
    {
        public BotParameterProfile()
        {
            CreateMap<BotCommand, string>()
                .ConvertUsing(src => Enum.GetName(typeof(BotCommand), src));
        }
    }
}