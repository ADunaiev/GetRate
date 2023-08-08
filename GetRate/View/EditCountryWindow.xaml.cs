using GetRate.Model;
using GetRate.ViewModel;
using System.Windows;


namespace GetRate.View
{
    /// <summary>
    /// Interaction logic for EditCountryWindow.xaml
    /// </summary>
    public partial class EditCountryWindow : Window
    {
        public EditCountryWindow(Country country)
        {
            InitializeComponent();
            DataContext = new DataManageVM();
            DataManageVM.SelectedCountry = country;
            DataManageVM.CountryId = country.Id;
            DataManageVM.CountryNameENG = country.NameENG;
            DataManageVM.CountryNameUKR = country.NameUKR;
        }
    }
}
