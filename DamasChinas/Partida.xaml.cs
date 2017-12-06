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
using System.Windows.Resources;
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
        //private readonly double y;

        /*void Seleccionado = null;*/

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

        /*private void SeleccionaFicha(object sender, MouseEventArgs e)
        {
            try { Seleccionado.BackColor = Color.Black;}
            catch { }
            
        }*/

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Controls.Button boton = sender as System.Windows.Controls.Button;

            Uri resourceUri = new Uri("recursos/espacioVacio.png", UriKind.Relative);
            StreamResourceInfo streamInfo = System.Windows.Application.GetResourceStream(resourceUri);
            BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
            var brush = new ImageBrush();
            brush.ImageSource = temp;
            boton.Background = brush;
            //var botonPresionado = sender as Button;
            //MessageBox.Show(botonPresionado.Name.ToString());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            System.Windows.Controls.Button boton = sender as System.Windows.Controls.Button;

            Uri resourceUri = new Uri("recursos/espacioVacio.png", UriKind.Relative);
            StreamResourceInfo streamInfo = System.Windows.Application.GetResourceStream(resourceUri);
            BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
            var brush = new ImageBrush();
            brush.ImageSource = temp;
            boton.Background = brush;
        }

        private void Tablero_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var pulsado = sender as Image;
            MessageBox.Show(pulsado.Name.ToString());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        /*private void V1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Control.location = new Point(x, y);
        }*/


        Dictionary<String, Ficha> Tablero = new Dictionary<string, Ficha>();

        public void LlenarTablero()
        {
            Tablero.Add("Y1", new Ficha { boton = Y1, estado="amarillo" });
            Tablero.Add("Y2", new Ficha { boton = Y2, estado = "amarillo" });
            Tablero.Add("Y3", new Ficha { boton = Y3, estado = "amarillo" });
            Tablero.Add("Y4", new Ficha { boton = Y4, estado = "amarillo" });
            Tablero.Add("Y5", new Ficha { boton = Y5, estado = "amarillo" });
            Tablero.Add("Y6", new Ficha { boton = Y6, estado = "amarillo" });
            Tablero.Add("Y7", new Ficha { boton = Y7, estado = "amarillo" });
            Tablero.Add("Y8", new Ficha { boton = Y8, estado = "amarillo" });
            Tablero.Add("Y9", new Ficha { boton = Y9, estado = "amarillo" });
            Tablero.Add("Y10", new Ficha { boton = Y10, estado = "amarillo" });
            Tablero.Add("A1", new Ficha { boton = A1, estado = "azul" });
            Tablero.Add("A2", new Ficha { boton = A2, estado = "azul" });
            Tablero.Add("A3", new Ficha { boton = A3, estado = "azul" });
            Tablero.Add("A4", new Ficha { boton = A4, estado = "azul" });
            Tablero.Add("A5", new Ficha { boton = A5, estado = "azul" });
            Tablero.Add("A6", new Ficha { boton = A6, estado = "azul" });
            Tablero.Add("A7", new Ficha { boton = A7, estado = "azul" });
            Tablero.Add("A8", new Ficha { boton = A8, estado = "azul" });
            Tablero.Add("A9", new Ficha { boton = A9, estado = "azul" });
            Tablero.Add("A10", new Ficha { boton = A10, estado = "azul" });
            Tablero.Add("L1", new Ficha { boton = L1, estado = "lavanda" });
            Tablero.Add("L2", new Ficha { boton = L2, estado = "lavanda" });
            Tablero.Add("L3", new Ficha { boton = L3, estado = "lavanda" });
            Tablero.Add("L4", new Ficha { boton = L4, estado = "lavanda" });
            Tablero.Add("L5", new Ficha { boton = L5, estado = "lavanda" });
            Tablero.Add("L6", new Ficha { boton = L6, estado = "lavanda" });
            Tablero.Add("L7", new Ficha { boton = L7, estado = "lavanda" });
            Tablero.Add("L8", new Ficha { boton = L8, estado = "lavanda" });
            Tablero.Add("L9", new Ficha { boton = L9, estado = "lavanda" });
            Tablero.Add("L10", new Ficha { boton = L10, estado = "lavanda" });
            Tablero.Add("M1", new Ficha { boton = M1, estado = "morado" });
            Tablero.Add("M2", new Ficha { boton = M2, estado = "morado" });
            Tablero.Add("M3", new Ficha { boton = M3, estado = "morado" });
            Tablero.Add("M4", new Ficha { boton = M4, estado = "morado" });
            Tablero.Add("M5", new Ficha { boton = M5, estado = "morado" });
            Tablero.Add("M6", new Ficha { boton = M6, estado = "morado" });
            Tablero.Add("M7", new Ficha { boton = M7, estado = "morado" });
            Tablero.Add("M8", new Ficha { boton = M8, estado = "morado" });
            Tablero.Add("M9", new Ficha { boton = M9, estado = "morado" });
            Tablero.Add("M10", new Ficha { boton = M10, estado = "morado" });
            Tablero.Add("V1", new Ficha { boton = V1, estado = "verde" });
            Tablero.Add("V2", new Ficha { boton = V2, estado = "verde" });
            Tablero.Add("V3", new Ficha { boton = V3, estado = "verde" });
            Tablero.Add("V4", new Ficha { boton = V4, estado = "verde" });
            Tablero.Add("V5", new Ficha { boton = V5, estado = "verde" });
            Tablero.Add("V6", new Ficha { boton = V6, estado = "verde" });
            Tablero.Add("V7", new Ficha { boton = V7, estado = "verde" });
            Tablero.Add("V8", new Ficha { boton = V8, estado = "verde" });
            Tablero.Add("V9", new Ficha { boton = V9, estado = "verde" });
            Tablero.Add("V10", new Ficha { boton = V10, estado = "verde" });
            Tablero.Add("R1", new Ficha { boton = R1, estado = "rojo" });
            Tablero.Add("R2", new Ficha { boton = R2, estado = "rojo" });
            Tablero.Add("R3", new Ficha { boton = R3, estado = "rojo" });
            Tablero.Add("R4", new Ficha { boton = R4, estado = "rojo" });
            Tablero.Add("R5", new Ficha { boton = R5, estado = "rojo" });
            Tablero.Add("R6", new Ficha { boton = R6, estado = "rojo" });
            Tablero.Add("R7", new Ficha { boton = R7, estado = "rojo" });
            Tablero.Add("R8", new Ficha { boton = R8, estado = "rojo" });
            Tablero.Add("R9", new Ficha { boton = R9, estado = "rojo" });
            Tablero.Add("R10", new Ficha { boton = R10, estado = "rojo" });
            Tablero.Add("N1", new Ficha { boton = N1, estado = "vacio" });
            Tablero.Add("N2", new Ficha { boton = N2, estado = "vacio" });
            Tablero.Add("N3", new Ficha { boton = N3, estado = "vacio" });
            Tablero.Add("N4", new Ficha { boton = N4, estado = "vacio" });
            Tablero.Add("N5", new Ficha { boton = N5, estado = "vacio" });
            Tablero.Add("N6", new Ficha { boton = N6, estado = "vacio" });
            Tablero.Add("N7", new Ficha { boton = N7, estado = "vacio" });
            Tablero.Add("N8", new Ficha { boton = N8, estado = "vacio" });
            Tablero.Add("N9", new Ficha { boton = N9, estado = "vacio" });
            Tablero.Add("N10", new Ficha { boton = N10, estado = "vacio" });
            Tablero.Add("N11", new Ficha { boton = N11, estado = "vacio" });
            Tablero.Add("N12", new Ficha { boton = N12, estado = "vacio" });
            Tablero.Add("N13", new Ficha { boton = N13, estado = "vacio" });
            Tablero.Add("N14", new Ficha { boton = N14, estado = "vacio" });
            Tablero.Add("N15", new Ficha { boton = N15, estado = "vacio" });
            Tablero.Add("N16", new Ficha { boton = N16, estado = "vacio" });
            Tablero.Add("N17", new Ficha { boton = N17, estado = "vacio" });
            Tablero.Add("N18", new Ficha { boton = N18, estado = "vacio" });
            Tablero.Add("N19", new Ficha { boton = N19, estado = "vacio" });
            Tablero.Add("N20", new Ficha { boton = N20, estado = "vacio" });
            Tablero.Add("N21", new Ficha { boton = N21, estado = "vacio" });
            Tablero.Add("N22", new Ficha { boton = N22, estado = "vacio" });
            Tablero.Add("N23", new Ficha { boton = N23, estado = "vacio" });
            Tablero.Add("N24", new Ficha { boton = N24, estado = "vacio" });
            Tablero.Add("N25", new Ficha { boton = N25, estado = "vacio" });
            Tablero.Add("N26", new Ficha { boton = N26, estado = "vacio" });
            Tablero.Add("N27", new Ficha { boton = N27, estado = "vacio" });
            Tablero.Add("N28", new Ficha { boton = N28, estado = "vacio" });
            Tablero.Add("N29", new Ficha { boton = N29, estado = "vacio" });
            Tablero.Add("N30", new Ficha { boton = N30, estado = "vacio" });
            Tablero.Add("N31", new Ficha { boton = N31, estado = "vacio" });
            Tablero.Add("N32", new Ficha { boton = N32, estado = "vacio" });
            Tablero.Add("N33", new Ficha { boton = N33, estado = "vacio" });
            Tablero.Add("N34", new Ficha { boton = N34, estado = "vacio" });
            Tablero.Add("N35", new Ficha { boton = N35, estado = "vacio" });
            Tablero.Add("N36", new Ficha { boton = N36, estado = "vacio" });
            Tablero.Add("N37", new Ficha { boton = N37, estado = "vacio" });
            Tablero.Add("N38", new Ficha { boton = N38, estado = "vacio" });
            Tablero.Add("N39", new Ficha { boton = N39, estado = "vacio" });
            Tablero.Add("N40", new Ficha { boton = N40, estado = "vacio" });
            Tablero.Add("N41", new Ficha { boton = N41, estado = "vacio" });
            Tablero.Add("N42", new Ficha { boton = N42, estado = "vacio" });
            Tablero.Add("N43", new Ficha { boton = N43, estado = "vacio" });
            Tablero.Add("N44", new Ficha { boton = N44, estado = "vacio" });
            Tablero.Add("N45", new Ficha { boton = N45, estado = "vacio" });
            Tablero.Add("N46", new Ficha { boton = N46, estado = "vacio" });
            Tablero.Add("N47", new Ficha { boton = N47, estado = "vacio" });
            Tablero.Add("N48", new Ficha { boton = N48, estado = "vacio" });
            Tablero.Add("N49", new Ficha { boton = N49, estado = "vacio" });
            Tablero.Add("N50", new Ficha { boton = N50, estado = "vacio" });
            Tablero.Add("N51", new Ficha { boton = N51, estado = "vacio" });
            Tablero.Add("N52", new Ficha { boton = N52, estado = "vacio" });
            Tablero.Add("N53", new Ficha { boton = N53, estado = "vacio" });
            Tablero.Add("N54", new Ficha { boton = N54, estado = "vacio" });
            Tablero.Add("N55", new Ficha { boton = N55, estado = "vacio" });
            Tablero.Add("N56", new Ficha { boton = N56, estado = "vacio" });
            Tablero.Add("N57", new Ficha { boton = N57, estado = "vacio" });
            Tablero.Add("N58", new Ficha { boton = N58, estado = "vacio" });
            Tablero.Add("N59", new Ficha { boton = N59, estado = "vacio" });
            Tablero.Add("N60", new Ficha { boton = N60, estado = "vacio" });
            Tablero.Add("N61", new Ficha { boton = N61, estado = "vacio" });
        }

        List<Tuple<String, String>> Adyacentes = new List<Tuple<string, string>>
        {
            new Tuple<string, string>("A1", "A2"),
            new Tuple<string, string>("A1", "A5"),
            new Tuple<string, string>("A2", "A3"),
            new Tuple<string, string>("A2", "A6"),
            new Tuple<string, string>("A3", "A4"),
            new Tuple<string, string>("A3", "A7"),
            new Tuple<string, string>("A4", "N1"),
            new Tuple<string, string>("A4", "N6"),
            new Tuple<string, string>("A5", "A6"),
            new Tuple<string, string>("A5", "A8"),
            new Tuple<string, string>("A6", "A7"),
            new Tuple<string, string>("A6", "A9"),
            new Tuple<string, string>("A7", "N6"),
            new Tuple<string, string>("A7", "N12"),
            new Tuple<string, string>("A8", "A9"),
            new Tuple<string, string>("A8", "A10"),
            new Tuple<string, string>("A9", "N12"),
            new Tuple<string, string>("A9", "N19"),
            new Tuple<string, string>("A10", "N19"),
            new Tuple<string, string>("A10", "N27"),
            new Tuple<string, string>("V1", "V2"),
            new Tuple<string, string>("V1", "V3"),
            new Tuple<string, string>("V2", "V4"),
            new Tuple<string, string>("V2", "V5"),
            new Tuple<string, string>("V3", "V5"),
            new Tuple<string, string>("V3", "V6"),
            new Tuple<string, string>("V4", "V7"),
            new Tuple<string, string>("V4", "V8"),
            new Tuple<string, string>("V5", "V8"),
            new Tuple<string, string>("V5", "V9"),
            new Tuple<string, string>("V6", "V9"),
            new Tuple<string, string>("V6", "V10"),
            new Tuple<string, string>("V7", "N1"),
            new Tuple<string, string>("V7", "N2"),
            new Tuple<string, string>("V8", "N2"),
            new Tuple<string, string>("V8", "N3"),
            new Tuple<string, string>("V9", "N3"),
            new Tuple<string, string>("V9", "N4"),
            new Tuple<string, string>("V10", "N4"),
            new Tuple<string, string>("V10", "N5"),
            new Tuple<string, string>("R1", "N5"),
            new Tuple<string, string>("R1", "N11"),
            new Tuple<string, string>("R2", "R1"),
            new Tuple<string, string>("R2", "R5"),
            new Tuple<string, string>("R3", "R2"),
            new Tuple<string, string>("R3", "R5"),
            new Tuple<string, string>("R4", "R3"),
            new Tuple<string, string>("R4", "R7"),
            new Tuple<string, string>("R5", "N11"),
            new Tuple<string, string>("R5", "N18"),
            new Tuple<string, string>("R6", "R5"),
            new Tuple<string, string>("R6", "R8"),
            new Tuple<string, string>("R6", "R5"),
            new Tuple<string, string>("R7", "R6"),
            new Tuple<string, string>("R7", "R9"),
            new Tuple<string, string>("R8", "N18"),
            new Tuple<string, string>("R8", "N26"),
            new Tuple<string, string>("R9", "R8"),
            new Tuple<string, string>("R9", "R10"),
            new Tuple<string, string>("R10", "N26"),
            new Tuple<string, string>("R10", "N35"),
            new Tuple<string, string>("Y1", "N27"),
            new Tuple<string, string>("Y1", "N36"),
            new Tuple<string, string>("Y2", "Y1"),
            new Tuple<string, string>("Y2", "Y3"),
            new Tuple<string, string>("Y3", "N36"),
            new Tuple<string, string>("Y3", "N44"),
            new Tuple<string, string>("Y4", "Y2"),
            new Tuple<string, string>("Y4", "Y5"),
            new Tuple<string, string>("Y5", "Y3"),
            new Tuple<string, string>("Y5", "Y6"),
            new Tuple<string, string>("Y6", "N44"),
            new Tuple<string, string>("Y6", "N51"),
            new Tuple<string, string>("Y7", "Y4"),
            new Tuple<string, string>("Y7", "Y8"),
            new Tuple<string, string>("Y8", "Y5"),
            new Tuple<string, string>("Y8", "Y9"),
            new Tuple<string, string>("Y9", "Y6"),
            new Tuple<string, string>("Y9", "Y10"),
            new Tuple<string, string>("Y10", "N51"),
            new Tuple<string, string>("Y10", "N57"),
            new Tuple<string, string>("L1", "N35"),
            new Tuple<string, string>("L1", "N43"),
            new Tuple<string, string>("L2", "N43"),
            new Tuple<string, string>("L2", "N50"),
            new Tuple<string, string>("L3", "L1"),
            new Tuple<string, string>("L3", "L2"),
            new Tuple<string, string>("L4", "N50"),
            new Tuple<string, string>("L4", "N56"),
            new Tuple<string, string>("L5", "L2"),
            new Tuple<string, string>("L5", "L4"),
            new Tuple<string, string>("L6", "L3"),
            new Tuple<string, string>("L6", "L5"),
            new Tuple<string, string>("L7", "N56"),
            new Tuple<string, string>("L7", "N61"),
            new Tuple<string, string>("L8", "L4"),
            new Tuple<string, string>("L8", "L7"),
            new Tuple<string, string>("L9", "L5"),
            new Tuple<string, string>("L9", "L8"),
            new Tuple<string, string>("L10", "L6"),
            new Tuple<string, string>("L10", "L9"),
            new Tuple<string, string>("M1", "N57"),
            new Tuple<string, string>("M1", "N58"),
            new Tuple<string, string>("M2", "N58"),
            new Tuple<string, string>("M2", "N59"),
            new Tuple<string, string>("M3", "N59"),
            new Tuple<string, string>("M3", "N60"),
            new Tuple<string, string>("M4", "N60"),
            new Tuple<string, string>("M4", "N61"),
            new Tuple<string, string>("M5", "M1"),
            new Tuple<string, string>("M5", "M2"),
            new Tuple<string, string>("M6", "M2"),
            new Tuple<string, string>("M6", "M3"),
            new Tuple<string, string>("M7", "M3"),
            new Tuple<string, string>("M7", "M4"),
            new Tuple<string, string>("M8", "M5"),
            new Tuple<string, string>("M8", "M6"),
            new Tuple<string, string>("M9", "M6"),
            new Tuple<string, string>("M9", "M7"),
            new Tuple<string, string>("M10", "M8"),
            new Tuple<string, string>("M10", "M9"),
            new Tuple<string, string>("N1", "N6"),
            new Tuple<string, string>("N1", "N7"),
            new Tuple<string, string>("N2", "N7"),
            new Tuple<string, string>("N2", "N8"),
            new Tuple<string, string>("N3", "N8"),
            new Tuple<string, string>("N3", "N9"),
            new Tuple<string, string>("N4", "N9"),
            new Tuple<string, string>("N4", "N10"),
            new Tuple<string, string>("N5", "N10"),
            new Tuple<string, string>("N5", "N11"),
            new Tuple<string, string>("N6", "N12"),
            new Tuple<string, string>("N6", "N13"),
            new Tuple<string, string>("N7", "N13"),
            new Tuple<string, string>("N7", "N14"),
            new Tuple<string, string>("N8", "N14"),
            new Tuple<string, string>("N8", "N15"),
            new Tuple<string, string>("N9", "N15"),
            new Tuple<string, string>("N9", "N16"),
            new Tuple<string, string>("N10", "N16"),
            new Tuple<string, string>("N10", "N17"),
            new Tuple<string, string>("N11", "N17"),
            new Tuple<string, string>("N11", "N18"),
            new Tuple<string, string>("N12", "N19"),
            new Tuple<string, string>("N12", "N20"),
            new Tuple<string, string>("N13", "N20"),
            new Tuple<string, string>("N13", "N21"),
            new Tuple<string, string>("N14", "N21"),
            new Tuple<string, string>("N14", "N22"),
            new Tuple<string, string>("N15", "N22"),
            new Tuple<string, string>("N15", "N23"),
            new Tuple<string, string>("N16", "N23"),
            new Tuple<string, string>("N16", "N24"),
            new Tuple<string, string>("N17", "N24"),
            new Tuple<string, string>("N17", "N25"),
            new Tuple<string, string>("N18", "N25"),
            new Tuple<string, string>("N18", "N26"),
            new Tuple<string, string>("N19", "N27"),
            new Tuple<string, string>("N19", "N28"),
            new Tuple<string, string>("N20", "N28"),
            new Tuple<string, string>("N20", "N29"),
            new Tuple<string, string>("N21", "N29"),
            new Tuple<string, string>("N21", "N30"),
            new Tuple<string, string>("N22", "N30"),
            new Tuple<string, string>("N22", "N31"),
            new Tuple<string, string>("N23", "N31"),
            new Tuple<string, string>("N23", "N32"),
            new Tuple<string, string>("N24", "N32"),
            new Tuple<string, string>("N24", "N33"),
            new Tuple<string, string>("N25", "N33"),
            new Tuple<string, string>("N25", "N34"),
            new Tuple<string, string>("N26", "N34"),
            new Tuple<string, string>("N26", "N35"),
            new Tuple<string, string>("N27", "Y1"),
            new Tuple<string, string>("N27", "N36"),
            new Tuple<string, string>("N28", "N36"),
            new Tuple<string, string>("N28", "N37"),
            new Tuple<string, string>("N29", "N37"),
            new Tuple<string, string>("N29", "N38"),
            new Tuple<string, string>("N30", "N38"),
            new Tuple<string, string>("N30", "N39"),
            new Tuple<string, string>("N31", "N39"),
            new Tuple<string, string>("N31", "N40"),
            new Tuple<string, string>("N32", "N40"),
            new Tuple<string, string>("N32", "N41"),
            new Tuple<string, string>("N33", "N41"),
            new Tuple<string, string>("N33", "N42"),
            new Tuple<string, string>("N34", "N42"),
            new Tuple<string, string>("N34", "N43"),
            new Tuple<string, string>("N35", "N43"),
            new Tuple<string, string>("N35", "L1"),
            new Tuple<string, string>("N36", "Y3"),
            new Tuple<string, string>("N36", "N44"),
            new Tuple<string, string>("N37", "N44"),
            new Tuple<string, string>("N37", "N45"),
            new Tuple<string, string>("N38", "N45"),
            new Tuple<string, string>("N38", "N46"),
            new Tuple<string, string>("N39", "N46"),
            new Tuple<string, string>("N39", "N47"),
            new Tuple<string, string>("N40", "N47"),
            new Tuple<string, string>("N40", "N48"),
            new Tuple<string, string>("N41", "N48"),
            new Tuple<string, string>("N41", "N49"),
            new Tuple<string, string>("N42", "N49"),
            new Tuple<string, string>("N42", "N50"),
            new Tuple<string, string>("N43", "N50"),
            new Tuple<string, string>("N43", "L2"),
            new Tuple<string, string>("N44", "Y6"),
            new Tuple<string, string>("N44", "N51"),
            new Tuple<string, string>("N45", "N51"),
            new Tuple<string, string>("N45", "N52"),
            new Tuple<string, string>("N46", "N52"),
            new Tuple<string, string>("N46", "N53"),
            new Tuple<string, string>("N47", "N53"),
            new Tuple<string, string>("N47", "N54"),
            new Tuple<string, string>("N48", "N54"),
            new Tuple<string, string>("N48", "N55"),
            new Tuple<string, string>("N49", "N55"),
            new Tuple<string, string>("N49", "N56"),
            new Tuple<string, string>("N50", "N56"),
            new Tuple<string, string>("N50", "L4"),
            new Tuple<string, string>("N51", "Y10"),
            new Tuple<string, string>("N51", "N57"),
            new Tuple<string, string>("N52", "N57"),
            new Tuple<string, string>("N52", "N58"),
            new Tuple<string, string>("N53", "N58"),
            new Tuple<string, string>("N53", "N59"),
            new Tuple<string, string>("N54", "N59"),
            new Tuple<string, string>("N54", "N60"),
            new Tuple<string, string>("N55", "N60"),
            new Tuple<string, string>("N55", "N61"),
            new Tuple<string, string>("N56", "N61"),
            new Tuple<string, string>("N56", "L7"),
            new Tuple<string, string>("N57", "M1"),
            new Tuple<string, string>("N58", "M1"),
            new Tuple<string, string>("N58", "M2"),
            new Tuple<string, string>("N59", "M2"),
            new Tuple<string, string>("N59", "M3"),
            new Tuple<string, string>("N60", "M3"),
            new Tuple<string, string>("N60", "M4"),
            new Tuple<string, string>("N61", "M4"),
        };

        public bool EsAdyacente(String casilla1, String casilla2)
        {
            var coincidenciasCasilla1 = (from a in Adyacentes where a.Item1 == casilla1 || a.Item2 == casilla1 select a);
            var coincidenciasCasilla2 = (from c in coincidenciasCasilla1 where c.Item1 == casilla2 || c.Item2 == casilla2 select c).Count();
            if(coincidenciasCasilla2 == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
