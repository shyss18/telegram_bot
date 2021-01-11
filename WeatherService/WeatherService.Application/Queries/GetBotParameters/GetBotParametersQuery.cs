using System.Collections.Generic;
using MediatR;

namespace WeatherService.Application.Queries.GetBotParameters
{
    public class GetBotParametersQuery : IRequest<IEnumerable<string>>
    {
    }
}