using System.Threading;
using System.Threading.Tasks;
using WeatherService.Domain.Api.WeatherApi;

namespace WeatherService.Application.Contracts
{
    public interface IWeatherService
    {
        Task<WeatherApiModel> GetCurrentWeatherAsync(float lat, float lon, CancellationToken cancellationToken);
    }
}