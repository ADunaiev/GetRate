using GetRate.ViewModel;
using System.Windows;


namespace GetRate.View
{
    /// <summary>
    /// Interaction logic for AddCargoPackageWindow.xaml
    /// </summary>
    public partial class AddCargoPackageWindow : Window
    {
        public AddCargoPackageWindow()
        {
            InitializeComponent();
            DataContext = new DataManageVM();
        }
    }
}
