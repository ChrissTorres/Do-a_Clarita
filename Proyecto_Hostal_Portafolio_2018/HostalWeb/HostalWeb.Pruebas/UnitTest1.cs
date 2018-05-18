using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HostalWeb.Negocio;
namespace HostalWeb.Pruebas
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void LeerEmpresa()
        {
            string esperado = "Informatica";
            string resultado = "";
            Empresa empress = new Empresa();
            empress.RUT_EMPRESA = "1-7";
            empress.Read();
            resultado = empress.GIRO_EMPRESA;
            Assert.AreEqual(esperado, resultado);
        }
        [TestMethod]
        public void TestAuthentication()
        {
            bool expected = true, result = false;
            User user = new User()
            {
                NOMBRE = "CHRIS",
                CONTRASENA = "1234"
            };
            result = user.Authenticate();
            Assert.AreEqual(expected, result);
        }
        
    }
}
