using System.Xml.Linq;
using WeatherChart.Feature.AreaSelection.Abstract;
using WeatherChart.Util;

namespace WeatherChart.Feature.AreaSelection.Implement
{
    public class Country(string name) : IArea, IAreaContainer<Province>
    {
        public string Name { get; } = name;
        public List<Province> Children { get; } = [];

        public void Register(Province province) => Children.AddUnique(province);
    }
}
