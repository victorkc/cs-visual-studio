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

        static public void resolver(ref Semana semana, int seleccion)
        {
            int mins = 0;

            switch (seleccion)
            {
                case 1:
                    //día, horario y datos del programa
                    int dia, horario, minutos;
                    string nombre, tipoPrograma;
                    Console.WriteLine("Escribe el día que quieres guardar el programa (lunes=1, martes=2, etc.: ");
                    dia = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("En qué horario quieres guardar el programa? (Primera hora=1, matinal=2 etc.:");
                    horario = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Escribe el nombre del programa: ");
                    nombre = Console.ReadLine();
                    Console.WriteLine("Escribe el tipo de programa que es (informativo, serie, pelicula, etc.: ");
                    tipoPrograma = Console.ReadLine();
                    Console.WriteLine("Escribe los minutos que dura: ");
                    minutos = Int32.Parse(Console.ReadLine());

                    semana.addPrograma(dia, horario, minutos, nombre, tipoPrograma);
                    break;
                case 2:
                    //pedirán los datos de día y horario, y se eliminarán los datos del programa para ese horario.
                    Console.WriteLine("Escribe el día del que quieres borrar el programa (lunes=1, martes=2, etc.: ");
                    dia = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("En qué horario quieres borrar el programa? (Primera hora=1, matinal=2 etc.:");
                    horario = Int32.Parse(Console.ReadLine());

                    semana.remPrograma(dia, horario);
                    break;
                case 3:
                    /*se pedirán los datos de día y horario, y los minutos que se quiere aumentar o disminuir*/
                    Console.WriteLine("Escribe el día del que quieres modificar el programa (lunes=1, martes=2, etc.: ");
                    dia = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("En qué horario quieres modificar el programa? (Primera hora=1, matinal=2 etc.:");
                    horario = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Cuántos minutos quieres aumentaro disminuir del programa? (escribe con signo negativo en caso de restar minutos: ");
                    mins = Int32.Parse(Console.ReadLine());

                    semana.modMinutos(dia, horario, mins);
                    break;
                case 4:
                    
                    semana.getSemana();
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
            Semana semana = new Semana();
            //decirHoraIni(semana);
            while (seleccion != 7)
            {
                menu(ref seleccion); //Muestra las opciones.
                resolver(ref semana, seleccion); //Según elijas, resolverá la opción elegida.
            }
            //Console.ReadKey();






        }
    }
}
