using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaTelevision
{
    /*
• 8:00 – 10:00: Primera hora
• 10:00 – 14:00: Matinal
• 14:00 – 16:00: Mediodía.
• 16:00 – 20:00: Tarde
• 20:00 – 24:00: Noche  
         */
    class Semana
    {
        Dia[] dia = new Dia[7];

        public Semana()
        {
            for (int i = 0; i < 7; i++)
                dia[i] = new Dia();
            dia[0].darNombresSemana("Lunes");
            dia[1].darNombresSemana("Martes");
            dia[2].darNombresSemana("Miércoles");
            dia[3].darNombresSemana("Jueves");
            dia[4].darNombresSemana("Viernes");
            dia[5].darNombresSemana("Sábado");
            dia[6].darNombresSemana("Domingo");
        }

        // ----------------------------------------METODOS DE LA CLASE SEMANA ----------------------------------------

        public void getSemana() //MOSTRAR SEMANA DE PROGRAMAS
        {
            //return lunes.primeraHora.horarioInicio;
            Console.WriteLine("Esta es la programación de toda la semana: ");
            for (int i = 0; i > dia.Length; i++)
            {
                Console.WriteLine(dia[i].getNombreDia());
            }

            //dia[0].accederHorario();
        }

        public void addPrograma(int dia, int horario, int minutos, string nombre, string tipoPrograma) //AÑADE PROGRAMA TV NUEVO
        {
            this.dia[dia].addPrograma(horario, minutos, nombre, tipoPrograma);
        }

        public void remPrograma(int dia, int horario) //BORRA UN PROGRAMA TV
        {
            this.dia[dia].remPrograma(horario);
        }
        public void modMinutos(int dia, int horario, int mins) //AÑADIR O QUITAR MINUTOS DE PROGRAMA TV
        {
            this.dia[dia].modMinutos(horario, mins);
        }


        class Dia
        {
            //Horario primeraHora, matinal, mediodia, tarde, noche = new Horario();
            Horario[] horario = new Horario[5];
            string nombreDia;
            public Dia()
            {
                for (int i = 0; i < 5; i++)
                {
                    horario[i] = new Horario();
                }

                horario[0].establecerHorarioIniFin(8, 10);
                horario[1].establecerHorarioIniFin(10, 14);
                horario[2].establecerHorarioIniFin(14, 16);
                horario[3].establecerHorarioIniFin(16, 20);
                horario[4].establecerHorarioIniFin(20, 22);
            }
            // ----------------------------------------METODOS DE LA CLASE DIA ----------------------------------------
            public void darNombresSemana(string nombre)
            {
                nombreDia = nombre;
            }
            public string getNombreDia()
            {
                return nombreDia;
            }
            public void addPrograma(int horario, int minutos, string nombre, string tipoPrograma) //AÑADE PROGRAMA TV NUEVO
            {
                this.horario[horario].addPrograma(minutos, nombre, tipoPrograma);
            }

            public int accederHorario()
            {
                return 0;
              //  return primeraHora.decirIni();
            }

            public void remPrograma(int horario) //BORRA UN PROGRAMA TV
            {
                this.horario[horario].remPrograma();
            }
            public void modMinutos(int horario, int mins) //AÑADIR O QUITAR MINUTOS DE PROGRAMA TV
            {
                this.horario[horario].modMinutos(mins);
            }
        }

        class Horario
        {
            string nombre, tipoContenido;
            int duracion, horarioInicio, horarioFin;

            // ----------------------------------------METODOS DE LA CLASE HORARIO ----------------------------------------
            public int decirIni()
            {
                return horarioInicio;
            }
            public void establecerHorarioIniFin(int ini, int fin)
            {
                horarioInicio = ini;
                horarioFin = fin;
            }
            public void addPrograma(int minutos, string nombre, string tipoPrograma) //AÑADE PROGRAMA TV NUEVO
            {
                this.nombre = nombre;
                duracion = minutos;
                tipoContenido = tipoPrograma;
            }
            public void remPrograma() //BORRA UN PROGRAMA TV
            {
                nombre = "NADA";
                duracion = 0;
                tipoContenido = "NADA";
            }
            public void modMinutos(int mins) //AÑADIR O QUITAR MINUTOS DE PROGRAMA TV
            {
                duracion += mins;
            }
        }


    }

}
