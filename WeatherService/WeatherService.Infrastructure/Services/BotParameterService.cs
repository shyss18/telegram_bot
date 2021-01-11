using System;
using System.Collections.Generic;
using System.Linq;
using WeatherService.Application.Contracts;
using WeatherService.Domain.BotParameters;

namespace WeatherService.Infrastructure.Services
{
    public class BotParameterService : IBotParameterService
    {
        public IEnumerable<BotParameter> GetBotParameters()
        {
            foreach (var botParameterValue in Enum.GetValues(typeof(BotParameter)))
            {
                if (botParameterValue is BotParameter value)
                    yield return value;
            }
        }

        public IEnumerable<string> ConvertParametersToTelegramCommands(IEnumerable<string> enumerable)
            => enumerable.Select(parameter => $"/{parameter.ToLower()}").ToList();
    }
}