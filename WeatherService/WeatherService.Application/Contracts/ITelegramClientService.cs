using System;
using System.Threading;
using System.Threading.Tasks;
using Telegram.Bot.Args;

namespace WeatherService.Application.Contracts
{
    public interface ITelegramClientService
    {
        EventHandler<MessageEventArgs> OnMessageReceived { get; set; }
        
        Task SendMessageAsync(string message, CancellationToken cancellationToken);

        Task StartReceivingAsync(CancellationToken cancellationToken);

        Task StopReceivingAsync(CancellationToken cancellationToken);
    }
}