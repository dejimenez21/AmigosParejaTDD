using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmigosParejas
{
    public class Relacion
    {
        public string ComprobarRelacion(Persona[] personas)
        {
            bool soloAmigos;

            if (personas[0].Genero == personas[1].Genero)
                soloAmigos = true;
            else
                soloAmigos = false;

            foreach(var padre in personas[0].Padres)
            {
                if (personas[1].Padres.Any(x => x == padre))
                    soloAmigos = true;
            }

            if (soloAmigos)
                return "Solo amigos";
            else
                return "Amigos y Pareja";
        }
    }
}
