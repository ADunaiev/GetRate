﻿#pragma checksum "..\..\..\View\AddRequestWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A69EEBCE9E5C67B7F86A6F9D2F9906BD74A2E93704B35B2412DC2095CD6FA66F"
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
    /// AddRequestWindow
    /// </summary>
    public partial class AddRequestWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\..\View\AddRequestWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal GetRate.View.AddRequestWindow AddNewRequestWnd;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\View\AddRequestWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label RequestIdLabel;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\..\View\AddRequestWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label RequestDateLabel;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\View\AddRequestWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox CustomerComboBox;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\View\AddRequestWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox FromCargoPackageComboBox;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\View\AddRequestWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ToCargoPackageComboBox;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\View\AddRequestWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox FromCityComboBox;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\View\AddRequestWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox FromPointComboBox;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\View\AddRequestWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ToCityComboBox;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\View\AddRequestWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ToPointComboBox;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\..\View\AddRequestWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CargoGWTextBox;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\..\View\AddRequestWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CargoVolumeTextBox;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\..\View\AddRequestWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SaveRequestBtn;
        
        #line default
        #line hidden
        
        
        #line 97 "..\..\..\View\AddRequestWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CancelRequestBtn;
        
        #line default
        #line hidden
        
        
        #line 105 "..\..\..\View\AddRequestWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton FromHandlingRadioButton;
        
        #line default
        #line hidden
        
        
        #line 111 "..\..\..\View\AddRequestWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton ToHandlingRadioButton;
        
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
            System.Uri resourceLocater = new System.Uri("/GetRate;component/view/addrequestwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\AddRequestWindow.xaml"
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
            this.AddNewRequestWnd = ((GetRate.View.AddRequestWindow)(target));
            return;
            case 2:
            this.RequestIdLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.RequestDateLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.CustomerComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.FromCargoPackageComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.ToCargoPackageComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 7:
            this.FromCityComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            this.FromPointComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 9:
            this.ToCityComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 10:
            this.ToPointComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 11:
            this.CargoGWTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 12:
            this.CargoVolumeTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 13:
            this.SaveRequestBtn = ((System.Windows.Controls.Button)(target));
            return;
            case 14:
            this.CancelRequestBtn = ((System.Windows.Controls.Button)(target));
            return;
            case 15:
            this.FromHandlingRadioButton = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 16:
            this.ToHandlingRadioButton = ((System.Windows.Controls.RadioButton)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
