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
    /// Lógica de interacción para InfoActualizada.xaml
    /// </summary>
    public partial class InfoActualizada : Window
    {
        string NombreJugador;
        public InfoActualizada(string nombreJugador)
        {
            InitializeComponent();
            NombreJugador = nombreJugador;
        }

        private void aceptar_Click(object sender, RoutedEventArgs e)
        {
            MenuInicio menu = new MenuInicio(NombreJugador);
            menu.Show();
            Close();
        }
    }
}
