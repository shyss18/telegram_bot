using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace WeatherService.Application.Commands.ProcessMessage
{
    public class ProcessMessageCommandHandler : IRequestHandler<ProcessMessageCommand>
    {
        public Task<Unit> Handle(ProcessMessageCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}