using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace WeatherService.Application.Queries.GetBotParameters
{
    public class GetBotParametersQueryHandler : IRequestHandler<GetBotParametersQuery>
    {
        public Task<Unit> Handle(GetBotParametersQuery request, CancellationToken cancellationToken)
        {
            
        }
    }
}