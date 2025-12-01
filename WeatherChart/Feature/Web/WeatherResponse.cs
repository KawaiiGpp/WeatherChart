using WeatherChart.Util;

namespace WeatherChart.Feature.Web
{
    public class WeatherResponse
    {
        private readonly string? content;
        private readonly Exception? caught;

        public string Content => GeneralUtils.NotNull(content, "No content from the response.");
        public Exception Caught => GeneralUtils.NotNull(caught, "No exception from the response.");

        public bool HasContent => content != null;
        public bool HasException => caught != null;

        private WeatherResponse(string? content, Exception? caught)
        {
            this.content = content;
            this.caught = caught;
        }

        public static WeatherResponse Success(string content) => new(content, null);

        public static WeatherResponse Failure(Exception exception) => new(null, exception);
    }
}
