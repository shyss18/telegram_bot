using Newtonsoft.Json;

namespace WeatherService.Domain.Api.WeatherApi.DailyWeather
{
    public class DailyWeatherInfo : GeneralWeatherInfo
    {
        [JsonProperty("temp")]
        public DailyTemperatureInfo TemperatureInfo { get; set; }

        [JsonProperty("feels_like")]
        public DailyFeelsLikeTemperatureInfo FeelsLikeTemperatureInfo { get; set; }

        [JsonProperty("rain")]
        public float Rain { get; set; }

        [JsonProperty("snow")]
        public float Snow { get; set; }
    }
}