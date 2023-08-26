using GetRate.ViewModel;
using System.Windows;


namespace GetRate.View
{
    /// <summary>
    /// Interaction logic for AddHandlingWindow.xaml
    /// </summary>
    public partial class AddRouteItemWindow : Window
    {
        public AddRouteItemWindow()
        {
            InitializeComponent();
            DataContext = new DataManageVM();
        }
    }
}
