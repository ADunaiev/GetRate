﻿#pragma checksum "..\..\..\View\EditCityWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E68A0B99DE2E864358388029CFC65FDD13CE6E04104B59C872F6B26E525702BB"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using GetRate.View;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace GetRate.View {
    
    
    /// <summary>
    /// EditCityWindow
    /// </summary>
    public partial class EditCityWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\..\View\EditCityWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal GetRate.View.EditCityWindow EditCityWnd;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\View\EditCityWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CityNameENGTextBox;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\View\EditCityWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label CityIdLabel;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\View\EditCityWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CityNameUKRTextBox;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\View\EditCityWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CountriesComboBox;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\View\EditCityWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddCountryBtn;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\View\EditCityWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SaveCityBtn;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\View\EditCityWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CancelCityBtn;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/GetRate;component/view/editcitywindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\EditCityWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.EditCityWnd = ((GetRate.View.EditCityWindow)(target));
            return;
            case 2:
            this.CityNameENGTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.CityIdLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.CityNameUKRTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.CountriesComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.AddCountryBtn = ((System.Windows.Controls.Button)(target));
            return;
            case 7:
            this.SaveCityBtn = ((System.Windows.Controls.Button)(target));
            return;
            case 8:
            this.CancelCityBtn = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

