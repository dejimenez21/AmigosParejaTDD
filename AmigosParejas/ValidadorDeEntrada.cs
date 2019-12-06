using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmigosParejas
{
    public class ValidadorDeEntrada
    {
        public bool NombresExistenEnLista(string[] nombres, List<Persona> Lista)
        {
            bool existen=true;

            foreach(var nombre in nombres)
            {
                if (!Lista.Any(x => x.Nombre == nombre))
                    existen = false;
            }

            return existen;
        }

        public bool SuficientesPersonasEnLista(List<Persona> lista)
        {
            return lista.Count > 1;
        }

        public bool FormatoDeLineasCorrecto(string[] lineas)
        {
            bool formatoCorrecto = true;

            foreach (var linea in lineas)
            {
                string[] secciones = linea.Split(' ');
                if (
                    secciones.Length != 2 ||
                    !secciones[1].StartsWith("(") ||
                    !secciones[1].EndsWith(")") ||
                    secciones[1].Split('|').Length != 3
                    )
                {
                    formatoCorrecto = false;
                }
                
            }

            return formatoCorrecto;
        }
    }
}
