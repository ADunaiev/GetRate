﻿#pragma checksum "..\..\..\View\AddressesList.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E11D9B0E1F04CD863B8A728FA0DEE8DAD1DFAB2882B231281FBB52257A13747D"
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
    /// AddressesList
    /// </summary>
    public partial class AddressesList : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\..\View\AddressesList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal GetRate.View.AddressesList AddressesListWnd;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\View\AddressesList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button NewAddressBtn;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\View\AddressesList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EditAddressBtn;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\View\AddressesList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DeleteCityBtn;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\View\AddressesList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView AddressesListView;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\View\AddressesList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GridViewColumn IdColumn;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\View\AddressesList.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BackToMenuBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/GetRate;component/view/addresseslist.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\AddressesList.xaml"
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
            this.AddressesListWnd = ((GetRate.View.AddressesList)(target));
            return;
            case 2:
            this.NewAddressBtn = ((System.Windows.Controls.Button)(target));
            return;
            case 3:
            this.EditAddressBtn = ((System.Windows.Controls.Button)(target));
            return;
            case 4:
            this.DeleteCityBtn = ((System.Windows.Controls.Button)(target));
            return;
            case 5:
            this.AddressesListView = ((System.Windows.Controls.ListView)(target));
            return;
            case 6:
            this.IdColumn = ((System.Windows.Controls.GridViewColumn)(target));
            return;
            case 7:
            this.BackToMenuBtn = ((System.Windows.Controls.Button)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

