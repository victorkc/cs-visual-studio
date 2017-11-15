using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaTelevision
{
    class Horario:Programa
    {
        public Programa programa;
        string horas, momento;

        public Horario()
        {
            programa = new Programa();
        }
        public Horario(string horas, string momento)
        {
            this.horas = horas;
            this.momento = momento;
        }
    }
}
