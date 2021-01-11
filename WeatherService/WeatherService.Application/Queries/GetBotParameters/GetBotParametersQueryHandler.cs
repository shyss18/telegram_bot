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
        private readonly IBotParameterService _botParameterService;

        public GetBotParametersQueryHandler(
            IMapper mapper,
            IBotParameterService botParameterService)
        {
            _mapper = mapper;
            _botParameterService = botParameterService;
        }

        public Task<IEnumerable<string>> Handle(
            GetBotParametersQuery request,
            CancellationToken cancellationToken)
        {
            var botParameters = _botParameterService.GetBotParameters();
            var mappedParameters = _mapper.Map<IEnumerable<string>>(botParameters);
            return Task.FromResult(_botParameterService.ConvertParametersToTelegramCommands(mappedParameters));
        }
    }
}