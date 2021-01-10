using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.Extensions.Options;
using Telegram.Bot;
using Telegram.Bot.Args;
using WeatherService.Application.Contracts;
using WeatherService.Domain.Configuration;

namespace WeatherService.Application.Commands.SubscribeToBot
{
    public class SubscribeToBotCommandHandler : IRequestHandler<SubscribeToBotCommand>
    {
        private readonly ITelegramClientWrapper _wrapper;
        private readonly IOptions<TelegramSettings> _telegramSettings;

        public SubscribeToBotCommandHandler(
            ITelegramClientWrapper wrapper,
            IOptions<TelegramSettings> telegramSettings)
        {
            _wrapper = wrapper;
            _telegramSettings = telegramSettings;
        }

        public Task<Unit> Handle(SubscribeToBotCommand request, CancellationToken cancellationToken)
        {
            _wrapper.TelegramBotClient = new TelegramBotClient(_telegramSettings.Value.BotToken);
            _wrapper.TelegramBotClient.OnMessage += OnGetMessage;
            _wrapper.TelegramBotClient.OnMessageEdited += OnMessageEdited;
            _wrapper.TelegramBotClient.StartReceiving(cancellationToken: cancellationToken);

            
            
            return Task.FromResult(Unit.Value);
        }

        private void OnMessageEdited(object sender, MessageEventArgs e)
        {
        }

        private void OnGetMessage(object sender, MessageEventArgs e)
        {
            
        }
    }
}