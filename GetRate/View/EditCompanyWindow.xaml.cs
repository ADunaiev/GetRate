using GetRate.Model;
using GetRate.ViewModel;
using System.Linq;
using System.Windows;


namespace GetRate.View
{
    /// <summary>
    /// Interaction logic for EditCompanyWindow.xaml
    /// </summary>
    public partial class EditCompanyWindow : Window
    {
        public EditCompanyWindow(Company company)
        {
            InitializeComponent();
            DataContext = new DataManageVM();

            //CompanyTypeComboBox.ItemsSource = System.Enum.GetValues(typeof(CompanyType)).Cast<CompanyType>();
            //CompanyTypeComboBox.SelectedItem = company.companyType.ToString();

            DataManageVM.SelectedCompany = company;
            DataManageVM.CompanyId = company.Id;
            DataManageVM.CompanyNameENG = company.NameENG;
            DataManageVM.CompanyNameUKR = company.NameUKR;

        }
    }
}
