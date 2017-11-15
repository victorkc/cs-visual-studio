using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaTelevision
{
    class Horario
    {
        Programa programa;
        string horas, momento;

        public Horario()
        {
           // 
        }
        public Horario(string horas, string momento) //CREA EL PROGRAMA Y DA VALOR A LAS VARIABLES
        {
            this.horas = horas;
            this.momento = momento;
            programa = new Programa();
        }
        public Programa getPrograma() //DEVUELVE PROGRAMA
        {
            return programa;
        }
        public string getHorario() //DEVUELVE HORARIO
        {
            return " de " + horas + ", " + momento;
        }
        public int minutosDia() //DEVUELVE MINUTOS
        {
            return getPrograma().duracionPrograma();
        }
    }
}
