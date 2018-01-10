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
using DamasChinas.Datos;

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
        private int PonerTexto()
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

            return 1;
        }

        //Apartado para registrarse
        private void Regitrarse_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Registrarse registro = new Registrarse();
            PonerTexto();
            registro.Show();
            Close();
        }

        //Apartado para cambiar el idioma a Español
        private void Esp_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Lenguaje = "es-MX";
            PonerTexto();
        }

        //Apartado para cambiar el idioma a Ingles
        private void Eng_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Lenguaje = "en-US";
            PonerTexto();
        }

        //Método para comprobar si hay campos vacíos
        public bool HayCamposNulos(string usuario, string contrasena)
        {
            //Verifica que la información no sea vacía
            if (usuario.Equals("") || contrasena.Equals(""))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Método de evento donde se manda a llamar el método Iniciar Sesion
        private void Inicio_sesion_Click(object sender, RoutedEventArgs e)
        {
            PonerTexto();
            var nombreJugador = FieldUsuario.Text.Trim();
            var contraseniaJugador = FieldContrasenia.Password.Trim();

            if (!HayCamposNulos(nombreJugador, contraseniaJugador))
            {
                try
                {
                    Usuarios usuario = new Usuarios();
                    usuario.Usuario = nombreJugador;
                    usuario.Contrasenia = Sha256(contraseniaJugador);
                    int resultado = UsuariosDAO.RegistrarUsuario(usuario);
                    if (resultado > 0)
                    {
                        MenuInicio menu = new MenuInicio(nombreJugador);
                        menu.Show();
                        Close();
                    }
                    else
                    {
                        MostrarMensaje("JugadorNoRegistrado");
                    }
                }catch (TimeoutException)
                {
                    MostrarMensaje("ProblemaConexion");
                }
            }
            else
            {
                MostrarMensaje("CamposVacíos");
            }
        }
   
        // Método para mostrar mensajes 
        public string MostrarMensaje(string causa)
        {
            //Se crea el mensaje en el idioma que contiene esta ventana
            var mensaje = AdministradorDeRecursos.GetString(causa, Cultura);
            Cursor = Cursors.Arrow;
            //Se muestra el mensaje
            MessageBox.Show(mensaje);
            return causa;
        }

        //Método para cifrar contraseñas
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


        private void FieldUsuario_TextInpunt(object sender, TextCompositionEventArgs e)
        {
            int ascci = Convert.ToInt32(Convert.ToChar(e.Text));
            if((ascci >= 65 && ascci <= 90 || ascci >= 97 && ascci <= 122) && (ascci >= 48 && ascci <= 57))
                e.Handled = false;
            else

                e.Handled = true;
        }
    }
}
