using Newtonsoft.Json;

namespace WeatherChart.Feature.Deserialization
{
    public abstract class WeatherData
    {
        private WeatherExtraData? extraData;
        public WeatherExtraData ExtraData => extraData ??= new WeatherExtraData(this);

        public required abstract double Temperature { get; init; }

        [JsonProperty("text")]
        public required string Text { get; init; }

        [JsonProperty("code")]
        public required string Code { get; init; }

        [JsonProperty("wind_class")]
        public required string WindLevel { get; init; }

        [JsonProperty("wind_speed")]
        public required double WindSpeed { get; init; }

        [JsonProperty("wind_dir")]
        public required string WindDirection { get; init; }

        [JsonProperty("wind_angle")]
        public required int WindAngle { get; init; }

        [JsonProperty("rh")]
        public required int RelativeHumidity { get; init; }

        [JsonProperty("prec")]
        public required double Precipitation { get; init; }

        [JsonProperty("pressure")]
        public required int Pressure { get; init; }

        [JsonProperty("clouds")]
        public required int Clouds { get; init; }

        [JsonProperty("feels_like")]
        public required int FeelsLike { get; init; }
    }
}
