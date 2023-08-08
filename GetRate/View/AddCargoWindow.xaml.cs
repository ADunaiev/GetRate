using GetRate.ViewModel;
using System.Windows;


namespace GetRate.View
{
    /// <summary>
    /// Interaction logic for AddCargoWindow.xaml
    /// </summary>
    public partial class AddCargoWindow : Window
    {
        public AddCargoWindow()
        {
            InitializeComponent();
            DataContext = new DataManageVM();
        }
    }
}
