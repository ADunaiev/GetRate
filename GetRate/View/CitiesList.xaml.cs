using GetRate.ViewModel;
using System.Windows;
using System.Windows.Controls;


namespace GetRate.View
{
    /// <summary>
    /// Interaction logic for CitiesList.xaml
    /// </summary>
    public partial class CitiesList : Window
    {
        public static ListView AllCitiesView;
        public CitiesList()
        {
            InitializeComponent();
            DataContext = new DataManageVM();
            AllCitiesView = CitiesListView;
        }
    }
}
