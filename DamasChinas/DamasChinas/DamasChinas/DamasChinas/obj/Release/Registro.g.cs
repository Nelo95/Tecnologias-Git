﻿#pragma checksum "..\..\Registro.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "AB8871D20B050E302D6E12707896425F"
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
    /// Registrarse
    /// </summary>
    public partial class Registrarse : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\Registro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNombre;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\Registro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtUsuario;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\Registro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox txtPass;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\Registro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button crearCuentaBttn;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\Registro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button regresarBttn;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\Registro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Info;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\Registro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Nombre;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\Registro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Usuario;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\Registro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Contraseña;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\Registro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Idioma;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\Registro.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Esp;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\Registro.xaml"
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
            System.Uri resourceLocater = new System.Uri("/DamasChinas;component/registro.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Registro.xaml"
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
            this.txtNombre = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.txtUsuario = ((System.Windows.Controls.TextBox)(target));
            
            #line 11 "..\..\Registro.xaml"
            this.txtUsuario.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtUsuario_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txtPass = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 4:
            this.crearCuentaBttn = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\Registro.xaml"
            this.crearCuentaBttn.Click += new System.Windows.RoutedEventHandler(this.crearCuenta_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.regresarBttn = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\Registro.xaml"
            this.regresarBttn.Click += new System.Windows.RoutedEventHandler(this.regresarBttn_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Info = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.Nombre = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.Usuario = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.Contraseña = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 10:
            this.Idioma = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 11:
            this.Esp = ((System.Windows.Controls.TextBlock)(target));
            
            #line 20 "..\..\Registro.xaml"
            this.Esp.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Esp_MouseDown);
            
            #line default
            #line hidden
            return;
            case 12:
            this.Eng = ((System.Windows.Controls.TextBlock)(target));
            
            #line 21 "..\..\Registro.xaml"
            this.Eng.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Eng_MouseDown);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

