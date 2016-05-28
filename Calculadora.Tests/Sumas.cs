using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logica.Negocio;

namespace Calculadora.Tests
{
    [TestClass]
    public class Sumas
    {
        [TestMethod]
        public void SumarUnoMasDos()
        {
            var primerOperando = 1;
            var segundoOperando = 2;
            var resultadoEsperado = 3;

            var laSuma = new Suma();
            var resultado = laSuma.Operar(primerOperando, segundoOperando);
            Assert.AreEqual(resultadoEsperado, resultado);

        }
    }
}
