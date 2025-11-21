using WeatherChart.Feature.AreaSelection.Implement;

namespace WeatherChart.Feature.AreaSelection
{
    public class AreaHandler
    {
        public static AreaHandler Instance { get; } = new AreaHandler();

        public List<Country> CountryList { get; } = [];

        private AreaHandler() { 
            // Initialize country list.
        }
    }
}
