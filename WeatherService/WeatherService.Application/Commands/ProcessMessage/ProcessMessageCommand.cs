using MediatR;
using Telegram.Bot.Types;

namespace WeatherService.Application.Commands.ProcessMessage
{
    public class ProcessMessageCommand : IRequest
    {
        public Message Message { get; set; }
    }
}