using GetRate.ViewModel;
using GetRate.Model;
using System.Windows;


namespace GetRate.View
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class EditTransportationTypeWindow : Window
    {
        public EditTransportationTypeWindow(
            //TransportationType transportationType
            )
        {
            InitializeComponent();
            DataContext = new DataManageVM();
            //DataManageVM.TT_Id = transportationType.Id;
        }
    }
}
