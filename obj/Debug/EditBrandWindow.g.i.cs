﻿#pragma checksum "..\..\EditBrandWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "9D5C85DC4D3C02D7376864523DAACB60"
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
    /// EditBrandWindow
    /// </summary>
    public partial class EditBrandWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 41 "..\..\EditBrandWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label1EditBrand;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\EditBrandWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboBox_BrandsEditBrand;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\EditBrandWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bt_EditEditBrand;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\EditBrandWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label2EditBrand;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\EditBrandWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox textBox_nameBrandEditBrand;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\EditBrandWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label label3EditBrand;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\EditBrandWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox comboBox_CategoriesEditBrand;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\EditBrandWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button bt_SaveEditBrand;
        
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
            System.Uri resourceLocater = new System.Uri("/ServiceCentreWPF;component/editbrandwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\EditBrandWindow.xaml"
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
            
            #line 8 "..\..\EditBrandWindow.xaml"
            ((ServiceCentreWPF.EditBrandWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.label1EditBrand = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.comboBox_BrandsEditBrand = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.bt_EditEditBrand = ((System.Windows.Controls.Button)(target));
            
            #line 43 "..\..\EditBrandWindow.xaml"
            this.bt_EditEditBrand.Click += new System.Windows.RoutedEventHandler(this.bt_EditEditBrand_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.label2EditBrand = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.textBox_nameBrandEditBrand = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.label3EditBrand = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.comboBox_CategoriesEditBrand = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 9:
            this.bt_SaveEditBrand = ((System.Windows.Controls.Button)(target));
            
            #line 48 "..\..\EditBrandWindow.xaml"
            this.bt_SaveEditBrand.Click += new System.Windows.RoutedEventHandler(this.bt_SaveEditBrand_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

