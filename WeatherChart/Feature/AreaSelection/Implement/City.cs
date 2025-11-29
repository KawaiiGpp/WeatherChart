using WeatherChart.Feature.AreaSelection.Abstract;

namespace WeatherChart.Feature.AreaSelection.Implement
{
    public class City(string name) : ContainableArea<District>(name);
}
