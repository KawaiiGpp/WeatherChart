using WeatherChart.Util;

namespace WeatherChart.Feature.Deserialization
{
    public class WeatherExtraData
    {
        public double FeelsLike { get; }
        public int WindLevel { get; }
        public string WindAngleText { get; }
        public string WindLevelText { get; }

        public WeatherExtraData(WeatherData data)
        {
            var temp = data.Temperature;
            var rh = data.RelativeHumidity;
            var wind = data.WindSpeed;
            var angle = data.WindAngle;

            FeelsLike = GeneralUtils.CalculateFeelTemperature(temp, rh, wind);
            WindAngleText = CalculateWindAngle(angle);
            WindLevel = CalculateWindLevel(wind);
            WindLevelText = GetLevelAsString(WindLevel);
        }

        private string CalculateWindAngle(int angle)
        {
            string[] directions =
            [
                "北风", "北东北风", "东北风", "东东北风",
                "东风", "东东南风", "东南风", "南东南风",
                "南风", "南西南风", "西南风", "西西南风",
                "西风", "西西北风", "西北风", "北西北风"
            ];

            int index = ((int)Math.Round(angle / 22.5)) % 16;
            return directions[index];
        }

        private int CalculateWindLevel(double speed)
        {
            double[] stops =
            [
                0.3, 1.6, 3.4, 5.5, 8.0, 10.8, 13.9, 17.2, 20.8,
                24.5, 28.5, 32.7, 36.9, 41.4, 46.1, 50.9, 56.0, 61.3
            ];

            int index = Array.BinarySearch(stops, speed);
            return index >= 0 ? index + 1 : ~index;
        }

        private string GetLevelAsString(int level)
        {
            if (level <= 0) return "≤1级";
            else if (level < 18) return $"{level}-{level + 1}级";
            else return "≥18级";
        }
    }
}
