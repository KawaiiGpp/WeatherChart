using WeatherChart.Feature.AreaSelection.Abstract;

namespace WeatherChart.Feature.AreaSelection.Implement
{
    public class Province(string name) : ContainableArea<City>(name);
}
