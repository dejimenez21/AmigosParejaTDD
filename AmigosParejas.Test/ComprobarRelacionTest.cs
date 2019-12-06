using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace AmigosParejas.Test
{
    [TestClass]
    public class ComprobarRelacionTest
    {
        [TestMethod]
        public void MismoGeneroDiferentesPadresYMadresTest()
        {
            Relacion relacion = new Relacion();

            var Personas = new Persona[2]
            {
                new Persona("Raul", "M", new List<string>(){"Pepe", "Nana" }),
                new Persona("Pepe", "M", new List<string>(){"Lucas", "Rosa"})
            };
                
            string result = relacion.ComprobarRelacion(Personas);

            Assert.AreEqual("Solo amigos", result);
        }

        [TestMethod]
        public void MismoGeneroMismosPadresYDiferentesMadresTest()
        {
            Relacion relacion = new Relacion();

            var Personas = new Persona[2]
            {
                new Persona("Raul", "M", new List<string>(){"Pepe", "Nana" }),
                new Persona("Pepe", "M", new List<string>(){"Pepe", "Rosa"})
            };

            string result = relacion.ComprobarRelacion(Personas);

            Assert.AreEqual("Solo amigos", result);
        }

        [TestMethod]
        public void MismoGeneroDiferentesPadresYMismasMadresTest()
        {
            Relacion relacion = new Relacion();

            var Personas = new Persona[2]
            {
                new Persona("Raul", "M", new List<string>(){"Pepe", "Nana" }),
                new Persona("Pepe", "M", new List<string>(){"Lucas", "Nana"})
            };

            string result = relacion.ComprobarRelacion(Personas);

            Assert.AreEqual("Solo amigos", result);
        }

        [TestMethod]
        public void MismoGeneroMismosPadresYMadresTest()
        {
            Relacion relacion = new Relacion();

            var Personas = new Persona[2]
            {
                new Persona("Raul", "M", new List<string>(){"Pepe", "Nana" }),
                new Persona("Pepe", "M", new List<string>(){"Pepe", "Nana"})
            };

            string result = relacion.ComprobarRelacion(Personas);

            Assert.AreEqual("Solo amigos", result);
        }

        [TestMethod]
        public void DiferenteGeneroDiferentesPadresYMadresTest()
        {
            Relacion relacion = new Relacion();

            var Personas = new Persona[2]
            {
                new Persona("Raul", "M", new List<string>(){"Pepe", "Nana" }),
                new Persona("Lia", "F", new List<string>(){"Lucas", "Rosa"})
            };

            string result = relacion.ComprobarRelacion(Personas);

            Assert.AreEqual("Amigos y Pareja", result);
        }

        [TestMethod]
        public void DiferenteGeneroMismosPadresDiferentesMadresTest()
        {
            Relacion relacion = new Relacion();

            var Personas = new Persona[2]
            {
                new Persona("Raul", "M", new List<string>(){"Pepe", "Nana" }),
                new Persona("Lia", "F", new List<string>(){"Pepe", "Rosa"})
            };

            string result = relacion.ComprobarRelacion(Personas);

            Assert.AreEqual("Solo amigos", result);
        }

        [TestMethod]
        public void DiferenteGeneroDiferentesPadresMismasMadresTest()
        {
            Relacion relacion = new Relacion();

            var Personas = new Persona[2]
            {
                new Persona("Raul", "M", new List<string>(){"Pepe", "Nana" }),
                new Persona("Lia", "F", new List<string>(){"Carlos", "Nana"})
            };

            string result = relacion.ComprobarRelacion(Personas);

            Assert.AreEqual("Solo amigos", result);
        }

        [TestMethod]
        public void DiferenteGeneroMismosPadresYMadresTest()
        {
            Relacion relacion = new Relacion();

            var Personas = new Persona[2]
            {
                new Persona("Raul", "M", new List<string>(){"Pepe", "Nana" }),
                new Persona("Lia", "F", new List<string>(){"Pepe", "Nana"})
            };

            string result = relacion.ComprobarRelacion(Personas);

            Assert.AreEqual("Solo amigos", result);
        }
    }
}
