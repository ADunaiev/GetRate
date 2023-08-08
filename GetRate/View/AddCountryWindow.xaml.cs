using GetRate.Model;
using GetRate.ViewModel;
using System.Windows;


namespace GetRate.View
{
    /// <summary>
    /// Interaction logic for CountryCard.xaml
    /// </summary>
    public partial class AddCountryWindow : Window
    {
        public AddCountryWindow()
        {
            InitializeComponent();
            DataContext = new DataManageVM();
        }
    }
}
