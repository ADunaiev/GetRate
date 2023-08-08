using GetRate.ViewModel;
using System.Windows;
using System.Windows.Controls;

namespace GetRate.View
{
    /// <summary>
    /// Interaction logic for AddressesList.xaml
    /// </summary>
    public partial class AddressesList : Window
    {
        public static ListView AllAddressesView;
        public AddressesList()
        {
            InitializeComponent();
            DataContext = new DataManageVM();
            AllAddressesView = AddressesListView;
        }
    }
}
