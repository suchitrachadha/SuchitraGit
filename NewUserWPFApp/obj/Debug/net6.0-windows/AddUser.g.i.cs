﻿#pragma checksum "..\..\..\AddUser.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "142E4E9C7A70C462B49A07A7918EF6B225748BED"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using NewUserWPFApp;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace NewUserWPFApp {
    
    
    /// <summary>
    /// AddUser
    /// </summary>
    public partial class AddUser : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 1 "..\..\..\AddUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal NewUserWPFApp.AddUser CreateUser;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\AddUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox UIFirstName;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\AddUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox UILastName;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\AddUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox UIEmailAddr;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\AddUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox UIGoalDesc;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\AddUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button create;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\AddUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Clear;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/NewUserWPFApp;component/adduser.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\AddUser.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.CreateUser = ((NewUserWPFApp.AddUser)(target));
            return;
            case 2:
            this.UIFirstName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.UILastName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.UIEmailAddr = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.UIGoalDesc = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.create = ((System.Windows.Controls.Button)(target));
            
            #line 49 "..\..\..\AddUser.xaml"
            this.create.Click += new System.Windows.RoutedEventHandler(this.AddUserToList);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Clear = ((System.Windows.Controls.Button)(target));
            
            #line 54 "..\..\..\AddUser.xaml"
            this.Clear.Click += new System.Windows.RoutedEventHandler(this.ClearForm);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

