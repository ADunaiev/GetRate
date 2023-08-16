using GetRate.ViewModel;
using System.Windows;
using System.Windows.Controls;

namespace GetRate.View
{
    /// <summary>
    /// Interaction logic for CargoPackagesList.xaml
    /// </summary>
    public partial class CargoPackagesList : Window
    {
        public static ListView AllCargoPackaeesView;
        public CargoPackagesList()
        {
            InitializeComponent();
            DataContext = new DataManageVM();
            AllCargoPackaeesView = CargoPackagesListView;
        }
    }
}
