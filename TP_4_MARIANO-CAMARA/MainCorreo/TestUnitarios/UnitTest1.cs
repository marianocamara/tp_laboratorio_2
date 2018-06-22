using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace TestUnitarios
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void a()
        {
            Correo correo = new Correo();
            Assert.IsNotNull(correo.Paquetes);
        }

        [TestMethod]
        [ExpectedException(typeof(TrackingRepetidoException))]
        public void b()
        {
            Correo correo = new Correo();

            Paquete p1 = new Paquete("direccion X","481-516-2342");
            Paquete p2 = new Paquete("direccion Y", "481-516-2342");

            correo += p1;
            correo += p2;
        }
    }
}
