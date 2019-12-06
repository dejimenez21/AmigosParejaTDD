using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmigosParejas
{
    class Program
    {
        static void Main(string[] args)
        {
            FormateadorDeEntrada formateador = new FormateadorDeEntrada();
            formateador.SepararPalabras(new string[] { "Persona (Genero|Padre|Madre)",
                "Maria (F|Julio|Teresa)"});
        }
    }
}
