using System.Threading;
using System.Threading.Tasks;
using MediatR;
using WeatherService.Application.Contracts;

namespace WeatherService.Application.Commands.UnsubscribeFromBot
{
    public class UnsubscribeFromBotCommandHandler : AsyncRequestHandler<UnsubscribeFromBotCommand>
    {
        private readonly ITelegramClientService _service;

        public UnsubscribeFromBotCommandHandler(ITelegramClientService service)
        {
            _service = service;
        }

        protected override async Task Handle(UnsubscribeFromBotCommand request, CancellationToken cancellationToken)
        {
            await _service.StopReceivingAsync(cancellationToken);
        }
    }
}