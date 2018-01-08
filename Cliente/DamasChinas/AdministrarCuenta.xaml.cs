using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Resources;
using System.Globalization;
using System.Windows.Navigation;

namespace DamasChinas
{
    /// <summary>
    /// Lógica de interacción para AdministrarCuenta.xaml
    /// </summary>
    public partial class AdministrarCuenta : Window
    {
        ResourceManager AdministradorDeRecursos;
        CultureInfo Cultura;
        string Lenguaje;
        string NombreJugador;

        public AdministrarCuenta(string nombreJugador)
        {
            InitializeComponent();
            NombreJugador = nombreJugador;
            AdministradorDeRecursos = new ResourceManager("DamasChinas.lenguaje.Resources", typeof(MainWindow).Assembly);
            Lenguaje = "en-US";
            PonerTexto();
        }

        public void PonerTexto()
        {
            Cultura = CultureInfo.CreateSpecificCulture(Lenguaje);
            Informacion.Text = AdministradorDeRecursos.GetString("Information", Cultura);
            Nombre.Text = AdministradorDeRecursos.GetString("Name", Cultura);
            Usuario.Text = AdministradorDeRecursos.GetString("User", Cultura);
            Contraseña.Text = AdministradorDeRecursos.GetString("Pass", Cultura);
            actualizarInformacion.Content = AdministradorDeRecursos.GetString("UpdatInfo", Cultura);
            regresarBttn.Content = AdministradorDeRecursos.GetString("Back", Cultura);
            Baja.Content = AdministradorDeRecursos.GetString("Deactivate", Cultura);
            Idioma.Text = AdministradorDeRecursos.GetString("Language", Cultura);
            Esp.Text = AdministradorDeRecursos.GetString("Spanish", Cultura);
            Eng.Text = AdministradorDeRecursos.GetString("English", Cultura);
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Esp_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Lenguaje = "es-MX";
            PonerTexto();
        }

        private void Eng_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Lenguaje = "en-US";
            PonerTexto();
        }

        private void regresarBttn_Click(object sender, RoutedEventArgs e)
        {
            MenuInicio inicio = new MenuInicio(NombreJugador);
            inicio.Show();
            Close();
        }

        private void actualizarInformacion_Click(object sender, RoutedEventArgs e)
        {
            ActualizarInfo actualizar = new ActualizarInfo(NombreJugador);
            actualizar.Show();
            Close();
        }
    }
}
