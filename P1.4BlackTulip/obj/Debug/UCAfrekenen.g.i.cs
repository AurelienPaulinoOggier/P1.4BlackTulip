﻿#pragma checksum "..\..\UCAfrekenen.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "FF0DA37016423DFBC389A748495BBB47D49FFFDF048E13ACFFB4106762CD2131"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using P1._4BlackTulip;
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


namespace P1._4BlackTulip {
    
    
    /// <summary>
    /// UCAfrekenen
    /// </summary>
    public partial class UCAfrekenen : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\UCAfrekenen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid GridAfrekenen;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\UCAfrekenen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgProducten;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\UCAfrekenen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgklanten;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\UCAfrekenen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtZoeken;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\UCAfrekenen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnZoeken;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\UCAfrekenen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtZoekenB;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\UCAfrekenen.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnZoekenB;
        
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
            System.Uri resourceLocater = new System.Uri("/P1.4BlackTulip;component/ucafrekenen.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\UCAfrekenen.xaml"
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
            this.GridAfrekenen = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.dgProducten = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 3:
            this.dgklanten = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 4:
            this.txtZoeken = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.btnZoeken = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\UCAfrekenen.xaml"
            this.btnZoeken.Click += new System.Windows.RoutedEventHandler(this.btnZoeken_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.txtZoekenB = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.btnZoekenB = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\UCAfrekenen.xaml"
            this.btnZoekenB.Click += new System.Windows.RoutedEventHandler(this.btnZoekenB_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

