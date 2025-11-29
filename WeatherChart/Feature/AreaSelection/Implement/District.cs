using WeatherChart.Feature.AreaSelection.Abstract;

namespace WeatherChart.Feature.AreaSelection.Implement
{
    public class District(string name, string areaCode) : Area(name)
    {
        public string AreaCode { get; } = areaCode;
    }
}
