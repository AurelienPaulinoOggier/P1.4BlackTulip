﻿#pragma checksum "..\..\UCBesteling.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "311CE0415F27424E61956B403B00906995DD7B8C1D6B7953D7130986C789C5F6"
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
    /// UCBesteling
    /// </summary>
    public partial class UCBesteling : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\UCBesteling.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid GridBesteling;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\UCBesteling.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgFactuur;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\UCBesteling.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbKlant;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\UCBesteling.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgProduct;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\UCBesteling.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtDatum;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\UCBesteling.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnOpslaan;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\UCBesteling.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtTprijs;
        
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
            System.Uri resourceLocater = new System.Uri("/P1.4BlackTulip;component/ucbesteling.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\UCBesteling.xaml"
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
            this.GridBesteling = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.dgFactuur = ((System.Windows.Controls.DataGrid)(target));
            
            #line 10 "..\..\UCBesteling.xaml"
            this.dgFactuur.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.dgFactuur_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 3:
            this.cmbKlant = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.dgProduct = ((System.Windows.Controls.DataGrid)(target));
            
            #line 34 "..\..\UCBesteling.xaml"
            this.dgProduct.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.dgProduct_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 5:
            this.txtDatum = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.btnOpslaan = ((System.Windows.Controls.Button)(target));
            
            #line 51 "..\..\UCBesteling.xaml"
            this.btnOpslaan.Click += new System.Windows.RoutedEventHandler(this.btnOpslaan_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.txtTprijs = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

