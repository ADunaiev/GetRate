using GetRate.ViewModel;
using System.Windows;
using System.Windows.Controls;

namespace GetRate.View
{
    /// <summary>
    /// Interaction logic for CompaniesList.xaml
    /// </summary>
    public partial class CompaniesList : Window
    {
        public static ListView AllCompaniesView;
        public CompaniesList()
        {
            InitializeComponent();
            DataContext = new DataManageVM();
            AllCompaniesView = CompamiesListView;
        }
    }
}
