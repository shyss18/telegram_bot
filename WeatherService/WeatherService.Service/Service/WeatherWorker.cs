using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.Extensions.Hosting;
using WeatherService.Application.Commands.SubscribeToBot;
using WeatherService.Application.Commands.UnsubscribeFromBot;

namespace WeatherService.Service.Service
{
    public class WeatherWorker : BackgroundService
    {
        private readonly IMediator _mediator;

        public WeatherWorker(IMediator mediator)
        {
            _mediator = mediator;
        }

        public override async Task StopAsync(CancellationToken cancellationToken)
        {
            await _mediator.Send(new UnsubscribeFromBotCommand(), cancellationToken);
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            if (!stoppingToken.IsCancellationRequested)
            {
                await _mediator.Send(new SubscribeToBotCommand(), stoppingToken);
            }
        }
    }
}