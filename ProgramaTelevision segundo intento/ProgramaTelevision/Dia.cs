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
        Horario horario;
        public Dia(string nombre)
        {
            nombreDia = nombre;
            horario = new Horario();
        }
    }
}
