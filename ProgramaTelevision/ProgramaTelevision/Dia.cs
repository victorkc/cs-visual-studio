using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaTelevision
{
    class Dia
    {
        string nombreDia;
        Horario[] horario;
        public Dia()
        {/*
            horario = new Horario[5];
            horario[0] = new Horario("8:00 – 10:00", "Primera hora");
            horario[1] = new Horario("10:00 – 14:00", "Matinal");
            horario[2] = new Horario("14:00 – 16:00", "Mediodia");
            horario[3] = new Horario("16:00 – 20:00", "Tarde");
            horario[4] = new Horario("20:00 – 24:00", "Noche");*/
        }
        public Dia(string nombre)
        {
            horario = new Horario[5];
            nombreDia = nombre;
            horario[0] = new Horario("8:00 – 10:00", "Primera hora");
            horario[1] = new Horario("10:00 – 14:00", "Matinal");
            horario[2] = new Horario("14:00 – 16:00", "Mediodia");
            horario[3] = new Horario("16:00 – 20:00", "Tarde");
            horario[4] = new Horario("20:00 – 24:00", "Noche");
        }
        public Horario getHorario(int i)
        {
            return horario[i];
        }
        public string getDiaNombre()//DEVUELVE NOMBRE DE DIA
        {
            return nombreDia + ",";
        }
        
    }
}
