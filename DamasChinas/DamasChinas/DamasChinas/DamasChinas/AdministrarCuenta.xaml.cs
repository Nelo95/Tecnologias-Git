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
    /// Lógica de interacción para Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        ResourceManager AdministradorDeRecursos;
        CultureInfo Cultura;
        string Lenguaje;

        public Window2()
        {
            InitializeComponent();
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
            actualizarInformacion.Content = AdministradorDeRecursos.GetString("UpdateInfo", Cultura);
            regresarBttn.Content = AdministradorDeRecursos.GetString("Back", Cultura);
            Baja.Content = AdministradorDeRecursos.GetString("Desactivate", Cultura);
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
    }
}
