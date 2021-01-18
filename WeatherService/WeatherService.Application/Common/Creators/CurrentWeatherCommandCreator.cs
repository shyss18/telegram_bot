using MediatR;
using Telegram.Bot.Types;
using WeatherService.Application.Commands.CurrentWeather;
using WeatherService.Application.Common.Attributes.CommandCreator;
using WeatherService.Application.Contracts;
using static WeatherService.Domain.BotCommands.BotCommand;

namespace WeatherService.Application.Common.Creators
{
    [CommandCreator(Command = Current)]
    public class CurrentWeatherCommandCreator : ICommandCreator
    {
        public IRequest CreateCommand(Message message) => new CurrentWeatherCommand {Message = message};
    }
}