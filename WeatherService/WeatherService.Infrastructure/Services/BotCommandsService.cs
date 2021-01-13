using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using MediatR;
using Telegram.Bot.Types;
using WeatherService.Application.Common.Attributes.CommandCreator;
using WeatherService.Application.Contracts;
using BotCommand = WeatherService.Domain.BotCommands.BotCommand;

namespace WeatherService.Infrastructure.Services
{
    public class BotCommandsService : IBotCommandsService
    {
        public IEnumerable<BotCommand> GetBotCommands()
        {
            foreach (var botParameterValue in Enum.GetValues(typeof(BotCommand)))
            {
                if (botParameterValue is BotCommand value)
                    yield return value;
            }
        }

        public IEnumerable<string> ConvertBotCommandsToTelegramCommands(IEnumerable<string> enumerable)
            => enumerable.Select(parameter => $"/{parameter.ToLower()}").ToList();

        public IRequest GetCommand(Message message)
        {
            var trimParameter = new StringBuilder(message.Text.Trim('/'));
            trimParameter[0] = char.ToUpper(trimParameter[0]);

            if (Enum.TryParse<BotCommand>(trimParameter.ToString(), out var botCommand))
            {
                ICommandCreator commandCreator = GetCommandCreator(botCommand);
                return commandCreator.CreateCommand(message);
            }
            else
            {
                //TODO: throw exception;
            }

            return null;
        }

        private ICommandCreator GetCommandCreator(BotCommand botCommand)
        {
            var commandCreators = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(assembly => assembly.GetTypes())
                .Where(type => typeof(ICommandCreator).IsAssignableFrom(type));

            foreach (var commandCreator in commandCreators)
            {
                var attributes = TypeDescriptor.GetAttributes(commandCreator);
                foreach (var attribute in attributes)
                {
                    if (attribute is CommandCreatorAttribute atr && Equals(atr.Command, botCommand))
                    {
                        return (ICommandCreator) Activator.CreateInstance(commandCreator);
                    }
                }
            }

            throw new InvalidCastException();
        }
    }
}