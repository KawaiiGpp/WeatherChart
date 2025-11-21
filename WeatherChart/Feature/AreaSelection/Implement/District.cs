using WeatherChart.Feature.AreaSelection.Abstract;

namespace WeatherChart.Feature.AreaSelection.Implement
{
    public class District(string name, string code) : IArea
    {
        public string Name { get; } = name;
        public string AreaCode { get; } = code;
    }
}
