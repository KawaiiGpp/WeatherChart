using WeatherChart.Feature.AreaSelection.Abstract;

namespace WeatherChart.Feature.AreaSelection.Implement
{
    public class Country(string name) : ContainableArea<Province>(name);
}
