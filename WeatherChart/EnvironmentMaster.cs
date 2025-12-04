using WeatherChart.Util;

namespace WeatherChart
{
    public class EnvironmentMaster
    {
        private static readonly EnvironmentMaster instance = new();
        public static EnvironmentMaster Instance => instance;

        public string TokenPath { get; } = "WEATHER_TOKEN";
        public string? RawToken => Environment.GetEnvironmentVariable(TokenPath);
        public string Token => GeneralUtils.NotNull(RawToken, "Token for API not set.");
        public bool IsTokenSet => RawToken != null;

        private EnvironmentMaster() { }
    }
}
