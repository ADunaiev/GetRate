using GetRate.Model;
using GetRate.ViewModel;
using System.Windows;


namespace GetRate.View
{
    /// <summary>
    /// Interaction logic for EditAddressWindow.xaml
    /// </summary>
    public partial class EditAddressWindow : Window
    {
        public EditAddressWindow(Address address)
        {
            InitializeComponent();
            DataContext = new DataManageVM();
            DataManageVM.SelectedAddress = address;
            DataManageVM.AddressId = address.Id;
            DataManageVM.AddressNameENG = address.StreetBuildingENG;
            DataManageVM.AddressNameUKR = address.StreetBuildingUKR;



        }
    }
}
