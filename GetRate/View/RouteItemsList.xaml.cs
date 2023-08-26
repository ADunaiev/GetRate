using GetRate.ViewModel;
using System.Windows;
using System.Windows.Controls;

namespace GetRate.View
{
    /// <summary>
    /// Interaction logic for HandlingsList.xaml
    /// </summary>
    public partial class RouteItemsList : Window
    {
        public static ListView AllRouteItemsView;
        public RouteItemsList()
        {
            InitializeComponent();
            DataContext = new DataManageVM();
            AllRouteItemsView = RouteItemsListView;
        }
    }
}
