﻿#pragma checksum "..\..\MainWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5E74896A38AD281D36B8754D0CE21FBFE118EEC262EA0EA92A00E2D192F18212"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
using arch2mmWpf;


namespace arch2mmWpf {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 34 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox FeetTextbox;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox InchTextbox;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NumeratorTextbox;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox DenominatorTextbox;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ouputText;
        
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
            System.Uri resourceLocater = new System.Uri("/arch2mmWpf;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\MainWindow.xaml"
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
            this.FeetTextbox = ((System.Windows.Controls.TextBox)(target));
            
            #line 39 "..\..\MainWindow.xaml"
            this.FeetTextbox.GotFocus += new System.Windows.RoutedEventHandler(this.FeetTextbox_GotFocus);
            
            #line default
            #line hidden
            
            #line 40 "..\..\MainWindow.xaml"
            this.FeetTextbox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.FeetTextbox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.InchTextbox = ((System.Windows.Controls.TextBox)(target));
            
            #line 49 "..\..\MainWindow.xaml"
            this.InchTextbox.GotFocus += new System.Windows.RoutedEventHandler(this.InchTextbox_GotFocus);
            
            #line default
            #line hidden
            
            #line 50 "..\..\MainWindow.xaml"
            this.InchTextbox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.InchTextbox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.NumeratorTextbox = ((System.Windows.Controls.TextBox)(target));
            
            #line 56 "..\..\MainWindow.xaml"
            this.NumeratorTextbox.GotFocus += new System.Windows.RoutedEventHandler(this.NumeratorTextbox_GotFocus);
            
            #line default
            #line hidden
            
            #line 57 "..\..\MainWindow.xaml"
            this.NumeratorTextbox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.NumeratorTextbox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.DenominatorTextbox = ((System.Windows.Controls.TextBox)(target));
            
            #line 66 "..\..\MainWindow.xaml"
            this.DenominatorTextbox.GotFocus += new System.Windows.RoutedEventHandler(this.DenominatorTextbox_GotFocus);
            
            #line default
            #line hidden
            
            #line 67 "..\..\MainWindow.xaml"
            this.DenominatorTextbox.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.DenominatorTextbox_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ouputText = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

