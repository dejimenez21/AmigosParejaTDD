using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace AmigosParejas.Test
{
    [TestClass]
    public class SepararPalabrasTest
    {
        [TestMethod]
        public void UnaLinea()
        {
            FormateadorDeEntrada formateador = new FormateadorDeEntrada();

            var Lineas = new string[] {
                "Persona (Genero|Padre|Madre)"
            };

            string[,] resultado = formateador.SepararPalabras(Lineas);
            
            var resultadoEsperado = new string[,]
            {
                { "Persona", "Genero", "Padre", "Madre" }
            };

            bool correcto = true;
            for(int i=0; i<resultado.GetLength(0); i++)
            {
                for(int j=0; j<4; j++)
                {
                    if(resultado[i,j]!=resultadoEsperado[i,j])
                    {
                        correcto = false;
                    }
                }
            }

            Assert.IsTrue(correcto);

        }

        [TestMethod]
        public void DosLineas()
        {
            FormateadorDeEntrada formateador = new FormateadorDeEntrada();

            var Lineas = new string[] {
                "Persona (Genero|Padre|Madre)",
                "Maria (F|Julio|Teresa)"
            };

            string[,] resultado = formateador.SepararPalabras(Lineas);

            var resultadoEsperado = new string[,]
            {
                { "Persona", "Genero", "Padre", "Madre" },
                { "Maria", "F", "Julio", "Teresa" }
            };

            bool correcto = resultadoEsperado.Length==resultado.Length;
            for (int i = 0; i < resultadoEsperado.GetLength(0); i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (resultado[i, j] != resultadoEsperado[i, j])
                    {
                        correcto = false;
                    }
                }
            }

            Assert.IsTrue(correcto);

        }
    }
    
}
