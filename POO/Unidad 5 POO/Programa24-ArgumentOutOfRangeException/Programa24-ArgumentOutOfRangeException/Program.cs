using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa24_ArgumentOutOfRangeException
{
    class Program
    {
        static void Main(string[] args)
        {
            string t;
            do
            {
                Console.WriteLine("==Menu== \nElevar Número al Cubo");
                Console.WriteLine("Digite una de las siguientes opciones");
                Console.WriteLine("a) Calcular Función Matemática.");
                Console.WriteLine("b) Salir del Programa.");
                Console.Write("Opción: ");
                t = Console.ReadLine();
                switch (t)
                {
                    case "a":
                        try
                        {   //declaración variables auxiliares y captura de datos
                            int Base;
                            double Resultado;
                            Console.Write("Alimenta un número entero pequeño: ");
                            Base = Int16.Parse(Console.ReadLine());
                            if (Base < 100)
                            {
                                Resultado = Math.Pow(Base, 3);
                                Console.WriteLine("\nEl resultado de evaluar {0} al cubo es: {1}", Base, Resultado);
                                Console.WriteLine("\nPresione <enter> para continuar...");
                                Console.ReadKey();
                            }
                            else throw new ArgumentOutOfRangeException(); //lanzamiento excepción
                        }

                        catch (ArgumentOutOfRangeException ax)
                        {
                            Console.WriteLine("\nMensaje del Error: " + ax.Message);
                            Console.WriteLine("\nRuta del Error: " + ax.StackTrace);
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
                            Console.WriteLine("\nPresione <enter> para continuar...");
                            Console.ReadKey();
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
            while (t!= "b");
        }
    }
}
