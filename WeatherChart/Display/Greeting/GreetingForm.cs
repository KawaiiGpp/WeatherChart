using WeatherChart.Feature.AreaSelection;

namespace WeatherChart.Display.Greeting
{
    public partial class GreetingForm : Form
    {
        private readonly AreaControlHandler controlHandler;

        public GreetingForm()
        {
            InitializeComponent();
            controlHandler = new(cbCountry, cbProvince, cbCity, cbDistrict);
        }

        private void timerClock_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
        }

        private void GreetingForm_Load(object sender, EventArgs e)
        {
            controlHandler.InitCountryList();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            controlHandler.ClearAll();
            controlHandler.InitCountryList();
        }

        private void cbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            controlHandler.UpdateCountry();
        }

        private void cbProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            controlHandler.UpdateProvince();
        }

        private void cbCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            controlHandler.UpdateCity();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            MessageBox.Show(controlHandler.SelectedDistrict?.AreaCode ?? "Œﬁ∑®œ‘ æ");
        }
    }
}
