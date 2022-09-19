using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa21_FormatException
{
        class Program
        {
            static void Main(string[] args)
            {
                //variables auxiliares
                int B, P;
                double R;

                try
                {
                    //captura de datos
                    Console.Write("\nAlimenta el valor de la base: ");
                    B = Int32.Parse(Console.ReadLine());
                    Console.Write("\nAlimenta el valor de la potencia: ");
                    P = Int32.Parse(Console.ReadLine());

                    //llamada función matemática
                    R = Math.Pow(B, P);

                    //despliegue de resultado
                    Console.WriteLine("\nEl resultado es: {0}", R);
                    Console.Write("\npresione <enter> para continuar...");
                    Console.ReadKey();
                }

                catch (FormatException f)
                {
                    Console.WriteLine("\nMensaje del Error: " + f.Message);
                    Console.WriteLine("\nRuta del Error: " + f.StackTrace);
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


