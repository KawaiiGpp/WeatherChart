using WeatherChart.Feature.AreaSelection.Abstract;
using WeatherChart.Util;

namespace WeatherChart.Feature.AreaSelection.Implement
{
    public class City(string name) : IArea, IAreaContainer<District>
    {
        public string Name { get; } = name;
        public List<District> Children { get; } = [];

        public void Register(District district) => Children.AddUnique(district);
    }
}
