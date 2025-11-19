namespace WeatherChart.Display.Greeting
{
    public partial class GreetingForm : Form
    {
        public GreetingForm()
        {
            InitializeComponent();
        }

        private void timerClock_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
        }
    }
}
