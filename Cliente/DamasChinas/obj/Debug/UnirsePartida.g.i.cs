﻿#pragma checksum "..\..\UnirsePartida.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ACFA322788602DA36B62BA6B5777C45F0792C93F"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using DamasChinas;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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


namespace DamasChinas {
    
    
    /// <summary>
    /// UnirsePartida
    /// </summary>
    public partial class UnirsePartida : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\UnirsePartida.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Filtrar;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\UnirsePartida.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Buscar;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\UnirsePartida.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Partidas;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\UnirsePartida.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Volver;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\UnirsePartida.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Unirse;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\UnirsePartida.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Idioma;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\UnirsePartida.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Esp;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\UnirsePartida.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Eng;
        
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
            System.Uri resourceLocater = new System.Uri("/DamasChinas;component/unirsepartida.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\UnirsePartida.xaml"
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
            this.Filtrar = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.Buscar = ((System.Windows.Controls.Button)(target));
            return;
            case 3:
            this.Partidas = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.Volver = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\UnirsePartida.xaml"
            this.Volver.Click += new System.Windows.RoutedEventHandler(this.Volver_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Unirse = ((System.Windows.Controls.Button)(target));
            return;
            case 6:
            this.Idioma = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.Esp = ((System.Windows.Controls.TextBlock)(target));
            
            #line 21 "..\..\UnirsePartida.xaml"
            this.Esp.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Esp_MouseDown);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Eng = ((System.Windows.Controls.TextBlock)(target));
            
            #line 22 "..\..\UnirsePartida.xaml"
            this.Eng.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Eng_MouseDown);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

