using GetRate.Model;
using GetRate.ViewModel;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Documents;

namespace GetRate.View
{
    /// <summary>
    /// Interaction logic for EditRoutePointWindow.xaml
    /// </summary>
    public partial class EditRoutePointWindow : Window
    {

        public EditRoutePointWindow(RoutePoint routePoint)
        {
            InitializeComponent();
            DataContext = new DataManageVM();
            DataManageVM.RoutePointId = routePoint.Id;
            DataManageVM.RoutePointCompany.Id = routePoint.CompanyId;
            //DataManageVM.RoutePointTransportModes = routePoint.TransportModes;
            //DataManageVM.RoutePointUnitTypes = (ObservableCollection<UnitType>) routePoint.UnitTypes;
        }
    }
}
