using MediatR;
using Telegram.Bot.Types;

namespace WeatherService.Application.Commands.CurrentWeather
{
    public class CurrentWeatherCommand : IRequest
    {
        public Message Message { get; set; }
    }
}