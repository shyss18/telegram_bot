using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using WeatherService.Application.Configuration.Options;
using WeatherService.Application.Contracts;
using WeatherService.Domain.Api.WeatherApi;

namespace WeatherService.Infrastructure.Services
{
    public class WeatherService : IWeatherService
    {
        private readonly string _basePath;

        private readonly HttpClient _httpClient;
        private readonly IOptions<WeatherApiSettings> _weatherApiOptions;

        public WeatherService(
            HttpClient httpClient,
            IOptions<WeatherApiSettings> weatherApiOptions)
        {
            _httpClient = httpClient;
            _weatherApiOptions = weatherApiOptions;

            _basePath =
                $"{_weatherApiOptions.Value.OpenWeatherApiEndpoint}/data/2.5/onecall?units=metric&appid={_weatherApiOptions.Value.OpenWeatherApiToken}";
        }

        public async Task<WeatherApiModel> GetCurrentWeatherAsync(float lat, float lon,
            CancellationToken cancellationToken)
        {
            var path =
                $"{_basePath}&lat={33.441792}&lon={-94.037689}&exclude=minutely,hourly,daily,alerts";

            var response = await _httpClient.GetAsync(new Uri(path), cancellationToken);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            var weatherModel = JsonConvert.DeserializeObject<WeatherApiModel>(content);
            return weatherModel;
        }
    }
}