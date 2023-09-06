using GetRate.ViewModel;
using System.Windows;
using System.Windows.Controls;

namespace GetRate.View
{
    /// <summary>
    /// Interaction logic for RouteItemRatesList.xaml
    /// </summary>
    public partial class RouteItemRatesList : Window
    {
        public static ListView AllRouteItemRates;
        public RouteItemRatesList()
        {
            InitializeComponent();
            DataContext = new DataManageVM();
            AllRouteItemRates = RouteItemsListView;
        }
    }
}
