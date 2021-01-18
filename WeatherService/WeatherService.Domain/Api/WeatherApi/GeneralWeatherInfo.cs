using Newtonsoft.Json;

namespace WeatherService.Domain.Api.WeatherApi
{
    public class GeneralWeatherInfo
    {
        [JsonProperty("dt")]
        public string Time { get; set; }
        
        [JsonProperty("sunrise")]
        public string SunriseTime { get; set; }

        [JsonProperty("sunset")]
        public string SunsetTime { get; set; }
        
        [JsonProperty("pressure")]
        public float Pressure { get; set; }

        [JsonProperty("humidity")]
        public double Humidity { get; set; }
        
        [JsonProperty("dew_point")]
        public float AtmosphericTemperature { get; set; }

        [JsonProperty("clouds")]
        public double Cloudiness { get; set; }
        
        [JsonProperty("uvi")]
        public float CurrentUvIndex { get; set; }

        [JsonProperty("visibility")]
        public float Visibility { get; set; }

        [JsonProperty("wind_speed")]
        public float WindSpeed { get; set; }

        [JsonProperty("wind_gust")]
        public float? WindGust { get; set; }

        [JsonProperty("wind_deg")]
        public float WindDirection { get; set; }

        [JsonProperty("weather")]
        public MainWeatherInfo MainWeather { get; set; }
    }
}