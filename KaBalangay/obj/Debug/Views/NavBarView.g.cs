﻿#pragma checksum "..\..\..\Views\NavBarView.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "01D24419AC1E7DF93B72073A33460EC0D48A3A0D566370D0C29D2F6D350F20F0"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using KaBalangay.Views;
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


namespace KaBalangay.Views {
    
    
    /// <summary>
    /// NavBarView
    /// </summary>
    public partial class NavBarView : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\..\Views\NavBarView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button hmeButton;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\Views\NavBarView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button abtButton;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\Views\NavBarView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button rgsButton;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Views\NavBarView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button srsButton;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Views\NavBarView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button lgoutButton;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Views\NavBarView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ContentControl MainContentControl;
        
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
            System.Uri resourceLocater = new System.Uri("/KaBalangay;component/views/navbarview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\NavBarView.xaml"
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
            this.hmeButton = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\..\Views\NavBarView.xaml"
            this.hmeButton.Click += new System.Windows.RoutedEventHandler(this.HomeButton_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.abtButton = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\Views\NavBarView.xaml"
            this.abtButton.Click += new System.Windows.RoutedEventHandler(this.AboutButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.rgsButton = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\..\Views\NavBarView.xaml"
            this.rgsButton.Click += new System.Windows.RoutedEventHandler(this.RegisterButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.srsButton = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\Views\NavBarView.xaml"
            this.srsButton.Click += new System.Windows.RoutedEventHandler(this.ServicesButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.lgoutButton = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\..\Views\NavBarView.xaml"
            this.lgoutButton.Click += new System.Windows.RoutedEventHandler(this.LogoutButton_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.MainContentControl = ((System.Windows.Controls.ContentControl)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

