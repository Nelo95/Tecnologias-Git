﻿using System;
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
    /// Lógica de interacción para MenuInicio.xaml
    /// </summary>
    public partial class MenuInicio : Window
    {
        ResourceManager AdministradorDeRecursos;
        CultureInfo Cultura;
        string Lenguaje;
        String NombreJugador;
        public MenuInicio(string nombreJugador)
        {
            NombreJugador = nombreJugador;
            InitializeComponent();
            AdministradorDeRecursos = new ResourceManager("DamasChinas.lenguaje.Resources", typeof(MenuInicio).Assembly);
            Lenguaje = "en-US";
            PonerTexto();
        }
        public void PonerTexto()
        {
            Cultura = CultureInfo.CreateSpecificCulture(Lenguaje);
            Bienvenido.Text = AdministradorDeRecursos.GetString("Welcome", Cultura);
            IniciarPartida.Content = AdministradorDeRecursos.GetString("Start", Cultura);
            Historial.Content = AdministradorDeRecursos.GetString("Record", Cultura);
            Puntajes.Content = AdministradorDeRecursos.GetString("Score", Cultura);
            Tutorial.Content = AdministradorDeRecursos.GetString("Tuto", Cultura);
            CerrarSesion.Content = AdministradorDeRecursos.GetString("Logout", Cultura);
            Idioma.Text = AdministradorDeRecursos.GetString("Language", Cultura);
            Esp.Text = AdministradorDeRecursos.GetString("Spanish", Cultura);
            Eng.Text = AdministradorDeRecursos.GetString("English", Cultura);
            Cuenta.Content = AdministradorDeRecursos.GetString("Account", Cultura);
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

        private void IniciarPartida_Click(object sender, RoutedEventArgs e)
        {
            Partida match = new Partida(NombreJugador);
            PonerTexto();
            match.Show();
            Close();
        }

        private void Cuenta_Click(object sender, RoutedEventArgs e)
        {
            AdministrarCuenta account = new AdministrarCuenta(NombreJugador);
            PonerTexto();
            account.Show();
            Close();
        }

        private void Historial_Click(object sender, RoutedEventArgs e)
        {
            Historial historia = new Historial(NombreJugador);
            PonerTexto();
            historia.Show();
            Close();
        }


        private void CerrarSesion_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            Close();
        }

        private void Puntajes_Click(object sender, RoutedEventArgs e)
        {
            MejoresPuntajes puntajes = new MejoresPuntajes(NombreJugador);
            puntajes.Show();
            Close();

        }

        private void Tutorial_Click(object sender, RoutedEventArgs e)
        {
            Tutorial tutorial = new Tutorial(NombreJugador);
            tutorial.Show();
            Close();
        }
    }
}
