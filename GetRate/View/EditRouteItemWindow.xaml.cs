using GetRate.ViewModel;
using GetRate.Model;
using System.Windows;


namespace GetRate.View
{
    /// <summary>
    /// Interaction logic for EditHandlingWindow.xaml
    /// </summary>
    public partial class EditRouteItemWindow : Window
    {
        public EditRouteItemWindow(RouteItem routeItem)
        {
            InitializeComponent();
            DataContext = new DataManageVM();
            DataManageVM.RouteItemId = routeItem.Id;
        }
    }
}
