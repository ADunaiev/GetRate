using GetRate.ViewModel;
using GetRate.Model;
using System.Windows;


namespace GetRate.View
{
    /// <summary>
    /// Interaction logic for EditHandlingWindow.xaml
    /// </summary>
    public partial class EditHandlingWindow : Window
    {
        public EditHandlingWindow(Handling handling)
        {
            InitializeComponent();
            DataContext = new DataManageVM();
            DataManageVM.HandlingId = handling.Id;
        }
    }
}
