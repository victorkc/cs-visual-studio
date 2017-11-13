using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaTelevision
{
    class Horario
    {
        public Horario()
        {
            string[] horario = new string[5];
            horario[0] = "lunes";
            horario[1] = "martes";
            horario[2] = "miércoles";
            horario[3] = "jueves";
            horario[4] = "viernes";
            Patata patata = new Patata();
            patata.cosa = 1;
        }
        internal class Patata
        {
            int cosa;
            public Patata()
            {
                cosa = 2;
            }
        }
        /*
        •
    8:00 – 10:00: Primera hora 
•
    10:00 – 14:00: Matinal 1
•
    14:00 – 16:00: Mediodía.
•
    16:00 – 20:00: Tarde 
•
    20:00 – 24:00: Noche*/
    }
}
