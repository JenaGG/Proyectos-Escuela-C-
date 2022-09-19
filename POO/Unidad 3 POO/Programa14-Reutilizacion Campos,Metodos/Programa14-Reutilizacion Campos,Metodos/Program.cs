using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa14_Reutilizacion_Campos_Metodos
{
    class Program
    {
        //Clase Base
        class Figuras
        {
            //Campos de la clase base
            public float Base, Altura, area, perimetro;
            //Metodos clase base
            public float Area()
            {
                return area = 0;
            }
            public float Perimetro()
            {
                return perimetro = 0;
            }
            public void Resultado()
            {
                //vacio
            }
            //destructor clase base
            ~Figuras()
            {
                Console.WriteLine("Memoria Objeto Figuras Liberada");
            }
        }
        //clase derivada 1
        class Triangulo:Figuras
        {
            //Utilizamos new para liberar los campos de la clase porque no tenemos constructor en clase base
            new public float Base, Altura, area, perimetro;
            public Triangulo(float b1, float a1)
            {
                Base = b1;
                Altura = a1;
            }
            new public float Area()
            {
                return area = Base * Altura / 2;
            }
            new public float Perimetro()
            {
                return perimetro = Base * 3;
            }
            new public void Resultado()
            {
                Console.WriteLine("==Datos Triangulo==");
                Console.WriteLine("Su base es: " +Base);
                Console.WriteLine("Su altura es: "+Altura);
                Console.WriteLine("Su area es: "+area);
                Console.WriteLine("Su perimetro es: "+perimetro);
            }
            ~Triangulo()
            {
                Console.WriteLine("Memoria Liberada Objeto Triangulo");
            }

        }
        //clase derivada 2
        class Rectangulo : Figuras
        {
            //Utilizamos new para liberar los campos de la clase porque no tenemos constructor en clase base
            new public float Base, Altura, area, perimetro;
            public Rectangulo(float b2, float a2)
            {
                Base = b2;
                Altura = a2;
            }
            new public float Area()
            {
                return area = Base * Altura;
            }
            new public float Perimetro()
            {
                return perimetro = (Base + Altura) * 2;
            }
            new public void Resultado()
            {
                Console.WriteLine("==Datos Rectangulo==");
                Console.WriteLine("Su base es: " + Base);
                Console.WriteLine("Su altura es: " + Altura);
                Console.WriteLine("Su area es: " + area);
                Console.WriteLine("Su perimetro es: " + perimetro);
            }
            ~Rectangulo()
            {
                Console.WriteLine("Memoria Liberada Objeto Rectangulo");
            }

        }
        static void Main(string[] args)
        {
            //Captura de valores, creacion y ejecucion de metodos para objeto clase Triangulo
            float b1, a1;
            Console.WriteLine("Datos para calculo del triangulo");
            Console.Write("Ingresar su base: ");
            b1 = float.Parse(Console.ReadLine());
            Console.Write("Ingrese su altura: ");
            a1 = float.Parse(Console.ReadLine());
            Triangulo t = new Triangulo(b1,a1);
            t.Area();
            t.Perimetro();
            t.Resultado();
            Console.WriteLine("\nPresione cualquier tecla para avanzar a la siguiente figura ");
            Console.ReadKey();
            Console.Clear();

            //Captura de valores, creacion y ejecucion de metodos para objeto clase Rectangulo
            float b2, a2;
            Console.WriteLine("Datos para calculo del rectangulo");
            Console.Write("Ingresar su base: ");
            b2 = float.Parse(Console.ReadLine());
            Console.Write("Ingrese su altura: ");
            a2 = float.Parse(Console.ReadLine());
            Rectangulo r = new Rectangulo(b2, a2);
            r.Area();
            r.Perimetro();
            r.Resultado();
            Console.WriteLine("\nPresione cualquier tecla para salir");
            Console.ReadKey();
            Console.Clear();

        }
    }
}
