using Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.ServiceModel;
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
        public ChannelFactory<IServicioCuenta> canal = new ChannelFactory<IServicioCuenta>("ServicioCuentaEndpoint");
        public IServicioCuenta proxy;

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
            proxy = canal.CreateChannel();

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
            var usuario = FieldUsuario.Text;
            var contra = FieldContrasenia.Text;
            var resultado = proxy.IniciarSesion(usuario, Sha256(contra));
            MessageBox.Show(resultado);
        }

        public string Sha256(string contrasena)
        {
            System.Security.Cryptography.SHA256Managed crypt = new System.Security.Cryptography.SHA256Managed();
            StringBuilder hash = new StringBuilder();
            byte[] crypto = crypt.ComputeHash(Encoding.UTF8.GetBytes(contrasena), 0, Encoding.UTF8.GetByteCount(contrasena));
            foreach (byte theByte in crypto)
            {
                hash.Append(theByte.ToString("x2"));
            }
            return hash.ToString();
        }
    }
}
