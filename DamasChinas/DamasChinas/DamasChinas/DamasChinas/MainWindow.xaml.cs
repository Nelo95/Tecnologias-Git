using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DamasChinas
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ResourceManager AdministradorDeRecursos;
        CultureInfo Cultura;
        string Lenguaje;

        public MainWindow()
        {
            InitializeComponent();
            AdministradorDeRecursos = new ResourceManager("DamasChinas.lenguaje.Resources", typeof(MainWindow).Assembly);
            Lenguaje = "en-US";
            PonerTexto();
        }
        //Cambiar el texto de sus respectivos textox,botones
        private void PonerTexto()
        {
            Cultura = CultureInfo.CreateSpecificCulture(Lenguaje);
            Usuario.Text = AdministradorDeRecursos.GetString("User", Cultura);
            Contraseña.Text = AdministradorDeRecursos.GetString("Pass", Cultura);
            Inicio_sesion.Content = AdministradorDeRecursos.GetString("Login", Cultura);
            Idioma.Text = AdministradorDeRecursos.GetString("Language", Cultura);
            Esp.Text = AdministradorDeRecursos.GetString("Spanish", Cultura);
            Eng.Text = AdministradorDeRecursos.GetString("English", Cultura);
            Pregunta.Text = AdministradorDeRecursos.GetString("NotUser", Cultura);
            Registro.Text = AdministradorDeRecursos.GetString("Register", Cultura);

         
        }

        private void Regitrarse_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Registrarse registro = new Registrarse();
            PonerTexto();
            registro.Show();
            Close();
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

        private void Inicio_sesion_Click(object sender, RoutedEventArgs e)
        {
            MenuInicio menu = new MenuInicio();
            PonerTexto();
            menu.Show();
            Close();
        }
    }
}
