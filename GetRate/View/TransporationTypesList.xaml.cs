using GetRate.ViewModel;
using System.Windows;
using System.Windows.Controls;

namespace GetRate.View
{
    /// <summary>
    /// Interaction logic for TransporationTypesList.xaml
    /// </summary>
    public partial class TransporationTypesList : Window
    {
        public static ListView AllTransportationTypesView;
        public TransporationTypesList()
        {
            InitializeComponent();
            DataContext = new DataManageVM();
            AllTransportationTypesView = TransportationTypesListView;
        }
    }
}
