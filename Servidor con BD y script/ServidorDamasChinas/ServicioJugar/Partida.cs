using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioJugar
{
    public class Partida
    {
        public Dictionary<string, string> Jugadores { set; get; }
        public List<string> JugadoresEnEspera { set; get; }
        public int JugadoresListos { set; get; }
        public bool PartidaIniciada { set; get; }
        public int Turno { set; get; }

        public Partida()
        {
            Jugadores = new Dictionary<string, string>();
            JugadoresEnEspera = new List<string>();
            JugadoresListos = 0;
            PartidaIniciada = false;
            Turno = 0;
        }

        public void Listo()
        {
            JugadoresListos++;
        }

        public void UnirsePartida(string usuario)
        {
            JugadoresEnEspera.Add(usuario);
        }

        public void AsignarColores()
        {
            var tamano = JugadoresEnEspera.Count();
            switch (tamano)
            {
                case 2:
                    Jugadores.Add(JugadoresEnEspera.ElementAt(0), "verde");
                    Jugadores.Add(JugadoresEnEspera.ElementAt(1), "morada");
                    break;
                case 3:

                    Jugadores.Add(JugadoresEnEspera.ElementAt(0), "azul");
                    Jugadores.Add(JugadoresEnEspera.ElementAt(1), "rojo");
                    Jugadores.Add(JugadoresEnEspera.ElementAt(2), "morada");
                    break;
                case 4:
                    Jugadores.Add(JugadoresEnEspera.ElementAt(0), "verde");
                    Jugadores.Add(JugadoresEnEspera.ElementAt(1), "rojo");
                    Jugadores.Add(JugadoresEnEspera.ElementAt(2), "amarillo");
                    Jugadores.Add(JugadoresEnEspera.ElementAt(3), "morada");
                    break;
                case 6:
                    Jugadores.Add(JugadoresEnEspera.ElementAt(0), "verde");
                    Jugadores.Add(JugadoresEnEspera.ElementAt(1), "rojo");
                    Jugadores.Add(JugadoresEnEspera.ElementAt(2), "lavanda");
                    Jugadores.Add(JugadoresEnEspera.ElementAt(3), "morada");
                    Jugadores.Add(JugadoresEnEspera.ElementAt(4), "amarillo");
                    Jugadores.Add(JugadoresEnEspera.ElementAt(5), "azul");
                    break;
            }
        }

        /*public void AvanzarTurno()
        {
            Console.WriteLine("Antes: " + Turno.ToString());
            if(Turno < JugadoresListos)
            {
                Turno++;
            }
            else
            {
                Turno = 0;
            }
            Console.WriteLine("Después: " + Turno.ToString());
        }*/
    }
}
