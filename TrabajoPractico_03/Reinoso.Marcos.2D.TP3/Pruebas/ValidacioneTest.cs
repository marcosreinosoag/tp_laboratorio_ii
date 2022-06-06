using Microsoft.VisualStudio.TestTools.UnitTesting;
using Biblioteca;

namespace Pruebas
{
    [TestClass]
    public class ValidacioneTest
    {
        [TestMethod]
        public void ValidarStringSoloLetras_CuandoElStringContieneNumeros_DeberiaRetonarNulo()
        {
            //Arrange - Prepara el caso de Prueba
            string palabra = "Marcos123";
            string resultadoEsperado = null;

            //Atc - Invocar al metodo a probar
            string resultado = Validaciones.ValidarStringSoloLetras(palabra);

            // Asert - Vaerifico que el resultado sea el esperado
            Assert.AreEqual(resultadoEsperado, resultado);
        }

        [TestMethod]
        public void ValidarStringSoloNumeros_CuandoElStringContieneLetras_DeberiaRetonarNulo()
        {
            // Arrange - Preparar el caso de prueba
            string palabra = "Marcos123";
            string resultadoEsperado = null;

            //Atc - Invocar al metodo a probar
            string resultado = Validaciones.ValidarStringSoloLetras(palabra);

            // Asert - Vaerifico que el resultado sea el esperado
            Assert.AreEqual(resultadoEsperado, resultado);
        }
        [TestMethod]
        public void ValidarStringSoloNumerosConComa_CuandoElStringNoEsUnNumeroConcoma_DeberiaRetonarNulo()
        {
            // Arrange - Preparar el caso de prueba
            string palabra = "123a";
            string resultadoEsperado = null;

            //Atc - Invocar al metodo a probar
            string resultado = Validaciones.ValidarStringSoloLetras(palabra);

            // Asert - Vaerifico que el resultado sea el esperado
            Assert.AreEqual(resultadoEsperado, resultado);
        }
    }
}
