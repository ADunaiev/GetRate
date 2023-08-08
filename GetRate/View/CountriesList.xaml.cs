using GetRate.ViewModel;
using System.Windows;
using System.Windows.Controls;

namespace GetRate.View
{
    /// <summary>
    /// Interaction logic for CountriesList.xaml
    /// </summary>
    public partial class CountriesList : Window
    {
        public static ListView AllCountriesView;
        public CountriesList()
        {
            InitializeComponent();
            DataContext = new DataManageVM();
            AllCountriesView = CountriesListView;
        }
    }
}
