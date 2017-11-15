using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaTelevision
{
    class Semana : Dia
    {
        public Dia[] dia = new Dia[5];
        public Semana()
        {
            dia[0] = new Dia("Lunes");
            dia[1] = new Dia("Martes");
            dia[2] = new Dia("Miércoles");
            dia[3] = new Dia("Jueves");
            dia[4] = new Dia("Viernes");
        }
        public void mostrarSemana()
        {
            Console.WriteLine("Desglose de la semana:");
            for (int j = 0; j < 5; j++)
                for (int i = 0; i < 5; i++)
                    Console.WriteLine(dia[j].nombreDia + ": de " + horario[i]+ "se emite "+ dia[j].horario[i].programa.escribir());
        }
    }
}
