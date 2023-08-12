using GetRate.Model;
using GetRate.ViewModel;
using System.Windows;


namespace GetRate.View
{
    /// <summary>
    /// Interaction logic for EditTransportModeUnitTypeWindow.xaml
    /// </summary>
    public partial class EditTransportModeUnitTypeWindow : Window
    {
        public EditTransportModeUnitTypeWindow(TransportModeUnitType transportModeUnitType)
        {
            InitializeComponent();
            DataContext = new DataManageVM();
            DataManageVM.TransportModeUnitTypeId = transportModeUnitType.Id;
            //DataManageVM.TMUTMode.Id = transportModeUnitType.TransportModeId;
            //DataManageVM.TMUTType.Id = transportModeUnitType.UnitTypeId;
        }
    }
}
