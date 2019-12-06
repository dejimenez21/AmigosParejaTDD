using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AmigosParejas.Test
{
    [TestClass]
    public class ValidarFormatoLineasArchivoTest
    {
        [TestMethod]
        public void UnaLineaSinEspacio()
        {
            ValidadorDeEntrada validador = new ValidadorDeEntrada();

            var Lineas = new string[2] {
                "Persona (Genero|Padre|Madre)",
                "Persona(Genero|Padre|Madre)"
            };


            bool resultado = validador.FormatoDeLineasCorrecto(Lineas);

            Assert.AreEqual(false, resultado);
        }

        [TestMethod]
        public void FormatoCorrecto()
        {
            ValidadorDeEntrada validador = new ValidadorDeEntrada();

            var Lineas = new string[2] {
                "Persona (Genero|Padre|Madre)",
                "Persona (Genero|Padre|Madre)"
            };


            bool resultado = validador.FormatoDeLineasCorrecto(Lineas);

            Assert.AreEqual(true, resultado);
        }

        [TestMethod]
        public void DosLineasVacias()
        {
            ValidadorDeEntrada validador = new ValidadorDeEntrada();

            var Lineas = new string[2] {
                "",
                ""
            };


            bool resultado = validador.FormatoDeLineasCorrecto(Lineas);

            Assert.AreEqual(false, resultado);
        }

        [TestMethod]
        public void UnaLineaConDosEspacios()
        {
            ValidadorDeEntrada validador = new ValidadorDeEntrada();

            var Lineas = new string[2] {
                "Persona (Genero |Padre|Madre)",
                "Persona (Genero|Padre|Madre)"
            };


            bool resultado = validador.FormatoDeLineasCorrecto(Lineas);

            Assert.AreEqual(false, resultado);
        }

        [TestMethod]
        public void LineaSinParentesisDeApertura()
        {
            ValidadorDeEntrada validador = new ValidadorDeEntrada();

            var Lineas = new string[2] {
                "Persona Genero|Padre|Madre)",
                "Persona (Genero|Padre|Madre)"
            };


            bool resultado = validador.FormatoDeLineasCorrecto(Lineas);

            Assert.AreEqual(false, resultado);
        }

        [TestMethod]
        public void LineaSinParentesisDeClausura()
        {
            ValidadorDeEntrada validador = new ValidadorDeEntrada();

            var Lineas = new string[2] {
                "Persona (Genero|Padre|Madre",
                "Persona (Genero|Padre|Madre)"
            };


            bool resultado = validador.FormatoDeLineasCorrecto(Lineas);

            Assert.AreEqual(false, resultado);
        }

        [TestMethod]
        public void LineaSinTubos()
        {
            ValidadorDeEntrada validador = new ValidadorDeEntrada();

            var Lineas = new string[2] {
                "Persona (GeneroPadreMadre)",
                "Persona (Genero|Padre|Madre)"
            };


            bool resultado = validador.FormatoDeLineasCorrecto(Lineas);

            Assert.AreEqual(false, resultado);
        }

        [TestMethod]
        public void LineaConUnTubo()
        {
            ValidadorDeEntrada validador = new ValidadorDeEntrada();

            var Lineas = new string[2] {
                "Persona (GeneroPadre|Madre)",
                "Persona (Genero|Padre|Madre)"
            };


            bool resultado = validador.FormatoDeLineasCorrecto(Lineas);

            Assert.AreEqual(false, resultado);
        }

        [TestMethod]
        public void LineaConTresTubos()
        {
            ValidadorDeEntrada validador = new ValidadorDeEntrada();

            var Lineas = new string[2] {
                "Persona (Gen|ero|Padre|Madre)",
                "Persona (Genero|Padre|Madre)"
            };


            bool resultado = validador.FormatoDeLineasCorrecto(Lineas);

            Assert.AreEqual(false, resultado);
        }
    }
}
