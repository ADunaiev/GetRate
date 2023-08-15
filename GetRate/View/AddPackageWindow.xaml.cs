using GetRate.ViewModel;
using System.Windows;


namespace GetRate.View
{
    /// <summary>
    /// Interaction logic for AddPackageWindow.xaml
    /// </summary>
    public partial class AddPackageWindow : Window
    {
        public AddPackageWindow()
        {
            InitializeComponent();
            this.DataContext = new DataManageVM();
        }
    }
}
