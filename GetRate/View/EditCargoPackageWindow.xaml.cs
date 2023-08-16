using GetRate.Model;
using GetRate.ViewModel;
using System.Windows;


namespace GetRate.View
{
    /// <summary>
    /// Interaction logic for EditCargoPackageWindow.xaml
    /// </summary>
    public partial class EditCargoPackageWindow : Window
    {
        public EditCargoPackageWindow(CargoPackage cargoPackage)
        {
            InitializeComponent();
            DataContext = new DataManageVM();
            DataManageVM.CargoPackageId = cargoPackage.Id;
        }
    }
}
