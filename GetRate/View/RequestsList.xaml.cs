using GetRate.ViewModel;
using System.Windows;
using System.Windows.Controls;

namespace GetRate.View
{
    /// <summary>
    /// Interaction logic for RequestsList.xaml
    /// </summary>
    public partial class RequestsList : Window
    {
        public static ListView AllRequestsListView;
        public RequestsList()
        {
            InitializeComponent();
            DataContext = new DataManageVM();
            AllRequestsListView = RequestListView;
        }
    }
}
