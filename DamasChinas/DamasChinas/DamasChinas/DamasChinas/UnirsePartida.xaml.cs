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
    /// Lógica de interacción para UnirsePartida.xaml
    /// </summary>
    public partial class UnirsePartida : Window
    {
        ResourceManager AdministradorDeRecursos;
        CultureInfo Cultura;
        string Lenguaje;

        public UnirsePartida()
        {
            InitializeComponent();
            AdministradorDeRecursos = new ResourceManager("DamasChinas.lenguaje.Resources", typeof(MainWindow).Assembly);
            Lenguaje = "en-US";
            PonerTexto();
        }

        public void PonerTexto()
        {
            Cultura = CultureInfo.CreateSpecificCulture(Lenguaje);
            Filtrar.Text = AdministradorDeRecursos.GetString("Filter", Cultura);
            Volver.Content = AdministradorDeRecursos.GetString("BackTwo", Cultura);
            Partidas.Text = AdministradorDeRecursos.GetString("Games", Cultura);
            Buscar.Content = AdministradorDeRecursos.GetString("SearchTwo", Cultura);
            Unirse.Content = AdministradorDeRecursos.GetString("Join", Cultura);
            Idioma.Text = AdministradorDeRecursos.GetString("Language", Cultura);
            Esp.Text = AdministradorDeRecursos.GetString("Spanish", Cultura);
            Eng.Text = AdministradorDeRecursos.GetString("English", Cultura);
        }
        private void Esp_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Lenguaje = "es-MX";
            PonerTexto();
        }

        private void Eng_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Lenguaje = "en-US";

        }

        private void Volver_Click(object sender, RoutedEventArgs e)
        {
            MenuInicio inicio = new MenuInicio();
            inicio.Show();
            Close();
        }
    }
}
