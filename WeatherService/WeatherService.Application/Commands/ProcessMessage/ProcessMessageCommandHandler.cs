using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace WeatherService.Application.Commands.ProcessMessage
{
    public class ProcessMessageCommandHandler : AsyncRequestHandler<ProcessMessageCommand>
    {
        protected override Task Handle(ProcessMessageCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}