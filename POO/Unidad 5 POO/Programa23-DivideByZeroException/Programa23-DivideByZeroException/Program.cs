using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa23_DivideByZeroException
{
    class Program
    {   //método estático
        static double Divide(double x, double y)
        {
            if (y == 0)
                throw new DivideByZeroException(); //lanzamiento excepción
            else return x / y;
        }

        static void Main(string[] args)
        {
            //declaración variables auxiliares
            double a, b, resultado;
            string t;
            do
            {
                Console.WriteLine("===Menu===  \nDivisión Números Tipo Doble");
                Console.WriteLine("Digite una opccion");
                Console.WriteLine("a) Calcular Operación aritmética.");
                Console.WriteLine("b) Salir del Programa.");
                Console.Write("Opción: ");
                t = Console.ReadLine();
                switch (t)
                {
                    case "a":
                        try
                        {   //captura de datos
                            Console.Write("\nAlimenta el valor del 1er número: ");
                            a = Double.Parse(Console.ReadLine());
                            Console.Write("\nAlimenta el valor del 2do número: ");
                            b = Double.Parse(Console.ReadLine());

                            //llamada al método
                            resultado = Divide(a, b);

                            //despliegue de resultado
                            Console.WriteLine("\nEl número {0} dividido por {1} da como resultado: {2}", a, b, resultado);
                            Console.Write("\nPresione <enter> para continuar...");
                            Console.ReadKey();
                        }

                        catch (DivideByZeroException d)
                        {
                            Console.WriteLine("\nMensaje del Error: " + d.Message);
                            Console.WriteLine("\nRuta del Error: " + d.StackTrace);
                            Console.Write("\nPresione <enter> para continuar...");
                            Console.ReadKey();
                        }

                        catch (FormatException fx)
                        {
                            Console.WriteLine("\nMensaje del Error: " + fx.Message);
                            Console.WriteLine("\nRuta del Error: " + fx.StackTrace);
                            Console.Write("\nPresione <enter> para continuar...");
                            Console.ReadKey();
                        }

                        finally
                        {
                            Console.WriteLine("\n\nEl bloque finally siempre se ejecuta.");
                            Console.Write("\nPresione <enter> para continuar...");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                    case "b":
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Ingrese opcion valida");
                        break;
                }
            }
            while (t != "b");
        }
    }
}