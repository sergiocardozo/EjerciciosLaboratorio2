using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace TestUnitario
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Centralita testLista = new Centralita();

            bool actual = (testLista.Llamadas != null) ? true : false;

            Assert.AreEqual(true, actual);
        }
    }
}
