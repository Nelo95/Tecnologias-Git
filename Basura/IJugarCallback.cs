using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace JugarService
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IJugarCallback" en el código y en el archivo de configuración a la vez.
    [ServiceContract(CallbackContract = typeof(IJugarCallback))]
    public interface IJugarCallback
    {
        [OperationContract]
        void RecibirNombreSala(int nombreSala);
        [OperationContract]
        void RecibirColor(string color);
        [OperationContract]
        void RecibirJugadores(List<string> listaJugadores);
        [OperationContract]
        void RecibirMovimiento(string casillaInicial, string casillaFinal);
        [OperationContract]
        void NotificarJugadoresAbandonaron();
        [OperationContract]
        void RecibirExpulsion();
    }
}
