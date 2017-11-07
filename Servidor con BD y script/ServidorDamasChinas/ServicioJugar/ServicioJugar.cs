using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServicioJugar
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioJugar" en el código y en el archivo de configuración a la vez.
    public class ServicioJugar : IServicioJugar
    {
        public void Mover(string jugador, string posInicial, string posDestino, int idPartida)
        {
            throw new NotImplementedException();
        }

        public void SalirSala(string jugador, int idSala)
        {
            throw new NotImplementedException();
        }

        public int UnirseSala(string jugador)
        {
            var contexto = OperationContext.Current.GetCallbackChannel<ICallbackJugar>();
            //Comportamiento para unir al servidor 
            return 0;
        }
    }
}
