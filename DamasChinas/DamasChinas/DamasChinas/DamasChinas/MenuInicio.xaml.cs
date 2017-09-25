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
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        ResourceManager AdministradorDeRecursos;
        CultureInfo Cultura;
        string Lenguaje;

        public Window1()
        {
            InitializeComponent();
            AdministradorDeRecursos = new ResourceManager("DamasChinas.lenguaje.Resources", typeof(MainWindow).Assembly);
            Lenguaje = "en-US";
            PonerTexto();
        }
        public void PonerTexto()
        {
            Cultura = CultureInfo.CreateSpecificCulture(Lenguaje);
            Bienvenido.Text = AdministradorDeRecursos.GetString("Welcome", Cultura);
            IniciarPartida.Content = AdministradorDeRecursos.GetString("Start", Cultura);
            Historial.Content = AdministradorDeRecursos.GetString("Records", Cultura);
            Puntajes.Content = AdministradorDeRecursos.GetString("Scores", Cultura);
            BuscarPartida.Content = AdministradorDeRecursos.GetString("Search", Cultura);
            Tutorial.Content = AdministradorDeRecursos.GetString("Tutorial", Cultura);
            CerrarSesion.Content = AdministradorDeRecursos.GetString("Logout", Cultura);
            Idioma.Text = AdministradorDeRecursos.GetString("Language", Cultura);
            Esp.Text = AdministradorDeRecursos.GetString("Spanish", Cultura);
            Eng.Text = AdministradorDeRecursos.GetString("English", Cultura);
        }
        private void Button_Click(object sender, RoutedEventArgs e)
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
