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
            Clear(country, province, city, district);
        }

        public void UpdateCountry()
        {
            Clear(province, city, district);

            if (SelectedCountry != null)
            {
                InitList(province, SelectedCountry.Children);
            }
        }

        public void UpdateProvince()
        {
            Clear(city, district);

            if (SelectedProvince != null)
            {
                InitList(city, SelectedProvince.Children);
            }
        }

        public void UpdateCity()
        {
            Clear(district);

            if (SelectedCity != null)
            {
                InitList(district, SelectedCity.Children);
            }
        }

        private T? GetSelectedItem<T>(ComboBox control)
            where T : Area
        {
            if (control.SelectedItem == null) return null;
            else return (T)control.SelectedItem;
        }

        private void InitList<T>(ComboBox control, IEnumerable<T> children)
            where T : Area
        {
            Clear(control);

            foreach (var child in children)
                control.Items.Add(child);

            control.DisplayMember = nameof(Area.Name);
        }

        private void Clear(params ComboBox[] boxes)
        {
            foreach (var box in boxes)
            {
                box.Items.Clear();
                box.SelectedIndex = -1;
            }
        }
    }
}
