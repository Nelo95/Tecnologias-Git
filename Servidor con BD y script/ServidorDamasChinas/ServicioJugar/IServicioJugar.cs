using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServicioJugar
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioJugar" en el código y en el archivo de configuración a la vez.
    [ServiceContract(CallbackContract = typeof(ICallbackJugar))]
    public interface IServicioJugar
    {
        [OperationContract]
        int Conectar(string jugador);
        [OperationContract]
        void Desconectar(int idPartida, string jugador);
        [OperationContract]
        void JugadorListo(int idPartida);
        [OperationContract(IsOneWay = true)]
        void Mover(int sala, string jugador, string posicionInicial, string colorInicial, string posicionFinal, string colorFinal);
        [OperationContract]
        List<string> ObtenerListaJugadores(int idPartida);
        [OperationContract]
        string ObtenerColor(int idPartida, string nombreJugador);
    }
}
