using GetRate.ViewModel;
using System.Windows;


namespace GetRate.View
{
    /// <summary>
    /// Interaction logic for AddTransportModeUnitTypeWindow.xaml
    /// </summary>
    public partial class AddTransportModeUnitTypeWindow : Window
    {
        public AddTransportModeUnitTypeWindow()
        {
            InitializeComponent();
            DataContext = new DataManageVM();
        }
    }
}
