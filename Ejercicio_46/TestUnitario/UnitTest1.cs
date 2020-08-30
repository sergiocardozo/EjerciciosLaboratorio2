using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace TestUnitario
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CompetidoresListaInstanciada()
        {
            Competencia competencia = new Competencia(1, 1, Competencia.TipoCompetencia.F1);

            Assert.IsNotNull(competencia.Competidores);
        }
        [TestMethod]
        public void ThrowCompetenciaNoDisponible()
        {
            Competencia competencia = new Competencia(1, 1, Competencia.TipoCompetencia.MotoCross);
            AutoF1 auto = new AutoF1(1, "1");

            Assert.ThrowsException<CompetenciaNoDisponibleException>(() => competencia + auto);
        }
        [TestMethod]
        public void NotThrowCompetenciaNoDisponible()
        {
            Competencia competencia = new Competencia(1, 1, Competencia.TipoCompetencia.MotoCross);
            MotoCross moto = new MotoCross(1, "1");

            try
            {
                bool actual = competencia + moto;
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }
        [TestMethod]
        public void CargaVehiculo()
        {
            Competencia competencia = new Competencia(1, 1, Competencia.TipoCompetencia.MotoCross);
            MotoCross moto = new MotoCross(1, "1");
            bool expected = true;

            bool actual = competencia + moto;
            actual = competencia == moto;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void BorraVehiculo()
        {
            Competencia competencia = new Competencia(1, 1, Competencia.TipoCompetencia.MotoCross);
            MotoCross moto = new MotoCross(1, "1");
            bool expected = false;

            bool actual = competencia + moto;
            actual = moto - competencia;
            actual = competencia == moto;

            Assert.AreEqual(expected, actual);
        }
    }
}
