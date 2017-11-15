using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaTelevision
{
    class Semana
    {
        Dia[] dia;
        public Semana()
        {
            dia = new Dia[5];
            dia[0] = new Dia("Lunes");
            dia[1] = new Dia("Martes");
            dia[2] = new Dia("Miércoles");
            dia[3] = new Dia("Jueves");
            dia[4] = new Dia("Viernes");
        }
        public void nuevoPrograma(int elegirDia, int elegirHorario, string nombreSerie, string tipo, int duracion)//CREAR PROGRAMA
        {
            getDia(elegirDia).getHorario(elegirHorario).getPrograma().nuevoPrograma(nombreSerie, tipo, duracion);
        }
        public void borrarPrograma(int elegirDia, int elegirHorario)//BORRAR PROGRAMA
        {
            getDia(elegirDia).getHorario(elegirHorario).getPrograma().borrarPrograma();
        }
        public void modMinutos(int elegirDia, int elegirHorario, int duracion)//MODIFICAR MINUTOS
        {
            getDia(elegirDia).getHorario(elegirHorario).getPrograma().modDuracion(duracion);
        }
        public void mostrarSemana()//MOSTRAR LA SEMANA
        {
            Console.WriteLine("Desglose de la semana:");
            for (int j = 0; j < 5; j++)
            {
                Console.WriteLine("");
                for (int i = 0; i < 5; i++)
                    Console.WriteLine(getDia(j).getDiaNombre() + getDia(j).getHorario(i).getHorario() + getDia(j).getHorario(i).getPrograma().escribir());
                Console.WriteLine("");
            }
        }
        public Dia getDia(int i) //DEVUELVE DIA ELEGIDO
        {
            return dia[i];
        }
        public void programacionDia(int elegirDia) //DEVUELVE PROGRAMACIÓN DE UN DÍA
        {
            for (int i = 0; i < 5; i++)
                Console.WriteLine(getDia(elegirDia).getDiaNombre() + getDia(elegirDia).getHorario(i).getHorario() + getDia(elegirDia).getHorario(i).getPrograma().escribir());
            Console.WriteLine("");
        }
        public void minutosDia(int elegirDia) //DEVUELVE LOS MINUTOS DE LA PROGRAMACIÓN
        {
            for (int i = 0; i < 5; i++)
                Console.WriteLine(getDia(elegirDia).getHorario(i).getHorario() + " dura: " + getDia(elegirDia).getHorario(i).minutosDia() + " minutos.");
        }
    }
}
