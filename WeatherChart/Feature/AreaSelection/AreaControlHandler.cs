using WeatherChart.Feature.AreaSelection.Abstract;
using WeatherChart.Feature.AreaSelection.Implement;

namespace WeatherChart.Feature.AreaSelection
{
    public class AreaControlHandler(
        ComboBox country,
        ComboBox province,
        ComboBox city,
        ComboBox district)
    {
        private readonly ComboBox country = country;
        private readonly ComboBox province = province;
        private readonly ComboBox city = city;
        private readonly ComboBox district = district;

        public Country? SelectedCountry => GetSelectedItem<Country>(country);
        public Province? SelectedProvince => GetSelectedItem<Province>(province);
        public City? SelectedCity => GetSelectedItem<City>(city);
        public District? SelectedDistrict => GetSelectedItem<District>(district);

        public void InitCountryList()
        {
            InitList(country, AreaHandler.Instance.Children);
        }

        public void ClearAll()
        {
            country.Items.Clear();
            province.Items.Clear();
            city.Items.Clear();
            district.Items.Clear();
        }

        public void UpdateCountry()
        {
            province.Items.Clear();
            city.Items.Clear();
            district.Items.Clear();

            if (SelectedCountry == null) return;
            InitList(province, SelectedCountry.Children);
        }

        public void UpdateProvince()
        {
            city.Items.Clear();
            district.Items.Clear();

            if (SelectedProvince == null) return;
            InitList(city, SelectedProvince.Children);
        }

        public void UpdateCity()
        {
            district.Items.Clear();

            if (SelectedCity == null) return;
            InitList(district, SelectedCity.Children);
        }

        private T? GetSelectedItem<T>(ComboBox control)
            where T : Area
        {
            if (control.SelectedItem == null)
                return null;
            if (control.SelectedIndex == -1)
                return null;

            return (T)control.SelectedItem;
        }

        private void InitList<T>(ComboBox control, IEnumerable<T> children)
            where T : Area
        {
            foreach (var child in children)
            {
                control.Items.Add(child);
                control.DisplayMember = "Name";
            }
        }
    }
}
