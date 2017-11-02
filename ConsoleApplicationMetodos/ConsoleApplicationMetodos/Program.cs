using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationMetodos
{
    class Program
    {
        // Llamada tradicional
        static public int sumar(ref int n1, int n2)
        {
            n1 = 100;
            return n1 + n2;
        }
        // Llamada con REF
        static public void sumarRef(int n1, int n2, ref int sum)
        {
            sum = n1 + n2;
        }
        // Llamada con OUT
        static public void sumarOut(int n1, int n2, out int sum)
        {
            sum = 0; //Si no se inicia, te peta.
            n1 = n2;
        }

        static public int truncar(double numero3) // EJERCICIO A
        {
            //return Math.Truncate (dop1);
            return Convert.ToInt32(Math.Truncate(numero3));
        }

        static public void truncar1(double dop1, ref int entero1) // EJERCICIO B
        {
            entero1 = Convert.ToInt32(Math.Truncate(dop1));
        }

        static public void truncar2(ref double dop1) // EJERCICIO C
        {
            dop1 = Math.Truncate(dop1);
        }

        static public double truncar3(double dop2, int entero2) // EJERCICIO D
        {
            int decimales=1; // 1 para ir multiplicando por 10 cada vuelta.
            if(entero2 != 0)
                for (int i = 0; i < entero2; i++)
                    decimales = decimales * 10;
            return Math.Truncate(dop2 * decimales) / decimales;
        }

        static public void truncar4(double op1, int op2, out double op3) // EJERCICIO E
        {
            op3 = 0;
            int decimales = 1; // 1 para ir multiplicando por 10 cada vuelta.
            if (op2 != 0)
                for (int i = 0; i < op2; i++)
                    decimales = decimales * 10;
            op3 = Math.Truncate(op1 * decimales) / decimales;

        }

        static public void truncar5(ref double dop2, int op2) // EJERCICIO F
        {
            int decimales = 1; // 1 para ir multiplicando por 10 cada vuelta.
            if (op2 != 0)
                for (int i = 0; i < op2; i++)
                    decimales = decimales * 10;
            dop2 = Math.Truncate(dop2 * decimales) / decimales;
        }

        static void Main(string[] args)
        {
           









            // En variable el decimal vale con punto, pero por consola de windows tiene que ser con ","
            int entero1=0, entero2, resultado;
            double dop1, dop2, dResultado, op3;

            /*
            Console.WriteLine("Introduce numero 1: ");
            entero1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Introduce numero 2: ");
            entero2 = Int32.Parse(Console.ReadLine());
            */
            Console.WriteLine(" A,B,C: Introduce numero real: ");
            dop1 = Double.Parse(Console.ReadLine());
            Console.WriteLine(" D,E,F: Introduce numero decimal: ");
            dop2 = Double.Parse(Console.ReadLine());
            Console.WriteLine(" Ahora el número de decimales que deje");
            entero2 = Int32.Parse(Console.ReadLine());

            /*
                        //Llamada tradicional
                        resultado = sumar(ref entero1, entero2);
                        Console.WriteLine("La suma es: " + resultado);
                        Console.ReadKey();
            */

            //Llamada con ref
            resultado = 0;
            /*
            sumarRef(entero1, entero2, ref resultado);
            Console.WriteLine("La suma es: " + resultado);
            Console.WriteLine("El número 1 es: " + entero1);
            */
            resultado = truncar(dop1);
            Console.WriteLine("Ejercicio A, se ha devuelto truncado y vale: " + resultado);
            truncar1(dop1, ref entero1);
            Console.WriteLine("Ejercicio B: En el método mete el valor truncado: " + entero1);
            truncar2(ref dop1);
            Console.WriteLine("Ejercicio C: Truncado por referencia: " + dop1);
            dResultado = truncar3(dop2, entero2);
            Console.WriteLine("Ejercicio D: Truncado con decimales que se indique: " + dResultado);
            truncar4(dop2, entero2, out op3);
            Console.WriteLine("Ejercicio E: Truncado con decimales que se indique a un segundo parámetro: " + op3);
            truncar5(ref dop2, entero2);
            Console.WriteLine("Ejercicio F: Truncado con decimales que se indique sobre el primer valor: " + dResultado);

            /*
                        double floatNumber;

                        floatNumber = 32.7865;
                        // Displays 32      
                        Console.WriteLine(Math.Truncate(floatNumber));
                        
             */

            Console.ReadKey();


   
        }

    }
}
