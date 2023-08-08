using GetRate.Model;
using GetRate.ViewModel;
using System.Windows;


namespace GetRate.View
{
    /// <summary>
    /// Interaction logic for EditCityWindow.xaml
    /// </summary>
    public partial class EditCityWindow : Window
    {
        public EditCityWindow(City city)
        {
            InitializeComponent();
            DataContext = new DataManageVM();
            DataManageVM.SelectedCity = city;
            DataManageVM.CityId = city.Id;
            DataManageVM.CityNameENG = city.NameENG;
            DataManageVM.CityNameUKR = city.NameUKR;
            DataManageVM.CityCountry = DataWorker.GetCountryById(city.CountryId);
        }
    }
}
