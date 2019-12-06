using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AmigosParejas.Test
{
    [TestClass]
    public class ValidarNombresEnListaTest
    {
        [TestMethod]
        public void AmbosNombresEstanEnLista()
        {
            ValidadorDeEntrada validador = new ValidadorDeEntrada();

            var nombres = new string[2] { "Miguel", "Carlos" };
            var Lista = new List<Persona> {
                new Persona("Miguel", "M", new List<string>() { "Juan", "Juana"}),
                new Persona("Raul", "M", new List<string>() { "Juan", "Juana"}),
                new Persona("Carlos", "M", new List<string>() { "Juan", "Juana"})
            };

            bool resultado = validador.NombresExistenEnLista(nombres, Lista);

            Assert.AreEqual(true, resultado);
        }

        [TestMethod]
        public void SoloUnNombreEstaEnLista()
        {
            ValidadorDeEntrada validador = new ValidadorDeEntrada();

            var nombres = new string[2] { "Miguel", "Franklin" };
            var Lista = new List<Persona> {
                new Persona("Miguel", "M", new List<string>() { "Juan", "Juana"}),
                new Persona("Raul", "M", new List<string>() { "Juan", "Juana"}),
                new Persona("Carlos", "M", new List<string>() { "Juan", "Juana"})
            };

            bool resultado = validador.NombresExistenEnLista(nombres, Lista);

            Assert.AreEqual(false, resultado);
        }

        [TestMethod]
        public void NingunNombreEnLaLista()
        {
            ValidadorDeEntrada validador = new ValidadorDeEntrada();

            var nombres = new string[2] { "Wilfredo", "Franklin" };
            var Lista = new List<Persona> {
                new Persona("Miguel", "M", new List<string>() { "Juan", "Juana"}),
                new Persona("Raul", "M", new List<string>() { "Juan", "Juana"}),
                new Persona("Carlos", "M", new List<string>() { "Juan", "Juana"})
            };

            bool resultado = validador.NombresExistenEnLista(nombres, Lista);

            Assert.AreEqual(false, resultado);
        }
    }
}
