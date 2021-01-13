using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace WeatherService.Application.Commands.Start
{
    public class StartCommandHandler : AsyncRequestHandler<StartCommand>
    {
        protected override Task Handle(StartCommand request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}