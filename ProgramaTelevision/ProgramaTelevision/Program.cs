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

        static public void resolver(int seleccion, ref Semana semana)
        {
            int elegirDia, elegirHorario, duracion;
            string nombreSerie, tipo;

            switch (seleccion)
            {
                case 1:
                    //día, horario y datos del programa

                    Console.WriteLine("Di el día que quieres crear el programa, lunes-0, martes-1, etc.:");
                    elegirDia = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Di el horario en el que quieras el programa, primera hora-0, matinal-1, etc.: ");
                    elegirHorario = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Nombre de la serie: ");
                    nombreSerie = Console.ReadLine();
                    Console.WriteLine("Tipo de contenido: ");
                    tipo = Console.ReadLine();
                    Console.WriteLine("Duración de programa: ");
                    duracion = Int32.Parse(Console.ReadLine());

                    semana.dia[elegirDia].horario[elegirHorario].nuevoPrograma(nombreSerie, tipo, duracion);
                    break;
                case 2:
                    //pedirán los datos de día y horario, y se eliminarán los datos del programa para ese horario.

                    Console.WriteLine("Di el día que quieres borrar el programa, lunes-0, martes-1, etc.:");
                    elegirDia = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Di el horario en el que quieras borrar el programa, primera hora-0, matinal-1, etc.: ");
                    elegirHorario = Int32.Parse(Console.ReadLine());

                    semana.dia[elegirDia].horario[elegirHorario].borrarPrograma();
                    break;
                case 3:
                    /*datos de día y horario, y los 
minutos que se quiere aumentar o disminuir*/
                    Console.WriteLine("Di el día que quieres modificar el programa, lunes-0, martes-1, etc.:");
                    elegirDia = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Di el horario en el que quieras modificar el programa, primera hora-0, matinal-1, etc.: ");
                    elegirHorario = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Di los minutos que quieres añadir o quitar, si quieres quitar introduce un número negativo: ");
                    duracion = Int32.Parse(Console.ReadLine());

                    semana.dia[elegirDia].horario[elegirHorario].modDuracion(duracion);
                    break;
                case 4:
                    semana.mostrarSemana();
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
                resolver(seleccion, ref semana); //Según elijas, resolverá la opción elegida.
            }
            //Console.ReadKey();






        }
    }
}
