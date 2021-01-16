using Newtonsoft.Json;

namespace WeatherService.Domain.Api.WeatherApi.Alerts
{
    public class AlertsInfo
    {
        [JsonProperty("sender_name")]
        public string SenderName { get; set; }

        [JsonProperty("event")]
        public string EventName { get; set; }

        [JsonProperty("start")]
        public string StartTime { get; set; }

        [JsonProperty("end")]
        public string EndTime { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }
}