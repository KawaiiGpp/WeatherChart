namespace WeatherChart.Util
{
    public static class GeneralExtension
    {
        public static T NotNull<T>(this T? self, string? argumentName = null)
            where T : class =>
            self ?? throw new ArgumentNullException(argumentName);

        public static T NotNull<T>(this T? self, string? argumentName = null)
            where T : struct =>
            self ?? throw new ArgumentNullException(argumentName);

        public static void AddUnique<T>(this List<T> self, T element)
        {
            if (self.Contains(element))
                throw new ArgumentException("Element already existing.");
            else self.Add(element);
        }
    }
}
