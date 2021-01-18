using Newtonsoft.Json;

namespace WeatherService.Domain.Api.WeatherApi.DailyWeather
{
    public class DailyTemperatureInfo
    {
        [JsonProperty("morn")]
        public float MorningTemperature { get; set; }

        [JsonProperty("day")]
        public float DayTemperature { get; set; }

        [JsonProperty("eve")]
        public float EveningTemperature { get; set; }

        [JsonProperty("night")]
        public float NightTemperature { get; set; }

        [JsonProperty("min")]
        public float MinDailyTemperature { get; set; }

        [JsonProperty("max")]
        public float MaxDailyTemperature { get; set; }
    }
}