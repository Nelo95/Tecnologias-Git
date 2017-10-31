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
    /// Lógica de interacción para Tutorial.xaml
    /// </summary>
    public partial class Tutorial : Window

    {
        ResourceManager AdministradorDeRecursos;
        CultureInfo Cultura;
        string Lenguaje;

        public Tutorial()
        {
            InitializeComponent();
            AdministradorDeRecursos = new ResourceManager("DamasChinas.lenguaje.Resources", typeof(MainWindow).Assembly);
            Lenguaje = "en-US";
            PonerTexto();
        }

        public void PonerTexto()
        {
            Cultura = CultureInfo.CreateSpecificCulture(Lenguaje);
            objetivo.Text = AdministradorDeRecursos.GetString("Objective", Cultura);
            reglas.Text = AdministradorDeRecursos.GetString("Rules",Cultura);
            movimientos.Text = AdministradorDeRecursos.GetString("Moves", Cultura);
            puntos.Text = AdministradorDeRecursos.GetString("Points",Cultura);
            Volver.Content = AdministradorDeRecursos.GetString("BackTwo", Cultura);
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
            PonerTexto();
        }
        private void Volver_Click(object sender, RoutedEventArgs e)
        {
            MenuInicio inicio = new MenuInicio();
            inicio.Show();
            Close();
        }
    }
}
