using GetRate.ViewModel;
using System.Windows;
using GetRate.Model;


namespace GetRate.View
{
    /// <summary>
    /// Interaction logic for EditRequestWindow.xaml
    /// </summary>
    public partial class EditRequestWindow : Window
    {
        public EditRequestWindow(Request request)
        {
            InitializeComponent();
            DataContext = new DataManageVM();
            DataManageVM.RequestId = request.Id;
            DataManageVM.RequestDate = request.Date;
            DataManageVM.RequestFromHandlingNeeded = request.FromHandlingNeeded;
            DataManageVM.RequestToHandlingNeeded = request.ToHandlingNeeded;
            DataManageVM.RequestCargoGrossWeight = request.CargoGW;
            DataManageVM.RequestCargoVolume = request.CargoVolume;
        }
    }
}
