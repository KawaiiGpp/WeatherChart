using WeatherChart.Feature.AreaSelection.Abstract;
using WeatherChart.Util;

namespace WeatherChart.Feature.AreaSelection.Implement
{
    public class Province(string name) : IArea, IAreaContainer<City>
    {
        public string Name { get; } = name;
        public List<City> Children { get; } = [];

        public void Register(City city) => Children.AddUnique(city);
    }
}
