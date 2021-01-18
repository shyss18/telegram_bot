using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using WeatherService.Application.Contracts;
using WeatherService.Application.Queries.GetBotCommands;

namespace WeatherService.Application.Commands.Start
{
    public class StartCommandHandler : AsyncRequestHandler<StartCommand>
    {
        private readonly IMediator _mediator;
        private readonly ITelegramClientService _telegramClientService;

        public StartCommandHandler(
            IMediator mediator,
            ITelegramClientService telegramClientService)
        {
            _mediator = mediator;
            _telegramClientService = telegramClientService;
        }

        protected override async Task Handle(StartCommand request, CancellationToken cancellationToken)
        {
            var botParameters = await _mediator.Send(new GetBotCommandsQuery(), cancellationToken);
            var stringBuilder = new StringBuilder();

            stringBuilder.Append("List of bot commands:\n");
            foreach (var botParameter in botParameters)
            {
                stringBuilder.Append($"{botParameter}\n");
            }

            await _telegramClientService.SendMessageAsync(request.Message.Chat.Id, stringBuilder.ToString(),
                cancellationToken);
        }
    }
}