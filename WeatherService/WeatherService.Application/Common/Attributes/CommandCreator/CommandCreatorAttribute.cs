using System;
using WeatherService.Domain.BotCommands;

namespace WeatherService.Application.Common.Attributes.CommandCreator
{
    [AttributeUsage(AttributeTargets.Class)]
    public class CommandCreatorAttribute : Attribute
    {
        public BotCommand Command { get; set; }
    }
}