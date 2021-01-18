using Newtonsoft.Json;

namespace WeatherService.Domain.Api.WeatherApi.CurrentWeather
{
    public class CurrentWeatherInfo : GeneralWeatherInfo
    {
        [JsonProperty("temp")]
        public float Temperature { get; set; }

        [JsonProperty("feels_like")]
        public float TemperatureFeelsLike { get; set; }

        [JsonProperty("rain")]
        public PrecipitationInfo Rain { get; set; }

        [JsonProperty("snow")]
        public PrecipitationInfo Snow { get; set; }
    }
}