﻿#pragma checksum "..\..\ProductPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4ABF01F3FE1F5ABD91F15D2D9562CDDD4B3350904AD0995BEFBD8DD6A433A2D0"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Iskhakova41;
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


namespace Iskhakova41 {
    
    
    /// <summary>
    /// ProductPage
    /// </summary>
    public partial class ProductPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\ProductPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Count;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\ProductPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock AllRecords;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\ProductPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PoiskPoNaim;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\ProductPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton Vozrast;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\ProductPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton Ubiv;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\ProductPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox FiltrSkidka;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\ProductPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView ProductListView;
        
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
            System.Uri resourceLocater = new System.Uri("/Iskhakova41;component/productpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ProductPage.xaml"
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
            this.Count = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.AllRecords = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.PoiskPoNaim = ((System.Windows.Controls.TextBox)(target));
            
            #line 30 "..\..\ProductPage.xaml"
            this.PoiskPoNaim.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.PoiskPoNaim_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Vozrast = ((System.Windows.Controls.RadioButton)(target));
            
            #line 34 "..\..\ProductPage.xaml"
            this.Vozrast.Checked += new System.Windows.RoutedEventHandler(this.Vozrast_Checked);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Ubiv = ((System.Windows.Controls.RadioButton)(target));
            
            #line 38 "..\..\ProductPage.xaml"
            this.Ubiv.Checked += new System.Windows.RoutedEventHandler(this.Ubiv_Checked);
            
            #line default
            #line hidden
            return;
            case 6:
            this.FiltrSkidka = ((System.Windows.Controls.ComboBox)(target));
            
            #line 44 "..\..\ProductPage.xaml"
            this.FiltrSkidka.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.FiltrSkidka_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.ProductListView = ((System.Windows.Controls.ListView)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

