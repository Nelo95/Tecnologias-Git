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
        //Diccionario de los jugadores conectados con los valores string como llave y su interfaz callback
        public Dictionary<string, ICallbackJugar> JugadoresConectados = new Dictionary<string, ICallbackJugar>();
        //Diccionario de partidas 
        public Dictionary<int, Partida> Partidas = new Dictionary<int, Partida>();
        public int NumeroDePartidas = 0;


        /// <summary>
        /// Se conecta el usuario a la lista de usuarios conectados
        /// </summary>
        /// <param name="jugador">Usuario que se va a conectar</param>
        public int Conectar(string jugador)
        {
            //Se crea un contexto por medio del canal
            ICallbackJugar contexto = OperationContext.Current.GetCallbackChannel<ICallbackJugar>();

            //Si el usuario no está en el diccionario
            if (!JugadoresConectados.ContainsKey(jugador))
            {
                //Se agrega
                JugadoresConectados.Add(jugador, contexto);
            }
            //Si el usuario ya está en el diccionario
            else
            {
                //Se quita y se vuelve a agregar
                JugadoresConectados.Remove(jugador);
                JugadoresConectados.Add(jugador, contexto);
            }
            //Se asigna jugador a partida
            var idPartida = AsignarPartida(jugador);
            return idPartida;
        }

        /// <summary>
        /// Desconecta al usuario
        /// </summary>
        /// <param name="jugador">El usuario que se va a quitar</param>
        /// <param name="idPartida">La partida en la que se encuentra el jugador</param>
        public void Desconectar(int idPartida, string jugador)
        {
            //Se busca la partida en la cual estaba el jugador
            var partidaDondeEstaba = (from p in Partidas
                                      where p.Key == idPartida
                                      select p.Value).First();
            //Se quita el jugador
            partidaDondeEstaba.Jugadores.Remove(jugador);
            if (partidaDondeEstaba.Jugadores.Count == 1)
            {
                //Se sacan los jugadores que quedan
                var jugadorRestante = partidaDondeEstaba.Jugadores.Keys.First();
                var callbackJugadorRestante = (from j in JugadoresConectados
                                               where j.Key.Equals(jugadorRestante)
                                               select j.Value).First();
                //los jugadores restantes son notificados y removidos de la partida
                callbackJugadorRestante.NotificarJugadoresAbandonaron();
                callbackJugadorRestante.RecibirExpulsion();
                Partidas.Remove(idPartida);
                JugadoresConectados.Remove(jugadorRestante);
            }
            JugadoresConectados.Remove(jugador);
        }

        /// <summary>
        /// Cuenta los jugadores listos y los jugadores en espera hasta completar el número de jugadores permitidos en Damas Chinas
        /// </summary>
        /// <param name="idPartida">La partida en la que se encuentran los jugadores</param>
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
            }
        }

        /// <summary>
        /// Manda el turno a los jugadores de la partida
        /// </summary>
        /// <param name="idPartida">La partida en la que se encuentran los jugadores</param>
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
        }
        /// <summary>
        /// Se encarga de realizar los movimientos de las fichas de cada jugador perteneciente a una partida
        /// </summary>
        /// <param name="sala">La sala en la que se encuentran los jugadores</param>
        /// <param name="jugador">Nombre del jugador que realiza el movimiento</param>
        /// <param name="posicionInicial">Posición inicial de la ficha (Origen)</param>
        /// <param name="colorInicial">Color inicial de la ficha</param>
        /// <param name="posicionFinal">Posición final de la ficha (Destino)</param>
        /// <param name="colorFinal">Color final de la ficha</param>
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


        /// <summary>
        /// Se encarga de revisar si hay partidas disponibles
        /// </summary>
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

        /// <summary>
        /// Se encarga de mandar la información de la partida a los jugadores
        /// </summary>
        /// <param name="idPartida">El id de la partida en la que se encuentran los jugadores</param>
        /// /// <param name="partida">La partida en la que se encuentran los jugadores con su información</param>
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
            }
            foreach (var jugador in jugadoresConColor)
            {
                var callbackJugador = (from j in JugadoresConectados
                                       where j.Key.Equals(jugador.Key)
                                       select j).First();
                callbackJugador.Value.RecibirJugadores(nombreJugadores);
            }
        }

        /// <summary>
        /// Se encarga de asignar una partida a un jugador
        /// </summary>
        /// <param name="jugador">Nombre del jugador</param>
        public int AsignarPartida(string jugador)
        {
            //Si hay una partida disponible, se la asigna al jugador
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
                //Si no hay una partida disponible se crea una y después se asigna al jugador
                var nuevaPartida = new Partida();
                nuevaPartida.UnirsePartida(jugador);
                Partidas.Add(NumeroDePartidas, nuevaPartida);
                var idPartida = NumeroDePartidas;
                NumeroDePartidas++;
                return idPartida;
            }
        }

        /// <summary>
        /// Se encarga de obtener la lista de jugadores de una partida
        /// </summary>
        /// <param name="idPartida">Partida en la que se encuentran los jugadores</param>
        public List<string> ObtenerListaJugadores(int idPartida)
        {
            var partida = (from p in Partidas
                           where p.Key == idPartida
                           select p).First();
            return partida.Value.Jugadores.Keys.ToList();
        }

        /// <summary>
        /// Se encarga de obtener el color del jugador
        /// </summary>
        /// <param name="idPartida">partida en la que se encuentra el jugador</param>
        /// <param name="nombreJugador">Nombre del jugador</param>
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
