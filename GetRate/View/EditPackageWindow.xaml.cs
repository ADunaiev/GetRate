using GetRate.ViewModel;
using System.IO.Packaging;
using System.Windows;
using GetRate.Model;
using Package = GetRate.Model.Package;

namespace GetRate.View
{
    /// <summary>
    /// Interaction logic for EditPackageWindow.xaml
    /// </summary>
    public partial class EditPackageWindow : Window
    {
        public EditPackageWindow(Package package)
        {
            InitializeComponent();
            DataContext = new DataManageVM();
            DataManageVM.PackageId = package.Id;
            DataManageVM.PackageNameENG = package.NameENG;
            DataManageVM.PackageNameUKR = package.NameUKR;
            DataManageVM.PackagePayload = package.Payload;
            DataManageVM.PackageWeight = package.PackageWeight;
        }
    }
}
