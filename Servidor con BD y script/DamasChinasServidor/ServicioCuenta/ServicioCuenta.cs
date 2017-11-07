﻿using BaseDeDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServicioCuenta
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioCuenta" en el código y en el archivo de configuración a la vez.
    public class ServicioCuenta : IServicioCuenta
    {

        public string iniciarSesion(string usuario, string contrasenia)
        {
            var resultado = "";
            try
            {
                using(var entidades = new DamasChinasEntities()){
                    var coincidente = (from u in entidades.usuarios
                                     where u.usuario.Equals(usuario) && u.contrasenia.Equals(contrasenia)
                                     select u).SingleOrDefault();
                    resultado = coincidente.usuario;
                }
            }
            catch(NullReferenceException)
            {
                resultado = "UsuarioContraseniaIncorrecto";
            }
            return resultado;
        }
    }
}
