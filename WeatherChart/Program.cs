using WeatherChart.Display.Greeting;

namespace WeatherChart
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            var master = EnvironmentMaster.Instance;
            ApplicationConfiguration.Initialize();

            if (master.IsTokenSet) Application.Run(new GreetingForm());
            else MessageBox.Show($"环境变量 {master.TokenPath} 未正确设置。");
        }
    }
}