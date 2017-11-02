using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    class Fecha
    {
        // atributos
        int dia, mes, anio;

        //constructores
        public Fecha()
        {
            dia = 1;
            mes = 1;
            anio = 1970;
        }

        public Fecha(int d, int m, int a)
        {
            dia = d;
            mes = m;
            anio = a;
        }
    }
}
