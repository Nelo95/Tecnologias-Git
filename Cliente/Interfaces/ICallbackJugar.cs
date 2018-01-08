using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Interfaces
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "ICallbackJugar" en el código y en el archivo de configuración a la vez.
    [ServiceContract(CallbackContract = typeof(ICallbackJugar))]
    public interface ICallbackJugar
    {
        [OperationContract(IsOneWay =true)]
        void RecibirNombreSala(int nombreSala);
        [OperationContract(IsOneWay = true)]
        void RecibirColor(string color);
        [OperationContract(IsOneWay = true)]
        void RecibirJugadores(List<string> listaJugadores);
        [OperationContract(IsOneWay = true)]
        void RecibirMovimiento(string casillaInicial, string colorInicial, string casillaFinal, string colorFinal);
        [OperationContract]
        void NotificarJugadoresAbandonaron();
        [OperationContract]
        void RecibirExpulsion();
        [OperationContract(IsOneWay = true)]
        void RecibirTurno();
    }
}
