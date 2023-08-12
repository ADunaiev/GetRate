using GetRate.ViewModel;
using System.Windows;
using System.Windows.Controls;

namespace GetRate.View
{
    /// <summary>
    /// Interaction logic for CityCard.xaml
    /// </summary>
    public partial class AddCityWindow : Window
    {
        public static ComboBox NewCountriesComboBox;
        public AddCityWindow()
        {
            InitializeComponent();
            DataContext = new DataManageVM();
            NewCountriesComboBox = CountriesComboBox;
        }
    }
}
