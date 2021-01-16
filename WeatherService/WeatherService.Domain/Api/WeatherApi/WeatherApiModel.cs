using Newtonsoft.Json;
using WeatherService.Domain.Api.WeatherApi.Alerts;
using WeatherService.Domain.Api.WeatherApi.CurrentWeather;
using WeatherService.Domain.Api.WeatherApi.MinutelyWeather;

namespace WeatherService.Domain.Api.WeatherApi
{
    public class WeatherApiModel
    {
        [JsonProperty("lat")]
        public float Latitude { get; set; }

        [JsonProperty("lon")]
        public float Longitude { get; set; }

        [JsonProperty("timezone")]
        public string Timezone { get; set; }

        [JsonProperty("timezone_offset")]
        public string TimezoneOffset { get; set; }

        [JsonProperty("current")]
        public CurrentWeatherInfo CurrentWeather { get; set; }

        [JsonProperty("minutely")]
        public MinutelyWeatherInfo MinutelyWeather { get; set; }

        [JsonProperty("hourly")]
        public CurrentWeatherInfo HourlyWeather { get; set; }

        [JsonProperty("alerts")]
        public AlertsInfo Alerts { get; set; }
    }
}