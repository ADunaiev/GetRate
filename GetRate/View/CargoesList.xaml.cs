using GetRate.ViewModel;
using System.Windows;
using System.Windows.Controls;

namespace GetRate.View
{
    /// <summary>
    /// Interaction logic for CargoesList.xaml
    /// </summary>
    public partial class CargoesList : Window
    {
        public static ListView AllCagoesList;
        public CargoesList()
        {
            InitializeComponent();
            DataContext = new DataManageVM();
            AllCagoesList = CargoesListView;
        }
    }
}
