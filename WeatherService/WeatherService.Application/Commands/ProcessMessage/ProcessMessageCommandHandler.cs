using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Telegram.Bot.Types.Enums;
using WeatherService.Application.Contracts;

namespace WeatherService.Application.Commands.ProcessMessage
{
    public class ProcessMessageCommandHandler : AsyncRequestHandler<ProcessMessageCommand>
    {
        private readonly IMediator _mediator;
        private readonly IBotCommandsService _botCommandsService;

        public ProcessMessageCommandHandler(
            IMediator mediator,
            IBotCommandsService botCommandsService)
        {
            _mediator = mediator;
            _botCommandsService = botCommandsService;
        }

        protected override async Task Handle(ProcessMessageCommand request, CancellationToken cancellationToken)
        {
            if (request.Message.Type != MessageType.Text)
            {
                //TODO: Invalid message type;
            }

            var command = _botCommandsService.GetCommand(request.Message);
            await _mediator.Send(command, cancellationToken);
        }
    }
}