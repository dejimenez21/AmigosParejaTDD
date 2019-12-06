using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmigosParejas
{
    public class Persona
    {
        public string Nombre;
        public string Genero;
        public List<string> Padres;

        public Persona(string nombre, string genero, List<string> padres)
        {
            Nombre = nombre;
            Genero = genero;
            Padres = padres;
        }
    }
}
