using GetRate.ViewModel;
using System.Windows;
using GetRate.Model;

namespace GetRate.View
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class EditTransportModeWindow : Window
    {
        public EditTransportModeWindow(TransportMode transportMode)
        {
            InitializeComponent();
            DataContext = new DataManageVM();
            DataManageVM.TransportModeId = transportMode.Id;
            DataManageVM.TransportModeNameENG = transportMode.NameENG;
            DataManageVM.TransportModeNameUKR = transportMode.NameUKR;
        }
    }
}
