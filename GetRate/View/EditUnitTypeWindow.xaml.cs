using GetRate.ViewModel;
using System.Windows;
using GetRate.Model;

namespace GetRate.View
{
    /// <summary>
    /// Interaction logic for EditUnitTypeWindow.xaml
    /// </summary>
    public partial class EditUnitTypeWindow : Window
    {
        public EditUnitTypeWindow(UnitType unitType)
        {
            InitializeComponent();
            DataContext = new DataManageVM();
            DataManageVM.UnitTypeId = unitType.Id;
            DataManageVM.UnitTypeNameENG = unitType.NameENG;
            DataManageVM.UnitTypeNameUKR = unitType.NameUKR;
            DataManageVM.UnitTypeMaxGW = unitType.MaximumGrossWeight;

        }
    }
}
