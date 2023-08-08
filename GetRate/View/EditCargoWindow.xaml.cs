using GetRate.ViewModel;
using System.Windows;
using GetRate.Model;

namespace GetRate.View
{
    /// <summary>
    /// Interaction logic for EditCargoWindow.xaml
    /// </summary>
    public partial class EditCargoWindow : Window
    {
        public EditCargoWindow(Cargo cargo)
        {
            InitializeComponent();
            DataContext = new DataManageVM();
            DataManageVM.CargoId = cargo.Id;
            DataManageVM.CargoNameENG = cargo.NameENG;
            DataManageVM.CargoNameUKR = cargo.NameUKR;
            DataManageVM.CargoCode = cargo.Code;
        }
    }
}
