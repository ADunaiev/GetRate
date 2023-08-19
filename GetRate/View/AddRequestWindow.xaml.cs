using GetRate.ViewModel;
using System.Windows;


namespace GetRate.View
{
    /// <summary>
    /// Interaction logic for AddRequestWindow.xaml
    /// </summary>
    public partial class AddRequestWindow : Window
    {
        public AddRequestWindow()
        {
            InitializeComponent();
            DataContext = new DataManageVM();
        }
    }
}
