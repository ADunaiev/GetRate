using GetRate.ViewModel;
using System.Windows;
using System.Windows.Controls;

namespace GetRate.View
{
    /// <summary>
    /// Interaction logic for AddUnitTypeWindow.xaml
    /// </summary>
    public partial class AddUnitTypeWindow : Window
    {
        public AddUnitTypeWindow()
        {
            InitializeComponent();
            DataContext = new DataManageVM();
        }
    }
}
