using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaTelevision
{
    class Program
    {
        /*
• Mostrar programación semanal: Al pulsar la opción,
 se mostrará la programación de la 
semana completa (lunes a viernes).  

• Mostrar programación diaria: Al pulsar la opción, se pedirá el día de la semana que se quiere consultar. Seguidamente, se mostrará la programación del día elegido. 

• Mostrar contenidos por día: Al pulsar la opción, se pulsará el día de la semana que se desea consultar. A continuación, se mostrará la cantidad de minutos que se destina ese día a cada uno de los contenidos del programa*/
        static public void decirHoraIni(Semana semana)
        {
           // Console.WriteLine(semana.getSemana());
        }

        static public void menu(ref int seleccion)
        {
            Console.WriteLine("Programa para controlar y modificar emisiones de los programas de TV durante la semana.\n");
            Console.WriteLine("Por favor, eliga una de las siguientes opciones:");
            Console.WriteLine("1. Asignar un programa nuevo a un día y horario concreto\n" +
                              "2. Eliminar un programa\n" +
                              "3. Modificar los minutos de un programa\n" +
                              "4. Mostrar programación semanal\n" +
                              "5. Mostrar programación diaria\n" +
                              "6. Mostrar contenidos por día\n" +
                              "7. Salir\n");
            Console.WriteLine("Selección: ");
            seleccion = Int32.Parse(Console.ReadLine());
        }

        static public void resolver(int seleccion)
        {

            switch (seleccion)
            {
                case 1:
                    //día, horario y datos del programa

                   
                    break;
                case 2:
                    //pedirán los datos de día y horario, y se eliminarán los datos del programa para ese horario.
                  
                    break;
                case 3:
                   
                    break;
                case 4:
                    
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    break;
            }

        }
        static void Main(string[] args)
        {
            int seleccion = 0;

            Dia lunes = new Dia("Lunes");
            Dia martes = new Dia("Martes");
            Dia miercoles = new Dia("Miércoles");
            Dia jueves = new Dia("Jueves");
            Dia viernes = new Dia("Viernes");

            //decirHoraIni(semana);
            while (seleccion != 7)
            {
                menu(ref seleccion); //Muestra las opciones.
                resolver(seleccion); //Según elijas, resolverá la opción elegida.
            }
            //Console.ReadKey();






        }
    }
}
