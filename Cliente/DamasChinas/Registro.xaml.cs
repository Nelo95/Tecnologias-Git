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
using System.ServiceModel;
using Interfaces;
using DamasChinas.Datos;

namespace DamasChinas
{
    /// <summary>
    /// Lógica de interacción para Registrarse.xaml
    /// </summary>
    public partial class Registrarse : Window
    {
        ResourceManager AdministradorDeRecursos;
        CultureInfo Cultura;
        string Lenguaje;

        public Registrarse()
        {
            InitializeComponent();
            AdministradorDeRecursos = new ResourceManager("DamasChinas.lenguaje.Resources", typeof(MainWindow).Assembly);
            Lenguaje = "en-US";
            PonerTexto();

        }

        //Cambiar el texto de sus respectivos textox,botones
        public int PonerTexto()
        {
            Cultura = CultureInfo.CreateSpecificCulture(Lenguaje);
            Info.Text = AdministradorDeRecursos.GetString("Info", Cultura);
            Nombre.Text = AdministradorDeRecursos.GetString("Name",Cultura);
            Usuario.Text = AdministradorDeRecursos.GetString("User", Cultura);
            Contraseña.Text = AdministradorDeRecursos.GetString("Pass",Cultura);
            crearCuentaBttn.Content = AdministradorDeRecursos.GetString("Create",Cultura);
            regresarBttn.Content = AdministradorDeRecursos.GetString("Back", Cultura);
            Idioma.Text = AdministradorDeRecursos.GetString("Language", Cultura);
            Esp.Text = AdministradorDeRecursos.GetString("Spanish", Cultura);
            Eng.Text = AdministradorDeRecursos.GetString("English", Cultura);
            return 1;
        }
        private void TxtUsuario_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        //Evento donde se manda a llamar el método RegistrarUsuario
        private void CrearCuenta_Click(object sender, RoutedEventArgs e)
        {
            var fieldNombre = txtNombre.Text.Trim();
            var fieldUsuario = txtUsuario.Text.Trim();
            var fieldContrasenia = txtPass.Password.Trim();
            var resultadoValidacion = ValidarInformacion(fieldNombre, fieldUsuario, fieldContrasenia);
            if (resultadoValidacion.Equals("InformacionValida"))
            {
                try
                {


                    Usuarios usuario = new Usuarios();
                    usuario.Nombre = fieldNombre;
                    usuario.Usuario = fieldUsuario;
                    usuario.Contrasenia = Sha256(fieldContrasenia);
                    int resultado = UsuariosDAO.RegistrarUsuario(usuario);
                    if (resultado > 0)
                    {
                        CuentaCreada cuenta = new CuentaCreada();
                        cuenta.Show();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("ErrorRegistro");
                    }
                }
                catch (TimeoutException)
                {
                    MostrarMensaje("ProblemaConexion");
                }
            }
            else
            {
                MostrarMensaje(resultadoValidacion);
            }
        }

        //Método para validar que la información ingresada sea válida
        public string ValidarInformacion(string nombre, string usuario,
                                       string contrasena)
        {
            //Verifica que la información no sea nula
            if (!nombre.Equals("") && !usuario.Equals("") && !contrasena.Equals(""))
            {
                return ("InformacionValida");
               
            }
            else
            {
                //Si hay información vacía regresa retroalimentación para el usuario
                return ("CamposVacios");
            }
        }
        //Método para mostrar mensajes
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
        private void RegresarBttn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
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
    }
}
