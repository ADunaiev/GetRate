using GetRate.ViewModel;
using System.Windows;
using System.Windows.Controls;

namespace GetRate.View
{
    /// <summary>
    /// Interaction logic for RPTMUTList.xaml
    /// </summary>
    public partial class RPTMUTList : Window
    {
        public static ListView All_RPTMUTsView;
        public RPTMUTList()
        {
            InitializeComponent();
            DataContext = new DataManageVM();
            All_RPTMUTsView = RPTMUTListView;
        }
    }
}
