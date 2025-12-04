namespace WeatherChart.Feature.Web
{
    public class RealtimeClient : WeatherClient
    {
        protected override string GetUrl(string code) =>
            $"https://eolink.o.apispace.com/456456/weather/v001/now?areacode={code}";
    }
}
