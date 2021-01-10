using Telegram.Bot;

namespace WeatherService.Application.Contracts
{
    public interface ITelegramClientWrapper
    {
        TelegramBotClient TelegramBotClient { get; set; }
    }
}