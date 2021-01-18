using System.Collections.Generic;
using MediatR;
using Telegram.Bot.Types;
using BotCommand = WeatherService.Domain.BotCommands.BotCommand;

namespace WeatherService.Application.Contracts
{
    public interface IBotCommandsService
    {
        IEnumerable<BotCommand> GetBotCommands();

        IEnumerable<string> ConvertBotCommandsToTelegramCommands(IEnumerable<string> enumerable);

        IRequest GetCommand(Message message);
    }
}