﻿#pragma checksum "..\..\AddBrandWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "D1A2199CF688B98E31DB50B96DEE96D2"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.17929
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using ServiceCentreWPF;
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


namespace ServiceCentreWPF {
    
    
    /// <summary>
    /// AddBrandWindow
    /// </summary>
    public partial class AddBrandWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 38 "..\..\AddBrandWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label1AddBrand;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\AddBrandWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBox1AddBrand;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\AddBrandWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label2AddBrand;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\AddBrandWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboBox_CategoriesAddBrand;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\AddBrandWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bt_AddBrandAddBrand;
        
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
            System.Uri resourceLocater = new System.Uri("/ServiceCentreWPF;component/addbrandwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AddBrandWindow.xaml"
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
            
            #line 8 "..\..\AddBrandWindow.xaml"
            ((ServiceCentreWPF.AddBrandWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.label1AddBrand = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.textBox1AddBrand = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.label2AddBrand = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.comboBox_CategoriesAddBrand = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.bt_AddBrandAddBrand = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\AddBrandWindow.xaml"
            this.bt_AddBrandAddBrand.Click += new System.Windows.RoutedEventHandler(this.bt_AddBrandAddBrand_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
