using GetRate.ViewModel;
using System.Windows;
using GetRate.Model;
using System;
using System.Linq;

namespace GetRate.View
{
    /// <summary>
    /// Interaction logic for AddCompanyWindow.xaml
    /// </summary>
    public partial class AddCompanyWindow : Window
    {
        public AddCompanyWindow()
        {
            InitializeComponent();
            DataContext = new DataManageVM();

            this.CompanyTypeComboBox.ItemsSource = Enum.GetValues(typeof(CompanyType)).Cast<CompanyType>();
        }
    }
}
