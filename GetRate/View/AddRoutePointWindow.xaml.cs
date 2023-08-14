using GetRate.Model;
using GetRate.ViewModel;
using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace GetRate.View
{
    /// <summary>
    /// Interaction logic for AddRoutePointWindow.xaml
    /// </summary>
    public partial class AddRoutePointWindow : Window
    {
        public AddRoutePointWindow()
        {

            InitializeComponent();
            DataContext = new DataManageVM();


        }

    }
}
