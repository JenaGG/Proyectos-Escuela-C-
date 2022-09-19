using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa14_Reutilizacion_Campos_Metodos
{
    class Program
    {
        class Figuras
        {
            public float Base, Altura, area, perimetro;
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
            ~Figuras()
            {
                Console.WriteLine("Memoria Objeto Figuras Liberada");
            }
        }
        class Triangulo:Figuras
        {
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
                Console.WriteLine("Datos Triangulo");
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
        class Rectangulo : Figuras
        {
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
                Console.WriteLine("Datos Rectangulo");
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
            float b1, a1;
            Console.WriteLine("Datos para calculo del triangulo");
            Console.WriteLine("Ingresar su base");
            b1 = Console.Read();
            Console.WriteLine("Ingrese su altura");
            a1 = Console.Read();
            Triangulo c = new Triangulo(b1,a1);
        

        }
    }
}
