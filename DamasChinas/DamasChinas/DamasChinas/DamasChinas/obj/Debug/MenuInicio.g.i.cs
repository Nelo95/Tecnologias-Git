#pragma checksum "..\..\MenuInicio.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "B2A52F20D19B6979EA4FE8459DB6B664"
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


namespace DamasChinas
{


    /// <summary>
    /// MenuInicio
    /// </summary>
    public partial class MenuInicio : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {

#line default
#line hidden


#line 11 "..\..\MenuInicio.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Bienvenido;

#line default
#line hidden


#line 12 "..\..\MenuInicio.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button IniciarPartida;

#line default
#line hidden


#line 13 "..\..\MenuInicio.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Tutorial;

#line default
#line hidden


#line 14 "..\..\MenuInicio.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Puntajes;

#line default
#line hidden


#line 15 "..\..\MenuInicio.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BuscarPartida;

#line default
#line hidden


#line 16 "..\..\MenuInicio.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Historial;

#line default
#line hidden


#line 17 "..\..\MenuInicio.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CerrarSesion;

#line default
#line hidden


#line 18 "..\..\MenuInicio.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Idioma;

#line default
#line hidden


#line 19 "..\..\MenuInicio.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Esp;

#line default
#line hidden


#line 20 "..\..\MenuInicio.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Eng;

#line default
#line hidden


#line 21 "..\..\MenuInicio.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Cuenta;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/DamasChinas;component/menuinicio.xaml", System.UriKind.Relative);

#line 1 "..\..\MenuInicio.xaml"
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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.Menú = ((DamasChinas.MenuInicio)(target));
                    return;
                case 2:
                    this.Bienvenido = ((System.Windows.Controls.TextBlock)(target));
                    return;
                case 3:
                    this.IniciarPartida = ((System.Windows.Controls.Button)(target));

#line 12 "..\..\MenuInicio.xaml"
                    this.IniciarPartida.Click += new System.Windows.RoutedEventHandler(this.IniciarPartida_Click);

#line default
#line hidden
                    return;
                case 4:
                    this.Tutorial = ((System.Windows.Controls.Button)(target));
                    return;
                case 5:
                    this.Puntajes = ((System.Windows.Controls.Button)(target));
                    return;
                case 6:
                    this.BuscarPartida = ((System.Windows.Controls.Button)(target));

#line 15 "..\..\MenuInicio.xaml"
                    this.BuscarPartida.Click += new System.Windows.RoutedEventHandler(this.BuscarPartida_Click);

#line default
#line hidden
                    return;
                case 7:
                    this.Historial = ((System.Windows.Controls.Button)(target));

#line 16 "..\..\MenuInicio.xaml"
                    this.Historial.Click += new System.Windows.RoutedEventHandler(this.Historial_Click);

#line default
#line hidden
                    return;
                case 8:
                    this.CerrarSesion = ((System.Windows.Controls.Button)(target));
                    return;
                case 9:
                    this.Idioma = ((System.Windows.Controls.TextBlock)(target));
                    return;
                case 10:
                    this.Esp = ((System.Windows.Controls.TextBlock)(target));

#line 19 "..\..\MenuInicio.xaml"
                    this.Esp.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Esp_MouseDown);

#line default
#line hidden
                    return;
                case 11:
                    this.Eng = ((System.Windows.Controls.TextBlock)(target));

#line 20 "..\..\MenuInicio.xaml"
                    this.Eng.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Eng_MouseDown);

#line default
#line hidden
                    return;
                case 12:
                    this.Cuenta = ((System.Windows.Controls.Button)(target));

#line 21 "..\..\MenuInicio.xaml"
                    this.Cuenta.Click += new System.Windows.RoutedEventHandler(this.Cuenta_Click);

#line default
#line hidden
                    return;
            }
            this._contentLoaded = true;
        }

        internal System.Windows.Window Menú;
    }
}

