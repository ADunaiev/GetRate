using GetRate.ViewModel;
using System.Windows;

namespace GetRate.View
{
    /// <summary>
    /// Interaction logic for AddRPTMUTWindow.xaml
    /// </summary>
    public partial class AddRPTMUTWindow : Window
    {
        public AddRPTMUTWindow()
        {
            InitializeComponent();
            DataContext = new DataManageVM();
        }
    }
}
