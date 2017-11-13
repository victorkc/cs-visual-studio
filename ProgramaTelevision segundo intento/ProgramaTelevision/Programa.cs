using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaTelevision
{
    class Programa
    {
        string nombre, tipoContenidos;
        int duracion;

        public Programa(string n, string tc, int d)
        {
            nombre = n;
            tipoContenidos = tc;
            duracion = d;
        }

    }
}
