using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Telegram.Bot.Types.ReplyMarkups;
using WeatherService.Application.Contracts;

namespace WeatherService.Application.Commands.CurrentWeather
{
    public class CurrentWeatherCommandHandler : AsyncRequestHandler<CurrentWeatherCommand>
    {
        private readonly IWeatherService _weatherService;

        public CurrentWeatherCommandHandler(IWeatherService weatherService)
        {
            _weatherService = weatherService;
        }

        protected override async Task Handle(CurrentWeatherCommand request, CancellationToken cancellationToken)
        {
            // var button = new KeyboardButton("sdsd");
            
            var currentWeather = await _weatherService.GetCurrentWeatherAsync(0, 0, cancellationToken);
        }
    }
}