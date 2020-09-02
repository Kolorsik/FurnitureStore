﻿#pragma checksum "..\..\AboutProduct.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "85FEAE7FB27BDEC88D6588F5D665F9FC70524801CE090E0FED064680C94767A2"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Furniture_Store;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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


namespace Furniture_Store {
    
    
    /// <summary>
    /// AboutProduct
    /// </summary>
    public partial class AboutProduct : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\AboutProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image img;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\AboutProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock itemTitle;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\AboutProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock itemType;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\AboutProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock itemProvider;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\AboutProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock itemPrice;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\AboutProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button minusRate;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\AboutProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock itemRating;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\AboutProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button plusRate;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\AboutProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button butBuy;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\AboutProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button butReturn;
        
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
            System.Uri resourceLocater = new System.Uri("/Furniture Store;component/aboutproduct.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AboutProduct.xaml"
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
            this.img = ((System.Windows.Controls.Image)(target));
            return;
            case 2:
            this.itemTitle = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.itemType = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.itemProvider = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.itemPrice = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.minusRate = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\AboutProduct.xaml"
            this.minusRate.Click += new System.Windows.RoutedEventHandler(this.MinusRate_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.itemRating = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.plusRate = ((System.Windows.Controls.Button)(target));
            
            #line 49 "..\..\AboutProduct.xaml"
            this.plusRate.Click += new System.Windows.RoutedEventHandler(this.PlusRate_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.butBuy = ((System.Windows.Controls.Button)(target));
            
            #line 54 "..\..\AboutProduct.xaml"
            this.butBuy.Click += new System.Windows.RoutedEventHandler(this.ButBuy_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.butReturn = ((System.Windows.Controls.Button)(target));
            
            #line 56 "..\..\AboutProduct.xaml"
            this.butReturn.Click += new System.Windows.RoutedEventHandler(this.ButReturn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
