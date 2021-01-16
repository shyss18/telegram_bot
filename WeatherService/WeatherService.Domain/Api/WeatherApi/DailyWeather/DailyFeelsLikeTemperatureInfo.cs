using Newtonsoft.Json;

namespace WeatherService.Domain.Api.WeatherApi.DailyWeather
{
    public class DailyFeelsLikeTemperatureInfo
    {
        [JsonProperty("morn")]
        public float MorningTemperature { get; set; }

        [JsonProperty("day")]
        public float DayTemperature { get; set; }

        [JsonProperty("eve")]
        public float EveningTemperature { get; set; }

        [JsonProperty("night")]
        public float NightTemperature { get; set; }
    }
}