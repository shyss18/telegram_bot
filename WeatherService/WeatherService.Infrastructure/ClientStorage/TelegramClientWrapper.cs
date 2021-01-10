using Telegram.Bot;
using WeatherService.Application.Contracts;

namespace WeatherService.Infrastructure.ClientStorage
{
    public class TelegramClientWrapper : ITelegramClientWrapper
    {
        public TelegramBotClient TelegramBotClient { get; set; }
    }
}