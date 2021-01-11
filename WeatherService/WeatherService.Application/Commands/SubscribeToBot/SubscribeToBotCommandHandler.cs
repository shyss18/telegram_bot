using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Telegram.Bot.Args;
using WeatherService.Application.Commands.ProcessMessage;
using WeatherService.Application.Contracts;

namespace WeatherService.Application.Commands.SubscribeToBot
{
    public class SubscribeToBotCommandHandler : AsyncRequestHandler<SubscribeToBotCommand>
    {
        private readonly IMediator _mediator;
        private readonly ITelegramClientService _service;

        public SubscribeToBotCommandHandler(
            IMediator mediator,
            ITelegramClientService service)
        {
            _mediator = mediator;
            _service = service;
        }

        protected override async Task Handle(SubscribeToBotCommand request, CancellationToken cancellationToken)
        {
            _service.OnMessageReceived += OnGetMessage;
            await _service.StartReceivingAsync(cancellationToken: cancellationToken);
        }

        private void OnGetMessage(object sender, MessageEventArgs e)
        {
            Task.Run(() => _mediator.Send(new ProcessMessageCommand
            {
                Message = e.Message
            }));
        }
    }
}