using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmigosParejas
{
    public class FormateadorDeEntrada
    {
        public string[,] SepararPalabras(string[] lineas)
        {
            string[,] resultado = new string[lineas.Length, 4];
            int cont = 0;
            foreach (var linea in lineas)
            {
                resultado[cont, 0] = linea.Split(' ')[0];
                resultado[cont, 1] = linea.Split(' ')[1].TrimStart('(').Split('|')[0];
                resultado[cont, 2] = linea.Split(' ')[1].Split('|')[1];
                resultado[cont, 3] = linea.Split(' ')[1].Split('|')[2].TrimEnd(')');
                cont++;
            }


            return resultado;

            


        }
    }
}
