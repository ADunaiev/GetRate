using GetRate.ViewModel;
using System.Windows;
using System.Windows.Controls;

namespace GetRate.View
{
    /// <summary>
    /// Interaction logic for PackagesList.xaml
    /// </summary>
    public partial class PackagesList : Window
    {
        public static ListView AllPackagesView;
        public PackagesList()
        {
            InitializeComponent();
            DataContext = new DataManageVM();
            AllPackagesView = PackagesListView;
        }
    }
}
