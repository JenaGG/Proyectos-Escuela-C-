using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa22_OverflowException
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables auxiliares
            byte num1, num2, suma;

            try
            {
                //captura de datos
                Console.Write("\nAlimenta el valor del 1er número: ");
                num1 = Byte.Parse(Console.ReadLine());
                Console.Write("\nAlimenta el valor del 2do número: ");
                num2 = Byte.Parse(Console.ReadLine());

                //suma de los 2 valores
                suma = (byte)(num1 + num2);

                //despliegue de resultado
                Console.WriteLine("\nEl resultado de la suma de los números tipo byte es: {0}", suma);
                Console.Write("\npresione <enter> para continuar...");
                Console.ReadKey();
            }

            catch (OverflowException s)
            {
                Console.WriteLine("\nMensaje del Error: " + s.Message);
                Console.WriteLine("\nRuta del Error: " + s.StackTrace);
                Console.Write("\npresione <enter> para continuar...");
                Console.ReadKey();
            }

            finally
            {
                Console.WriteLine("\n\nEl bloque finally siempre se ejecuta.");
                Console.Write("\nPresione <enter> para Salir del Programa...");
                Console.ReadKey();
            }
        }
    }
}




