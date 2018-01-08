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
            ServiceHost hostCuenta = null;
            ServiceHost hostJugar = null;
            using (hostCuenta = new ServiceHost(typeof(ServicioCuenta.ServicioCuenta)))
            using (hostJugar = new ServiceHost(typeof(ServicioJugar.ServicioJugar)))
            {
                Console.WriteLine("Iniciando servidor...");
                hostCuenta.Open();
                hostJugar.Open();
                Console.WriteLine("Servidor iniciado, pulse <enter> para cerrar");
                Console.ReadLine();
            }
        }
    }
}
