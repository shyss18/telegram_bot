using MediatR;
using Telegram.Bot.Types;

namespace WeatherService.Application.Commands.Start
{
    public class StartCommand : IRequest
    {
        public Message Message { get; set; }
    }
}