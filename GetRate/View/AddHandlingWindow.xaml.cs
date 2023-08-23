using GetRate.ViewModel;
using System.Windows;


namespace GetRate.View
{
    /// <summary>
    /// Interaction logic for AddHandlingWindow.xaml
    /// </summary>
    public partial class AddHandlingWindow : Window
    {
        public AddHandlingWindow()
        {
            InitializeComponent();
            DataContext = new DataManageVM();
        }
    }
}
