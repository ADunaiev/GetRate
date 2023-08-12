using GetRate.ViewModel;
using System.Windows;
using GetRate.Model;
using System;
using System.Linq;
using System.Windows.Controls;

namespace GetRate.View
{
    /// <summary>
    /// Interaction logic for AddCompanyWindow.xaml
    /// </summary>
    public partial class AddCompanyWindow : Window
    {
        public static ComboBox NewAddressesItemSource;
        public AddCompanyWindow()
        {
            InitializeComponent();
            DataContext = new DataManageVM();

            NewAddressesItemSource = AddressComboBox;

            this.CompanyTypeComboBox.ItemsSource = Enum.GetValues(typeof(CompanyType)).Cast<CompanyType>();
        }
    }
}
