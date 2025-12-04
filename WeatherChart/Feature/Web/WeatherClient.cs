namespace WeatherChart.Feature.Web
{
    public abstract class WeatherClient : IDisposable
    {
        private readonly HttpClient client;
        private bool disposed = false;

        public WeatherClient()
        {
            var token = EnvironmentMaster.Instance.Token;

            client = new HttpClient();
            client.DefaultRequestHeaders.Add("X-APISpace-Token", token);
        }

        public async Task<WeatherResponse> Get(string code)
        {
            ObjectDisposedException.ThrowIf(disposed, this);

            try
            {
                var response = await client.GetAsync(GetUrl(code));
                response.EnsureSuccessStatusCode();

                var content = await response.Content.ReadAsStringAsync();
                return WeatherResponse.Success(content);
            }
            catch (Exception exception)
            {
                return WeatherResponse.Failure(exception);
            }
        }

        public void Dispose()
        {
            if (disposed) return;
            
            client.Dispose();
            disposed = true;
            GC.SuppressFinalize(this);
        }

        protected abstract string GetUrl(string code);
    }
}
