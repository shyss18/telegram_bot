using MediatR;
using Telegram.Bot.Types;
using WeatherService.Application.Commands.Start;
using WeatherService.Application.Common.Attributes.CommandCreator;
using WeatherService.Application.Contracts;
using static WeatherService.Domain.BotCommands.BotCommand;

namespace WeatherService.Application.Common.Creators
{
    [CommandCreator(Command = Start)]
    public class StartCommandCreator : ICommandCreator
    {
        public IRequest CreateCommand(Message message) => new StartCommand {Message = message};
    }
}