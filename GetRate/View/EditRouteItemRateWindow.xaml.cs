using GetRate.ViewModel;
using GetRate.Model;
using System.Windows;


namespace GetRate.View
{
    /// <summary>
    /// Interaction logic for EditRouteItemRateWindow.xaml
    /// </summary>
    public partial class EditRouteItemRateWindow : Window
    {
        public EditRouteItemRateWindow(RouteItemRate routeItemRate)
        {
            InitializeComponent();
            DataContext = new DataManageVM();
            DataManageVM.RouteItemRateId = routeItemRate.Id;
            DataManageVM.RouteItemRateDate = routeItemRate.Date;
            DataManageVM.RouteItemRateRate = routeItemRate.Rate;
            DataManageVM.RouteItemRateValidity = routeItemRate.Validity;
        }
    }
}
