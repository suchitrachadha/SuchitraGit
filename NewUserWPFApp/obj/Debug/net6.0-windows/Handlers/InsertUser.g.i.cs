﻿#pragma checksum "..\..\..\..\Handlers\InsertUser.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D4E916BC78CE443C0F181BA9D34F4B5DC843F61B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using NewUserWPFApp.Handlers;
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


namespace NewUserWPFApp.Handlers {
    
    
    /// <summary>
    /// InsertUser
    /// </summary>
    public partial class InsertUser : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 30 "..\..\..\..\Handlers\InsertUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox UIInsertPosition;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\..\Handlers\InsertUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox UIInsertFirstName;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\Handlers\InsertUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox UIInsertLastName;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\..\Handlers\InsertUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox UIInsertEmailAddr;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\..\Handlers\InsertUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox UIInsertGoalDesc;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\..\Handlers\InsertUser.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button insert;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\..\Handlers\InsertUser.xaml"
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
            System.Uri resourceLocater = new System.Uri("/NewUserWPFApp;component/handlers/insertuser.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Handlers\InsertUser.xaml"
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
            this.UIInsertPosition = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.UIInsertFirstName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.UIInsertLastName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.UIInsertEmailAddr = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.UIInsertGoalDesc = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.insert = ((System.Windows.Controls.Button)(target));
            
            #line 54 "..\..\..\..\Handlers\InsertUser.xaml"
            this.insert.Click += new System.Windows.RoutedEventHandler(this.InsertUserToList);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Clear = ((System.Windows.Controls.Button)(target));
            
            #line 59 "..\..\..\..\Handlers\InsertUser.xaml"
            this.Clear.Click += new System.Windows.RoutedEventHandler(this.ClearForm);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

