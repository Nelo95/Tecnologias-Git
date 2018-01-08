using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace JugarService
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioJugar" en el código y en el archivo de configuración a la vez.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class ServicioJugar : IServicioJugar
    {
        public Dictionary<string, IJugarCallback> JugadoresConectados = new Dictionary<string, IJugarCallback>();
        public Dictionary<int, Partida> Partidas = new Dictionary<int, Partida>();
        public int NumeroDePartidas = 0;

        public void Conectar(string jugador)
        {
            IJugarCallback contexto = OperationContext.Current.GetCallbackChannel<IJugarCallback>();
            try
            {
                if (!JugadoresConectados.ContainsKey(jugador))
                {
                    JugadoresConectados.Add(jugador, contexto);
                }
                else
                {
                    JugadoresConectados.Remove(jugador);
                    JugadoresConectados.Add(jugador, contexto);
                }
            }
            finally
            {
                AsignarPartida(jugador);
            }
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

        public void Disparar(int sala, string jugador, string posicionInicial, string posicionFinal)
        {
            var partida = (from p in Partidas
                           where p.Key == sala
                           select p.Value).First();
            var listaJugadores = (from j in partida.Jugadores
                                  where !j.Key.Equals(jugador)
                                  select j.Key).ToList();

            foreach(var jug in listaJugadores)
            {
                var callback = (from j in JugadoresConectados
                                where j.Key.Equals(jug)
                                select j.Value).First();
                callback.RecibirMovimiento(posicionInicial, posicionFinal);
            }
        }

        public void Listo(int idPartida)
        {
            var partida = (from p in Partidas
                           where idPartida == p.Key
                           select p).Single();
            partida.Value.Listo();
            if (partida.Value.JugadoresListos == partida.Value.JugadoresPorAsignar.Count())
            {
                partida.Value.PartidaIniciada = true;
                MandarInformacionPartida(partida.Key, partida.Value);
            }
        }

        public void AsignarPartida(string jugador)
        {
            if (HayPartidaDisponible())
            {
                var partidaDisponible = (from p in Partidas
                                         where p.Value.PartidaIniciada
                                         select p).First();
                partidaDisponible.Value.JugadoresPorAsignar.Add(jugador);
            }
            else
            {
                NumeroDePartidas++;
                var nuevaPartida = new Partida();
                nuevaPartida.JugadoresPorAsignar.Add(jugador);
                Partidas.Add(NumeroDePartidas, nuevaPartida);
            }
        }

        public bool HayPartidaDisponible()
        {
            var numeroDePartidasDisponibles = (from p in Partidas
                                               where p.Value.PartidaIniciada || p.Value.JugadoresPorAsignar.Count == 6
                                               select p).Count();
            if(numeroDePartidasDisponibles > 0)
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
            var jugadoresConColor = partida.AsignarColores();
            var nombreJugadores = jugadoresConColor.Keys.ToList();
            foreach(var jugador in jugadoresConColor)
            {
                var callbackJugador = (from j in JugadoresConectados
                                       where j.Key.Equals(jugador.Key)
                                       select j.Value).First();
                callbackJugador.RecibirColor(jugador.Value);
                callbackJugador.RecibirJugadores(nombreJugadores);
            }
        }
    }
}
