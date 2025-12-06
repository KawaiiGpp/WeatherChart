using WeatherChart.Feature.AreaSelection;
using WeatherChart.Feature.Web;

namespace WeatherChart.Display.Greeting
{
    public partial class GreetingForm : Form
    {
        private readonly AreaControlHandler controlHandler;
        private readonly ForecastClient client;

        public GreetingForm()
        {
            InitializeComponent();

            controlHandler = new(cbCountry, cbProvince, cbCity, cbDistrict);
            client = new();
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

        private async void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                var code = controlHandler.SelectedDistrict?.AreaCode;

                if (code == null)
                {
                    MessageBox.Show("查询天气需要选择一个地区。", "错误");
                    return;
                }

                var content = await client.Get(code);

            }
            catch (Exception exception)
            {
                MessageBox.Show($"拉取数据失败，错误如下：\n{exception.Message}", "错误");
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing) 
                client.Dispose();

            base.Dispose(disposing);
        }
    }
}
