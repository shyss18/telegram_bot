using Newtonsoft.Json;

namespace WeatherService.Domain.Api.WeatherApi.MinutelyWeather
{
    public class MinutelyWeatherInfo
    {
        [JsonProperty("dt")]
        public string Time { get; set; }

        [JsonProperty("precipitation")]
        public float Precipitation { get; set; }
    }
}