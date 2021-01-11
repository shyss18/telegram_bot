using System.Collections.Generic;
using WeatherService.Domain.BotParameters;

namespace WeatherService.Application.Contracts
{
    public interface IBotParameterService
    {
        IEnumerable<BotParameter> GetBotParameters();

        IEnumerable<string> ConvertParametersToTelegramCommands(IEnumerable<string> enumerable);
    }
}