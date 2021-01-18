using Newtonsoft.Json;

namespace WeatherService.Domain.Api.WeatherApi.CurrentWeather
{
    public class PrecipitationInfo
    {
        [JsonProperty("1h")]
        public float Volume { get; set; }
    }
}