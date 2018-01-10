using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DamasChinas.Datos
{
     public class UsuariosDAO
    {
        /// <summary>
        /// Método para registrar un nuevo usuario
        /// </summary>
        /// <param name="usuario">Objeto de tipo Usuarios para insertar en la base de datos</param>

        public static int RegistrarUsuario(Usuarios usuario)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(string.Format("Insert into usuarios(nombre,usuario,contrasenia) values ('{0}','{1}','{2}')",
               usuario.Nombre, usuario.Usuario, usuario.Contrasenia), BD.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        /// <summary>
        /// Método para iniciar sesión
        /// </summary>
        /// <param name="usuario">Usuario del jugadors</param>
        /// <param name="contrasenia">Contraseña del jugadors</param>
        public static int IniciarSesion(string usuario, string contrasenia)
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(string.Format("select usuario from usuarios where usuario = '{0}' and contrasenia= '{1}'", usuario, contrasenia), BD.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }
    }
}
