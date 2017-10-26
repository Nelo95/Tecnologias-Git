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
using System.Windows.Shapes;

namespace DamasChinas
{
    /// <summary>
    /// Lógica de interacción para Partida.xaml
    /// </summary>
    public partial class Partida : Window
    {
        ResourceManager AdministradorDeRecursos;
        CultureInfo Cultura;
        string Lenguaje;

        public Partida()
        {
            InitializeComponent();
            AdministradorDeRecursos = new ResourceManager("DamasChinas.lenguaje.Resources", typeof(Partida).Assembly);
            Lenguaje = "en-US";
            PonerTexto();
        }

        public void PonerTexto()
        {
            Cultura = CultureInfo.CreateSpecificCulture(Lenguaje);
            Puntuacion.Text = AdministradorDeRecursos.GetString("UScore", Cultura);
            Jugadores.Text = AdministradorDeRecursos.GetString("Players", Cultura);
            Salir.Content = AdministradorDeRecursos.GetString("Exit", Cultura);

        }

            private void Salir_Click(object sender, RoutedEventArgs e)
        {
            MenuInicio inicio = new MenuInicio();
            inicio.Show();
            Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var botonPresionado = sender as Button;
            MessageBox.Show(botonPresionado.Name.ToString());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Tablero_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var pulsado = sender as Image;
            MessageBox.Show(pulsado.Name.ToString());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }
    }
}
