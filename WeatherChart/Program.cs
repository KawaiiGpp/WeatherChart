using WeatherChart.Display.Greeting;

namespace WeatherChart
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new GreetingForm());
        }
    }
}