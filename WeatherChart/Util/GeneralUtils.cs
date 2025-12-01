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
    }
}
