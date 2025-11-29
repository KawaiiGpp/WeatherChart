using WeatherChart.Feature.AreaSelection.Abstract;
using WeatherChart.Feature.AreaSelection.Implement;
using WeatherChart.Util;

namespace WeatherChart.Feature.AreaSelection
{
    public class AreaHandler : ContainableArea<Country>
    {
        public static AreaHandler Instance { get; } = new AreaHandler();

        private AreaHandler() : base("全局")
        {
            Initialize("中国", "ChinaAreaCode");
        }

        private void Initialize(string countryName, string sourceFileName)
        {
            var country = new Country(countryName);
            var file = new EmbeddedFile(EmbeddedFile.TEXT, $"{sourceFileName}.txt");
            var content = file.ReadAsText();

            foreach (string line in content)
            {
                var raw = line.Split('=');

                if (raw.Length != 4)
                    throw new InvalidDataException($"Invalid line in {sourceFileName}: {line}");

                var province = country.GetOrCreate(raw[1], name => new(name));
                var city = province.GetOrCreate(raw[2], name => new(name));

                city.Register(new District(raw[3], raw[0]));
            }

            Register(country);
        }
    }
}
