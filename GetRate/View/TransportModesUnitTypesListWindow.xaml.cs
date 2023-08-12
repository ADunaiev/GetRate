using GetRate.ViewModel;
using System.Windows;
using System.Windows.Controls;

namespace GetRate.View
{
    /// <summary>
    /// Interaction logic for TransportModesUnitTypesListWindow.xaml
    /// </summary>
    public partial class TransportModesUnitTypesListWindow : Window
    {
        public static ListView AllTransportModeUnitTypesView;
        public TransportModesUnitTypesListWindow()
        {
            InitializeComponent();
            DataContext = new DataManageVM();
            AllTransportModeUnitTypesView = TransportModesUnitTypesListView;
        }
    }
}
