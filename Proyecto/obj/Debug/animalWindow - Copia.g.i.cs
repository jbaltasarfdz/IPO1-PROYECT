﻿#pragma checksum "..\..\animalWindow - Copia.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "FB5283AB8FE63CE0608452D0CE2911C62BD7CAAD50BE19033B451177AC018584"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using Proyecto;
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


namespace Proyecto {
    
    
    /// <summary>
    /// animalWindow
    /// </summary>
    public partial class animalWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 43 "..\..\animalWindow - Copia.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbListaPerros;
        
        #line default
        #line hidden
        
        
        #line 130 "..\..\animalWindow - Copia.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAniadir;
        
        #line default
        #line hidden
        
        
        #line 138 "..\..\animalWindow - Copia.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnEditar;
        
        #line default
        #line hidden
        
        
        #line 146 "..\..\animalWindow - Copia.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnEliminar;
        
        #line default
        #line hidden
        
        
        #line 154 "..\..\animalWindow - Copia.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnInformacionApadrinado;
        
        #line default
        #line hidden
        
        
        #line 174 "..\..\animalWindow - Copia.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtEstado;
        
        #line default
        #line hidden
        
        
        #line 255 "..\..\animalWindow - Copia.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnInfo;
        
        #line default
        #line hidden
        
        
        #line 262 "..\..\animalWindow - Copia.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnApagar;
        
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
            System.Uri resourceLocater = new System.Uri("/Proyecto;component/animalwindow%20-%20copia.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\animalWindow - Copia.xaml"
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
            this.cbListaPerros = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 2:
            this.btnAniadir = ((System.Windows.Controls.Button)(target));
            
            #line 135 "..\..\animalWindow - Copia.xaml"
            this.btnAniadir.Click += new System.Windows.RoutedEventHandler(this.btnAniadir_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnEditar = ((System.Windows.Controls.Button)(target));
            
            #line 143 "..\..\animalWindow - Copia.xaml"
            this.btnEditar.Click += new System.Windows.RoutedEventHandler(this.btnEditar_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnEliminar = ((System.Windows.Controls.Button)(target));
            
            #line 151 "..\..\animalWindow - Copia.xaml"
            this.btnEliminar.Click += new System.Windows.RoutedEventHandler(this.btnEliminar_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnInformacionApadrinado = ((System.Windows.Controls.Button)(target));
            return;
            case 6:
            this.txtEstado = ((System.Windows.Controls.TextBox)(target));
            
            #line 178 "..\..\animalWindow - Copia.xaml"
            this.txtEstado.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtEstado_TextChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnInfo = ((System.Windows.Controls.Button)(target));
            
            #line 255 "..\..\animalWindow - Copia.xaml"
            this.btnInfo.Click += new System.Windows.RoutedEventHandler(this.btnInfo_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnApagar = ((System.Windows.Controls.Button)(target));
            
            #line 262 "..\..\animalWindow - Copia.xaml"
            this.btnApagar.Click += new System.Windows.RoutedEventHandler(this.btnApagar_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

