using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServicioJugar
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioJugar" en el código y en el archivo de configuración a la vez.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single, ConcurrencyMode =ConcurrencyMode.Multiple)]
    public class ServicioJugar : IServicioJugar
    {
        public Dictionary<string, ICallbackJugar> JugadoresConectados = new Dictionary<string, ICallbackJugar>();
        public Dictionary<int, Partida> Partidas = new Dictionary<int, Partida>();
        public int NumeroDePartidas = 0;

        public int Conectar(string jugador)
        {
            ICallbackJugar contexto = OperationContext.Current.GetCallbackChannel<ICallbackJugar>();
            if (!JugadoresConectados.ContainsKey(jugador))
            {
                JugadoresConectados.Add(jugador, contexto);
            }
            else
            {
                JugadoresConectados.Remove(jugador);
                JugadoresConectados.Add(jugador, contexto);
            }
            var idPartida = AsignarPartida(jugador);
            return idPartida;
        }

        public void Desconectar(int idPartida, string jugador)
        {
            var partidaDondeEstaba = (from p in Partidas
                                      where p.Key == idPartida
                                      select p.Value).First();
            partidaDondeEstaba.Jugadores.Remove(jugador);
            if (partidaDondeEstaba.Jugadores.Count == 1)
            {
                var jugadorRestante = partidaDondeEstaba.Jugadores.Keys.First();
                var callbackJugadorRestante = (from j in JugadoresConectados
                                               where j.Key.Equals(jugadorRestante)
                                               select j.Value).First();
                callbackJugadorRestante.NotificarJugadoresAbandonaron();
                callbackJugadorRestante.RecibirExpulsion();
                Partidas.Remove(idPartida);
                JugadoresConectados.Remove(jugadorRestante);
            }
            JugadoresConectados.Remove(jugador);
        }

        public void JugadorListo(int idPartida)
        {
            var partida = (from p in Partidas
                           where idPartida == p.Key
                           select p).Single();
            partida.Value.Listo();
            if (partida.Value.JugadoresListos == partida.Value.JugadoresEnEspera.Count() && 
                partida.Value.JugadoresListos != 5 &&
                partida.Value.JugadoresListos > 1)
            {
                partida.Value.PartidaIniciada = true;
                partida.Value.AsignarColores();
                MandarTurno(idPartida);
                //MandarInformacionPartida(partida.Key, partida.Value);
            }
        }

        public void MandarTurno(int idPartida)
        {
            var partida = (from p in Partidas
                          where idPartida == p.Key
                          select p).Single();
            partida.Value.Turno = partida.Value.Turno+1;
            if (partida.Value.Turno >= partida.Value.Jugadores.Count())
            {
                partida.Value.Turno = 0;
            }
            Console.WriteLine("Es turno de:" + partida.Value.Turno.ToString());
            var jugadorTurno = partida.Value.Jugadores.ElementAt(partida.Value.Turno).Key;
            var callbackJugador = (from j in JugadoresConectados
                                   where j.Key.Equals(jugadorTurno)
                                   select j).First();
            callbackJugador.Value.RecibirTurno();
            /*if(partida.Value.Turno < partida.Value.Jugadores.Count())
            {
                partida.Value.Turno = partida.Value.Turno + 1;
            }
            else
            {
                partida.Value.Turno = 0;
            }*/
        }

        public void Mover(int sala, string jugador, string posicionInicial, string colorInicial, string posicionFinal, string colorFinal)
        {
            var partida = (from p in Partidas
                           where p.Key == sala
                           select p.Value).First();
            var listaJugadores = (from j in partida.Jugadores
                                  where !j.Key.Equals(jugador)
                                  select j.Key).ToList();
            foreach (var jug in listaJugadores)
            {
                var callback = (from j in JugadoresConectados
                                where j.Key.Equals(jug)
                                select j.Value).First();
                callback.RecibirMovimiento(posicionInicial, colorInicial, posicionFinal, colorFinal);
            }
            MandarTurno(sala);
        }

        public bool HayPartidaDisponible()
        {
            var numeroDePartidasDisponibles = (from p in Partidas
                                               where !p.Value.PartidaIniciada 
                                               || p.Value.JugadoresEnEspera.Count > 6
                                               select p).Count();
            if (numeroDePartidasDisponibles > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void MandarInformacionPartida(int idPartida, Partida partida)
        {

            var jugadoresConColor = partida.Jugadores;
            var nombreJugadores = jugadoresConColor.Keys.ToList();
            foreach (var jugador in jugadoresConColor)
            {
                var callbackJugador = (from j in JugadoresConectados
                                       where j.Key.Equals(jugador.Key)
                                       select j).First();
                callbackJugador.Value.RecibirColor(jugador.Value);
                //callbackJugador.Value.RecibirJugadores(nombreJugadores);
            }
            foreach (var jugador in jugadoresConColor)
            {
                var callbackJugador = (from j in JugadoresConectados
                                       where j.Key.Equals(jugador.Key)
                                       select j).First();
                //callbackJugador.Value.RecibirColor(jugador.Value);
                callbackJugador.Value.RecibirJugadores(nombreJugadores);
            }
        }

        public int AsignarPartida(string jugador)
        {
            if (HayPartidaDisponible())
            {
                var partidaDisplonible = (from p in Partidas
                                          where !p.Value.PartidaIniciada || p.Value.JugadoresEnEspera.Count > 6
                                          select p).ToList().First();
                partidaDisplonible.Value.UnirsePartida(jugador);
                var idPartida = partidaDisplonible.Key;
                return idPartida;
            }
            else
            {
                var nuevaPartida = new Partida();
                nuevaPartida.UnirsePartida(jugador);
                Partidas.Add(NumeroDePartidas, nuevaPartida);
                var idPartida = NumeroDePartidas;
                NumeroDePartidas++;
                return idPartida;
            }
        }

        public List<string> ObtenerListaJugadores(int idPartida)
        {
            var partida = (from p in Partidas
                           where p.Key == idPartida
                           select p).First();
            return partida.Value.Jugadores.Keys.ToList();
        }

        public string ObtenerColor(int idPartida, string nombreJugador)
        {
            var partida = (from p in Partidas
                           where p.Key == idPartida
                           select p).First();
            var jugadores = partida.Value.Jugadores;
            var color = (from j in jugadores
                         where j.Key.Equals(nombreJugador)
                         select j.Value).First();
            return color;
        }
    }
}
