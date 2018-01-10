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

namespace DamasChinas
{
    /// <summary>
    /// Lógica de interacción para ConfirmaciónActualizacion.xaml
    /// </summary>
    public partial class ConfirmaciónActualizacion : Window
    {
        string NombreJugador;
        public ConfirmaciónActualizacion(string nombreJugador)
        {
            InitializeComponent();
            NombreJugador = nombreJugador;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MenuInicio turnback = new MenuInicio(NombreJugador);
            turnback.Show();
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            InfoActualizada info = new InfoActualizada(NombreJugador);
            info.Show();
            Close();
        }
    }
}
