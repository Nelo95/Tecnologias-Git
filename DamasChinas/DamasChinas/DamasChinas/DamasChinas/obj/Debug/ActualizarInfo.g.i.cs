﻿#pragma checksum "..\..\ActualizarInfo.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "B36AC4465450E5DA86BE8794BDC8E825"
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
    /// ActualizarInfo
    /// </summary>
    public partial class ActualizarInfo : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\ActualizarInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Informacion;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\ActualizarInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Nombre;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\ActualizarInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Usuario;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\ActualizarInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Contraseña;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\ActualizarInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button actualizaBttn;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\ActualizarInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button regresarBttn;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\ActualizarInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Idioma;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\ActualizarInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Esp;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\ActualizarInfo.xaml"
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
            System.Uri resourceLocater = new System.Uri("/DamasChinas;component/actualizarinfo.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ActualizarInfo.xaml"
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
            this.Informacion = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.Nombre = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.Usuario = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.Contraseña = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.actualizaBttn = ((System.Windows.Controls.Button)(target));
            return;
            case 6:
            this.regresarBttn = ((System.Windows.Controls.Button)(target));
            return;
            case 7:
            this.Idioma = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.Esp = ((System.Windows.Controls.TextBlock)(target));
            
            #line 20 "..\..\ActualizarInfo.xaml"
            this.Esp.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Esp_MouseDown);
            
            #line default
            #line hidden
            return;
            case 9:
            this.Eng = ((System.Windows.Controls.TextBlock)(target));
            
            #line 21 "..\..\ActualizarInfo.xaml"
            this.Eng.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Eng_MouseDown);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

