using System;
using Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestUnitario
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void CentralitaAddLocal_ShouldThrowExc()
        {
            /*b. Controlar mediante un nuevo método de test unitario que la excepción CentralitaExcepcion
                se lance al intentar cargar una segunda llamada con solamente los mismos datos de origen y
                destino de una llamada Local ya existente.*/

            //arrange
            /* La sección Arrange de un método de prueba unitaria inicializa objetos y
                establece el valor de los datos que se pasa al método en pruebas*/
            Centralita centralita = new Centralita();
            Local local1 = new Local("1", 1, "1", 1);
            Local local2 = new Local("2", 2, "2", 2);
            Local local3 = new Local("3", 3, "3", 3);
            bool actual1 = false;
            bool actual2 = false;
            bool expected1 = false;
            bool expected2 = true;

            //act
            /* invoca al método en pruebas con los parámetros organizados*/

            try
            {
                centralita += local1;
                centralita += local2;
            }
            catch (CentralitaException)
            {
                actual1 = true;                
            }
            try
            {
                centralita += local3;
            }
            catch (CentralitaException)
            {
                actual2 = true;
            }
            //assert
            /* comprueba si la acción del método en pruebas se comporta de la forma prevista*/

            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
        }
    }
}
