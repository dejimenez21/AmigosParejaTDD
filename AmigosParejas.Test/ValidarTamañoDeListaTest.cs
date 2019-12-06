using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AmigosParejas.Test
{
    [TestClass]
    public class ValidarTamañoDeListaTest
    {
        [TestMethod]
        public void ListaVacia()
        {
            ValidadorDeEntrada validador = new ValidadorDeEntrada();

            var Lista = new List<Persona>();

            bool resultado = validador.SuficientesPersonasEnLista(Lista);

            Assert.AreEqual(false, resultado);
        }

        [TestMethod]
        public void ListaCon3Personas()
        {
            ValidadorDeEntrada validador = new ValidadorDeEntrada();

            var Lista = new List<Persona> {
                new Persona("Miguel", "M", new List<string>() { "Juan", "Juana"}),
                new Persona("Raul", "M", new List<string>() { "Juan", "Juana"}),
                new Persona("Carlos", "M", new List<string>() { "Juan", "Juana"})
            };

            bool resultado = validador.SuficientesPersonasEnLista(Lista);

            Assert.AreEqual(true, resultado);
        }

        [TestMethod]
        public void ListaCon2Personas()
        {
            ValidadorDeEntrada validador = new ValidadorDeEntrada();

            var Lista = new List<Persona> {
                new Persona("Miguel", "M", new List<string>() { "Juan", "Juana"}),
                new Persona("Raul", "M", new List<string>() { "Juan", "Juana"})
            };

            bool resultado = validador.SuficientesPersonasEnLista(Lista);

            Assert.AreEqual(true, resultado);
        }

        [TestMethod]
        public void ListaCon1Persona()
        {
            ValidadorDeEntrada validador = new ValidadorDeEntrada();

            var Lista = new List<Persona> {
                new Persona("Miguel", "M", new List<string>() { "Juan", "Juana"})
            };

            bool resultado = validador.SuficientesPersonasEnLista(Lista);

            Assert.AreEqual(false, resultado);
        }
    }
}
