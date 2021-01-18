using MediatR;
using Telegram.Bot.Types;

namespace WeatherService.Application.Contracts
{
    public interface ICommandCreator
    {
        IRequest CreateCommand(Message message);
    }
}