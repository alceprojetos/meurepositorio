using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Exemplo1;

namespace TestCalculadora
{
    [TestClass]
    public class TestaCalculadora
    {
        [TestMethod]
        public void TestaSoma()
        {
            Calculadora c = new Calculadora();
            int resultado = c.Soma(7, 10);
            Assert.AreEqual(17, resultado);
        }
    }
}
