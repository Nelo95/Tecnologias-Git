using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DamasChinas.Datos
{
    public class BD
    {
        // Método para conectar con la base de datos
        public static MySqlConnection ObtenerConexion()
        {
            MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=damaschinas; Uid=root; pwd=011217;");

            conectar.Open();
            return conectar;
        }

    }
}
