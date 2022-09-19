using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa20_IndexOutOfRangeException
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaración arreglo números enteros
            int[] arreglo = new int[10];
            //creación objeto clase random
            Random R = new Random();

            try
            {
                //generación aleatoria del vector
                for (int x = 0; x < arreglo.Length; x++)
                {
                    arreglo[x] = R.Next(10, 99);
                }

                //ordenamiento del vector
                Array.Sort(arreglo);

                //despliegue del vector ordenado
                Console.WriteLine("\n\nARREGLO ORDENADO");
                for (int x = 0; x < arreglo.Length; x++)
                {
                    Console.WriteLine("\t{0}.-{1}", x + 1, arreglo[x]);
                }
                Console.Write("\npresione <enter> para continuar...");
                Console.ReadKey();

                arreglo[15] = 12345; //acceso indice fuera de rango provoca error
            }
            catch (IndexOutOfRangeException i)
            {
                Console.WriteLine("\n\nMensaje del Error: " + i.Message);
                Console.WriteLine("\nRuta del Error: " + i.StackTrace);
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
