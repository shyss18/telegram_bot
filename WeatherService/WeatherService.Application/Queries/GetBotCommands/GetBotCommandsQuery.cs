using System.Collections.Generic;
using MediatR;

namespace WeatherService.Application.Queries.GetBotCommands
{
    public class GetBotCommandsQuery : IRequest<IEnumerable<string>>
    {
    }
}