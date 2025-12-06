using WeatherChart.Display.Greeting;

namespace WeatherChart
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            try
            {
                var master = EnvironmentMaster.Instance;
                ApplicationConfiguration.Initialize();

                if (master.IsTokenSet) Application.Run(new GreetingForm());
                else MessageBox.Show($"环境变量 {master.TokenPath} 未正确设置。");
            }
            catch (Exception exception)
            {
                MessageBox.Show($"程序崩溃，因为发生致命错误。\n{exception.Message}");
            }
        }
    }
}