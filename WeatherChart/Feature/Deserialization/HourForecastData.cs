using Newtonsoft.Json;

namespace WeatherChart.Feature.Deserialization
{
    public class HourForecastData : WeatherData
    {
        [JsonProperty("temp_fc")]
        public required override double Temperature { get; init; }

        [JsonProperty("data_time")]
        public required string DataTime { get; init; }
    }
}
