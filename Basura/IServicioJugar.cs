using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace JugarService
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioJugar" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioJugar
    {
        [OperationContract]
        void Conectar(string jugador);
        [OperationContract]
        void Desconectar(int idPartida, string jugador);
        [OperationContract]
        void Listo(int idPartida);
        [OperationContract]
        void Disparar(int sala, string jugador, string posicionInicial, string posicionFinal);
    }
}
