using GetRate.Model;
using GetRate.ViewModel;
using System.Windows;


namespace GetRate.View
{
    /// <summary>
    /// Interaction logic for EditRPTMUTWindow.xaml
    /// </summary>
    public partial class EditRPTMUTWindow : Window
    {
        public EditRPTMUTWindow(RoutePointTransportModeUnitType rPTMUT)
        {
            InitializeComponent();
            DataContext = new DataManageVM();
            DataManageVM.RPTMUTId = rPTMUT.Id;
        }
    }
}
