using System.Threading;
using System.Threading.Tasks;
using MediatR;
using WeatherService.Application.Contracts;

namespace WeatherService.Application.Commands.UnsubscribeFromBot
{
    public class UnsubscribeFromBotCommandHandler : IRequestHandler<UnsubscribeFromBotCommand>
    {
        private readonly ITelegramClientWrapper _wrapper;

        public UnsubscribeFromBotCommandHandler(ITelegramClientWrapper wrapper)
        {
            _wrapper = wrapper;
        }

        public Task<Unit> Handle(UnsubscribeFromBotCommand request, CancellationToken cancellationToken)
        {
            _wrapper.TelegramBotClient.StopReceiving();
            _wrapper.TelegramBotClient = null;
            return Task.FromResult(Unit.Value);
        }
    }
}