﻿#pragma checksum "..\..\..\..\Views\HomeWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5711D74B5213B98482DDCFE1A2C2D6D72BED26C1"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using FontAwesome.Sharp;
using PaySheetMenagementSystemForInterns.Views;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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


namespace PaySheetMenagementSystemForInterns.Views {
    
    
    /// <summary>
    /// HomeWindow
    /// </summary>
    public partial class HomeWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 71 "..\..\..\..\Views\HomeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CloseButton;
        
        #line default
        #line hidden
        
        
        #line 93 "..\..\..\..\Views\HomeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button MaximizeButton;
        
        #line default
        #line hidden
        
        
        #line 116 "..\..\..\..\Views\HomeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button MinimizeButton;
        
        #line default
        #line hidden
        
        
        #line 157 "..\..\..\..\Views\HomeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Menu Menu;
        
        #line default
        #line hidden
        
        
        #line 183 "..\..\..\..\Views\HomeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button webBrowserLoadButton;
        
        #line default
        #line hidden
        
        
        #line 201 "..\..\..\..\Views\HomeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button notePadLoadButton;
        
        #line default
        #line hidden
        
        
        #line 239 "..\..\..\..\Views\HomeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock showingWhoIsLoggedTextBlock;
        
        #line default
        #line hidden
        
        
        #line 253 "..\..\..\..\Views\HomeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ContentControl UserControlLoader1;
        
        #line default
        #line hidden
        
        
        #line 288 "..\..\..\..\Views\HomeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label connectionStateShowingLabel;
        
        #line default
        #line hidden
        
        
        #line 293 "..\..\..\..\Views\HomeWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label realTimeDateShowingLable;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.3.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/PaySheetMenagementSystemForInterns;component/views/homewindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\HomeWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.3.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 34 "..\..\..\..\Views\HomeWindow.xaml"
            ((System.Windows.Controls.Border)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Border_MouseLeftButtonDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.CloseButton = ((System.Windows.Controls.Button)(target));
            
            #line 73 "..\..\..\..\Views\HomeWindow.xaml"
            this.CloseButton.Click += new System.Windows.RoutedEventHandler(this.CloseButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.MaximizeButton = ((System.Windows.Controls.Button)(target));
            
            #line 95 "..\..\..\..\Views\HomeWindow.xaml"
            this.MaximizeButton.Click += new System.Windows.RoutedEventHandler(this.MaximizeButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.MinimizeButton = ((System.Windows.Controls.Button)(target));
            
            #line 118 "..\..\..\..\Views\HomeWindow.xaml"
            this.MinimizeButton.Click += new System.Windows.RoutedEventHandler(this.MinimizeButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Menu = ((System.Windows.Controls.Menu)(target));
            return;
            case 6:
            
            #line 162 "..\..\..\..\Views\HomeWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuItemHome_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 175 "..\..\..\..\Views\HomeWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuItemNewbie_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 177 "..\..\..\..\Views\HomeWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuItemDashboard_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 179 "..\..\..\..\Views\HomeWindow.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.MenuItemSetting_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.webBrowserLoadButton = ((System.Windows.Controls.Button)(target));
            
            #line 186 "..\..\..\..\Views\HomeWindow.xaml"
            this.webBrowserLoadButton.Click += new System.Windows.RoutedEventHandler(this.webBrowserLoadButton_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.notePadLoadButton = ((System.Windows.Controls.Button)(target));
            
            #line 206 "..\..\..\..\Views\HomeWindow.xaml"
            this.notePadLoadButton.Click += new System.Windows.RoutedEventHandler(this.notePadLoadButton_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this.showingWhoIsLoggedTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 13:
            this.UserControlLoader1 = ((System.Windows.Controls.ContentControl)(target));
            
            #line 253 "..\..\..\..\Views\HomeWindow.xaml"
            this.UserControlLoader1.SizeChanged += new System.Windows.SizeChangedEventHandler(this.UserControlLoader1_SizeChanged);
            
            #line default
            #line hidden
            return;
            case 14:
            this.connectionStateShowingLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 15:
            this.realTimeDateShowingLable = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

