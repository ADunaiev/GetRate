using GetRate.ViewModel;
using System.Windows;


namespace GetRate.View
{
    /// <summary>
    /// Interaction logic for AddTransportationTypeWindow.xaml
    /// </summary>
    public partial class AddTransportationTypeWindow : Window
    {
        public AddTransportationTypeWindow()
        {
            InitializeComponent();
            DataContext = new DataManageVM();
        }
    }
}
