namespace WeatherChart.Feature.Web
{
    public class WeatherClient : IDisposable
    {
        private readonly string url;
        private readonly HttpClient client;
        private bool disposed = false;

        public WeatherClient(string url, string token)
        {
            this.url = url;

            client = new HttpClient();
            client.DefaultRequestHeaders.Add("X-APISpace-Token", token);
        }

        //public async Task<WeatherResponse> Get(string code)
        //{
        //    ObjectDisposedException.ThrowIf(disposed, this);

        //}

        public void Dispose()
        {
            if (disposed) return;
            
            client.Dispose();
            disposed = true;
            GC.SuppressFinalize(this);
        }
    }
}
