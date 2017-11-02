using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static public void OrdenarTabla()
        {
            string[] lista = { "Pepe", "Ana", "juan" };

            for (int i = 0; i < lista.Length - 1; i++)
                for (int j = 0; j < (lista.Length - 1) - i; j++)
                    if (lista[j].CompareTo(lista[j + 1]) > 0)
                        {
                // intercambiar j --> j+1
                string aux;
                aux = lista[j];
                lista[j] = lista[j + 1];
                lista[j + 1] = aux;

            }
        }
 

        static void Main(string[] args)
        {
            OrdenarTabla();

            /*int[] tabla = { 12, 23, 34, 5 };
            for (int i = 0; i < 4; i++)
                Console.WriteLine(tabla[i]);
            Console.ReadKey();

            foreach (int numero in tabla)

            if ((3.0 / 7) is System.Int32)
                Console.WriteLine("Es de tipo entero");
            else
                Console.WriteLine("No es del tipo entero");
            Console.ReadKey();
            */
        }
    }
}
