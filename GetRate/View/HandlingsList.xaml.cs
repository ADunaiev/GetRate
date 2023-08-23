using GetRate.ViewModel;
using System.Windows;
using System.Windows.Controls;

namespace GetRate.View
{
    /// <summary>
    /// Interaction logic for HandlingsList.xaml
    /// </summary>
    public partial class HandlingsList : Window
    {
        public static ListView AllHandlingsView;
        public HandlingsList()
        {
            InitializeComponent();
            DataContext = new DataManageVM();
            AllHandlingsView = HandlingsListView;
        }
    }
}
