using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DamasChinas.Datos
{
    public class Usuarios
    {
        public int Idusuarios { get; set; }
        public string Nombre { get; set; }
        public string Usuario { get; set; }
        public string Contrasenia { get; set; }

        public Usuarios() { }

        public Usuarios(int idUsuarios, string nombre, string usuario, string contrasenia)
        {
            this.Idusuarios = idUsuarios;
            this.Nombre = nombre;
            this.Usuario = usuario;
            this.Contrasenia = contrasenia;
        }
    }
}
