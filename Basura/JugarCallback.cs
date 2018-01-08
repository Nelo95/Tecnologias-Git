using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace JugarService
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "JugarCallback" en el código y en el archivo de configuración a la vez.
    public class JugarCallback : IJugarCallback
    {
        public void NotificarJugadoresAbandonaron()
        {
            throw new NotImplementedException();
        }

        public void RecibirColor(string color)
        {
            throw new NotImplementedException();
        }

        public void RecibirExpulsion()
        {
            throw new NotImplementedException();
        }

        public void RecibirJugadores(List<string> listaJugadores)
        {
            throw new NotImplementedException();
        }

        public void RecibirMovimiento(string casillaInicial, string casillaFinal)
        {
            throw new NotImplementedException();
        }

        public void RecibirNombreSala(int nombreSala)
        {
            throw new NotImplementedException();
        }
    }
}
