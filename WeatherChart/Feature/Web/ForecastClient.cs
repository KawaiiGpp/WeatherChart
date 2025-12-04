namespace WeatherChart.Feature.Web
{
    public class ForecastClient : WeatherClient
    {
        protected override string GetUrl(string code) =>
            $"https://eolink.o.apispace.com/456456/weather/v001/hour?hours=72&areacode={code}";
    }
}
