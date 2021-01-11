using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using Telegram.Bot;
using Telegram.Bot.Args;
using WeatherService.Application.Configuration.Options;
using WeatherService.Application.Contracts;

namespace WeatherService.Infrastructure.Services
{
    public class TelegramClientService : ITelegramClientService
    {
        private readonly TelegramBotClient _telegramBotClient;

        public EventHandler<MessageEventArgs> OnMessageReceived { get; set; }

        public TelegramClientService(IOptions<TelegramSettings> telegramSettings)
        {
            _telegramBotClient = new TelegramBotClient(telegramSettings.Value.BotToken);
            Subscribe();
        }

        public Task SendMessageAsync(string message, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task StartReceivingAsync(CancellationToken cancellationToken)
        {
            _telegramBotClient.StartReceiving(cancellationToken: cancellationToken);
            return Task.CompletedTask;
        }

        public Task StopReceivingAsync(CancellationToken cancellationToken)
        {
            _telegramBotClient.StopReceiving();
            return Task.CompletedTask;
        }

        private void Subscribe()
        {
            _telegramBotClient.OnMessage += (sender, args) => OnMessageReceived?.Invoke(sender, args);
        }
    }
}