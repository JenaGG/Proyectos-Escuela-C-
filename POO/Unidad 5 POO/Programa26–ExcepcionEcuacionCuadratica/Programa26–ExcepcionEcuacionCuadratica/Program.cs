using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa26_ExcepcionEcuacionCuadratica
{
    class Program
    {
        //creación de la excepción.
        class ExcepcionEcuacionCuadratica : ApplicationException
        {
            //constructor
            //usar ":base("<mensaje de excepción>")" despues de la estructura
            public ExcepcionEcuacionCuadratica() :
                base("La Ecuación cuadrática NO tiene solución!!!")
            { }
        }
        static void Main(string[] args)
        {
            //variables
            int a, b, c, x1, x2;
            double D;
            char t ;
            //menu
            do
            {
                Console.WriteLine("==Menu== \nEcuación Cuadrática");
                Console.WriteLine("Digite una opcion");
                Console.WriteLine("a) Calcular Valores para una ecuacion cuadratica");
                Console.WriteLine("b) Salir del Programa.");
                Console.WriteLine("Opción: ");
                t = char.Parse(Console.ReadLine());
                //opciones del menu
                switch (t)
                {
                    case 'a':
                        try
                        {
                            //captura de datos
                            Console.WriteLine("Alimenta el valor del primer término (a): ");
                            a = int.Parse(Console.ReadLine());
                            Console.WriteLine("Alimenta el valor del segundo término (b): ");
                            b = int.Parse(Console.ReadLine());
                            Console.WriteLine("Alimenta el valor del tercer término (c): ");
                            c = int.Parse(Console.ReadLine());
                            D = Math.Pow(b, 2) - 4 * a * c;
                            //manejo de las excepciones
                            if (D < 0)
                            {
                                //escribir las palabras reservadas "throw new" seguidas del nombre de la excepcion

                                throw new ExcepcionEcuacionCuadratica(); //Impresion de la excepcion
                            }
                            else
                            {
                                x1 = (int)(-b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / 2 * a;
                                x2 = (int)(-b - Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / 2 * a;
                                Console.WriteLine("Resultados de la siguiente ecuacion cuadratica " + a + "x^2 +" + b + "x + " + c+" son:");
                                Console.WriteLine("x1: " + x1);
                                Console.WriteLine("x2: " + x2);
                            }
                        }
                        //aplicacion de las excepciones
                        catch (ExcepcionEcuacionCuadratica e)
                        {
                            Console.WriteLine("\nMensaje del error: " + e.Message);
                            Console.WriteLine("\nRuta del error: " + e.StackTrace);
                            Console.WriteLine("\npresione <enter> para continuar...");
                            Console.ReadKey();
                        }
                        catch (FormatException f)
                        {
                            Console.WriteLine("\nMensaje del error: " + f.Message);
                            Console.WriteLine("\nRuta del error: " + f.StackTrace);
                            Console.WriteLine("\npresione <enter> para continuar...");
                            Console.ReadKey();
                        }
                        finally
                        {
                            Console.WriteLine("\nEl finally siempre se ejecuta.");
                            Console.WriteLine("\npresione <enter> para continuar...");
                            Console.ReadKey();
                            Console.Clear();
                        }
                        break;
                    case 'b':
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Seleccione una opcion valida");
                        break;
                }
            }
            while (t != 'b');
        }
    }
}
