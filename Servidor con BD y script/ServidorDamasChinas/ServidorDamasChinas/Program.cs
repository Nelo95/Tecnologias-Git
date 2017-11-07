using ServicioCuenta;
using ServicioJugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServidorDamasChinas
{
    class Program
    {
        static void Main(string[] args)
        {
            /*ServiceHost hostCuenta = null;
            using (hostCuenta = new ServiceHost(typeof(ServicioCuenta.ServicioCuenta)))
            {
                Console.WriteLine("Iniciando servidor...");
                hostCuenta.Open();
                Console.WriteLine("Servidor iniciado, pulse <enter> para cerrar");
                Console.ReadLine();
            }*/
            ServiceHost hostJugar = null;
            using (hostJugar = new ServiceHost(typeof(ServicioJugar.ServicioJugar)))
            {

            }
        }
    }
}
