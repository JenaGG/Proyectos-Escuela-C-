using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa25_NegativosException
{
    class Program
    {
        class NegativosException : ApplicationException //clase nueva excepción
        {
            //constructor de la clase
            public NegativosException()
                : base("NO se puede calcular el seno de un Ángulo Negativo!!!")
            { }
        }

        static void Main(string[] args)
        {
            //declaración de variables
            char t;
            int Angulo;
            double Resultado;
            do
            {
                Console.WriteLine("==Menu== \nSeno de un Angulo");
                Console.WriteLine("Digite una opcion ");
                Console.WriteLine("a) Calcular Función Matemática.");
                Console.WriteLine("b) Salir del Programa.");
                Console.Write("Opción: ");
                t = char.Parse(Console.ReadLine());

                switch (t)
                {
                    case 'a':
                        try
                        {
                            //captura de datos
                            Console.Write("Alimenta un numero entero: ");
                            Angulo = Int32.Parse(Console.ReadLine());
                            if (Angulo < 0)
                            {
                                throw new NegativosException(); //lanzamiento excepción
                            }
                            else
                            {
                                //llamada función matemática
                                Resultado = Math.Sin(Angulo);

                                //despliegue del resultado
                                Console.WriteLine("El Seno del Ángulo {0} es : {1}", Angulo, Resultado);
                                Console.WriteLine("\npresione <enter> para continuar...");
                                Console.ReadKey();
                            }

                        }
                        catch (NegativosException n)
                        {
                            Console.WriteLine("\nMensaje del error: " + n.Message);
                            Console.WriteLine("\nRuta del error: " + n.StackTrace);
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
                        Console.WriteLine("Selecciones una opcion valida");
                        break;
                }
            }
            while (t != 'b');
        }
    }
}
