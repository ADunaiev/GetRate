using GetRate.ViewModel;
using System.Windows;


namespace GetRate.View
{
    /// <summary>
    /// Interaction logic for AddRouteItemRateWindow.xaml
    /// </summary>
    public partial class AddRouteItemRateWindow : Window
    {
        public AddRouteItemRateWindow()
        {
            InitializeComponent();
            DataContext = new DataManageVM();
        }
    }
}
