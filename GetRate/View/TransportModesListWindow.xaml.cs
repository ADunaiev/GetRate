using GetRate.ViewModel;
using System.Windows;
using System.Windows.Controls;

namespace GetRate.View
{
    /// <summary>
    /// Interaction logic for TransportModesListWindow.xaml
    /// </summary>
    public partial class TransportModesListWindow : Window
    {
        public static ListView AllTransportModesList;
        public TransportModesListWindow()
        {
            InitializeComponent();
            DataContext = new DataManageVM();
            AllTransportModesList = TransportModesListView;
        }
    }
}
