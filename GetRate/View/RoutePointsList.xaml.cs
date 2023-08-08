using GetRate.ViewModel;
using System.Windows;
using System.Windows.Controls;

namespace GetRate.View
{
    /// <summary>
    /// Interaction logic for RoutePointsList.xaml
    /// </summary>
    public partial class RoutePointsList : Window
    {
        public static ListView AllRoutePointsView;
        public RoutePointsList()
        {
            InitializeComponent();
            DataContext = new DataManageVM();
            AllRoutePointsView = RoutePointsListView;
        }
    }
}
