namespace WeatherChart.Util
{
    public static class GeneralUtils
    {
        public static T NotNull<T>(T? something, string message)
            where T : struct =>
            something ?? throw new InvalidOperationException(message);

        public static T NotNull<T>(T? something, string message)
            where T : class =>
            something ?? throw new InvalidOperationException(message);

        public static double CalculateFeelTemperature(double temp, double rh, double wind)
        {
            rh = Math.Clamp(rh, 0, 100);
            wind = Math.Max(0, wind);

            var saturationVaporPressure = 6.105 * Math.Exp(17.27 * temp / (237.7 + temp));
            var vaporPressure = saturationVaporPressure * (rh / 100.0);
            var effectiveWind = Math.Min(wind, 12);

            return temp + 0.348 * vaporPressure - 0.70 * effectiveWind - 4.25;
        }
    }
}
