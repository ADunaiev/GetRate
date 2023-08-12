using GetRate.ViewModel;
using System.Windows;


namespace GetRate.View
{
    /// <summary>
    /// Interaction logic for AddTransportModeWindow.xaml
    /// </summary>
    public partial class AddTransportModeWindow : Window
    {
        public AddTransportModeWindow()
        {
            InitializeComponent();
            DataContext = new DataManageVM();
        }
    }
}
