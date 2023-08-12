
using GetRate.ViewModel;
using System.Windows;
using System.Windows.Controls;

namespace GetRate.View
{
    /// <summary>
    /// Interaction logic for AddressCard.xaml
    /// </summary>
    public partial class AddAddressWindow : Window
    {
        public static ComboBox NewCitiesSource;
        public AddAddressWindow()
        {
            InitializeComponent();
            DataContext = new DataManageVM();
            NewCitiesSource = CitiesComboBox;
        }
    }
}
