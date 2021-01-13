using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using WeatherService.Application.Contracts;

namespace WeatherService.Application.Queries.GetBotParameters
{
    public class GetBotParametersQueryHandler : IRequestHandler<GetBotParametersQuery, IEnumerable<string>>
    {
        private readonly IMapper _mapper;
        private readonly IBotCommandsService _botCommandsService;

        public GetBotParametersQueryHandler(
            IMapper mapper,
            IBotCommandsService botCommandsService)
        {
            _mapper = mapper;
            _botCommandsService = botCommandsService;
        }

        public Task<IEnumerable<string>> Handle(
            GetBotParametersQuery request,
            CancellationToken cancellationToken)
        {
            var botParameters = _botCommandsService.GetBotCommands();
            var mappedParameters = _mapper.Map<IEnumerable<string>>(botParameters);
            return Task.FromResult(_botCommandsService.ConvertBotCommandsToTelegramCommands(mappedParameters));
        }
    }
}