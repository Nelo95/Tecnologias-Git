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
    /// Lógica de interacción para Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        ResourceManager AdministradorDeRecursos;
        CultureInfo Cultura;
        string Lenguaje;

        public Window3()
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
            Volver.Content = AdministradorDeRecursos.GetString("Back2", Cultura);
            Partidas.Text = AdministradorDeRecursos.GetString("Games",Cultura);
            Buscar.Content = AdministradorDeRecursos.GetString("Search2", Cultura);
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
    }
