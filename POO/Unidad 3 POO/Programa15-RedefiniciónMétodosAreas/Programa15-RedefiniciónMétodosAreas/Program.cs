using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa15_RedefiniciónMétodosAreas
{
    class Program
    {
        class Areas
        {
            public float radio;
            double area;

            public Areas(float radio)
            {
                this.radio=radio;
            }
            public virtual double CalcularArea()
            {
                return area=0;
            }
            public virtual void ImprimeArea()
            {
                //vacío }
            }
            ~Areas()
            {
                Console.WriteLine("Memoria Liberada Objeto Areas");
            }
        }
        class Circulo:Areas
        {
            double area;
            public Circulo(float radio) : base(radio)
            {

            }

            public override double CalcularArea()
            {
                return area = Math.PI * Math.Pow(radio, 2);
            }
            public override void ImprimeArea()
            {
                Console.WriteLine("===Datos del circulo===");
                Console.WriteLine("El radio es: " + radio);
                Console.WriteLine("El areas es: " + area);
            }
            ~Circulo()
            {
                Console.WriteLine("Memoria Liberada Objeto Circulo");
            }
        }
        class Esfera : Areas
        {
            double area;
            public Esfera(float radio):base(radio)
            {

            }
            public override double CalcularArea()
            {
                return area=4 * Math.PI * Math.Pow(radio, 2);
            }
            public override void ImprimeArea()
            {
                Console.WriteLine("===Datos de la esfera===");
                Console.WriteLine("El radio es: " +radio);
                Console.WriteLine("El areas es: "+ area);
            }
            ~Esfera()
            {
                Console.WriteLine("Memoria Liberada Objeto Esfera");
            }
        }
        class Cilindro:Areas
        {
            double area;
            public float altura;
            public Cilindro(float altura, float radio):base(radio)
            {
                this.altura = altura;
            }
            public override double CalcularArea()
            {
                return area= 2 * Math.PI * radio * (altura + radio);
            }
            public override void ImprimeArea()
            {
                Console.WriteLine("===Datos del cilindro===");
                Console.WriteLine("El radio es: "+radio);
                Console.WriteLine("La altura es: "+ altura);
                Console.WriteLine("El areas es: "+ area);

            }
            ~Cilindro()
            {
                Console.WriteLine("Memoria Liberada Objeto Cilindro");
            }

        }
        static void Main(string[] args)
        {
            float rad, alt;
            Console.Write("Ingrese el radio a calcular: ");
            rad= float.Parse(Console.ReadLine());
            Console.Clear();
            Areas O1 = new Areas(rad);
            Circulo O1D = new Circulo(O1.radio);
            O1D.CalcularArea();
            O1D.ImprimeArea();
            Console.WriteLine("Presione enter para avanzar a la siguiente figura");
            Console.ReadKey();
            Console.Clear();
            Esfera O2D = new Esfera(O1.radio);
            O2D.CalcularArea();
            O2D.ImprimeArea();
            Console.WriteLine("Presione enter para avanzar a la siguiente figura");
            Console.ReadKey();
            Console.Clear();
            Console.Write("Ingrese la altura a calcular: ");
            alt = float.Parse(Console.ReadLine());
            Console.Clear();
            Cilindro O3D = new Cilindro(alt, O1.radio);
            O3D.CalcularArea();
            O3D.ImprimeArea();
            Console.WriteLine("Presione una tecla para finalizar");
            Console.ReadKey();
            Console.Clear();

        }
    }
}
