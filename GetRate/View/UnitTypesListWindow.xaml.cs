using GetRate.ViewModel;
using System.Windows;
using System.Windows.Controls;

namespace GetRate.View
{
    /// <summary>
    /// Interaction logic for UnitTypesListWindow.xaml
    /// </summary>
    public partial class UnitTypesListWindow : Window
    {
        public static ListView AllUnitTypesList;
        public UnitTypesListWindow()
        {
            InitializeComponent();
            DataContext = new DataManageVM();
            AllUnitTypesList = UnitTypesListView;
        }
    }
}
