using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    class Program
    {
        /*Ejercicios:
         * Determinar si la fecha se corresponde con el año bisiesto.
         * Aumentar el mes +1.
         * Devuelva el nº de días desde 1 enero hasta el día acual.
         * Crear 3 fechas y leer los valores de las fechas por pantalla
         *  -Escriba la mayor de todas.
         */
        static void Main(string[] args)
        {
            Fecha f1 = new Fecha(),
                  f2 = new Fecha(12, 2, 2017),
                  f3 = new Fecha(23, 12, 1993);
        }
    }
}
