
using GetRate.ViewModel;
using System.Windows;


namespace GetRate.View
{
    /// <summary>
    /// Interaction logic for AddressCard.xaml
    /// </summary>
    public partial class AddAddressWindow : Window
    {
        public AddAddressWindow()
        {
            InitializeComponent();
            DataContext = new DataManageVM();
        }
    }
}
