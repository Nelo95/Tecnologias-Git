using Microsoft.VisualStudio.TestTools.UnitTesting;
using DamasChinas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DamasChinas.Tests
{
    [TestClass()]
    public class MainWindowTests
    {

        [TestMethod()]
        public void HayCamposNulosTest()
        {
            var usuario = "";
            var contrasenia = "";
            MainWindow main = new MainWindow();
            var resultado = main.HayCamposNulos(usuario, contrasenia);

            Assert.IsTrue(resultado);
        }

        [TestMethod()]
        public void MostrarMensajeTest()
        {
            string causa = "JugadorNoRegistrado";
            MainWindow window = new MainWindow();
            string resultado = window.MostrarMensaje(causa);

            Assert.AreEqual(causa, resultado);

        }

        [TestMethod()]
        public void Sha256Test()
        {
            string contrasena = "ak2Eop45";
            string resultadoEsperado = "061e5358f9fe05437f655ca20e84857f1df8fcb5b89289f9034ed69b0d2a55ee";

            MainWindow window = new MainWindow();

            var resultadoObtenido = window.Sha256(contrasena);

            Assert.AreEqual(resultadoEsperado, resultadoObtenido);
        }

    }
}