using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa17_AbstractaVolumenes
{
    class Program
    {
        //clase base
        public abstract class Figuras
        {
            // Atributos
            public int NumeroLados;
            public float radio, altura;
            public double volumen;
            // Métodos
            abstract public double calcularVolumen();
            abstract public void desplegarVolumen();
            //Destructor
            ~Figuras()
            {
                Console.WriteLine("Memoria Objeto Clase Base Figuras Liberada ");
            }
            //fin clase abstracta figuras
        }
        //clase derivada 1
        public class Esfera : Figuras
        {
            // Constructor
            public Esfera(float radio)
            {
                this.radio = radio;

            }
            // Implementación de Métodos Abstractos
            public override double calcularVolumen()
            {
                return volumen = (4 / 3) * Math.PI * Math.Pow(radio, 3);
            }
            public override void desplegarVolumen()
            {
                Console.WriteLine("==Esfera==");
                Console.WriteLine("El radio de la Esfera es: " +this.radio);
                Console.WriteLine("El Volumen de la Esfera es: " +this.volumen);
            }
            //destructor
            ~Esfera()
            {
                Console.WriteLine("Memoria Objeto Clase Derivada Esfera Liberada ");
            }//fin de la clase derivada esfera
        }
        //clase derivada 2
        public class Cubo : Figuras
        {
            //Constructor
            public Cubo(int NumeroLados)
            {
                this.NumeroLados = NumeroLados;
            }
            //Implementación de métodos abstractos
            public override double calcularVolumen()
            {
                return volumen = Math.Pow(NumeroLados, 3);
            }
            public override void desplegarVolumen()
            {
                Console.WriteLine("==Cubo==");
                Console.WriteLine("El lado del Cubo es: " + NumeroLados);
                Console.WriteLine("El volumen del Cubo es: " + volumen);
            }
            //destructor
            ~Cubo()
            {
                Console.WriteLine("Memoria Liberada Objeto Cubo ");
            }

        }
        //clase derivada 3
        public class Cilindro : Figuras
        {
            //Constructor
            public Cilindro(float altura, float radio)
            {
                this.radio = radio;
                this.altura = altura;
            }
            //Implementación de métodos abstractos
            public override double calcularVolumen()
            {
                return volumen= Math.PI * Math.Pow(radio, 2) * altura; ;
            }
            public override void desplegarVolumen()
            {
                Console.WriteLine("==Cilindro==");
                Console.WriteLine("El radio del Cilindro es: " + radio);
                Console.WriteLine("La altura del Cilindro es: " + altura);
                Console.WriteLine("El volumen del Cilindro es: " + volumen);
            }
            ~Cilindro()
            {
                Console.WriteLine("Memoria Liberada Objeto Cilindro ");
            }
        }
        //clase derivada 4
        public class Cono : Figuras
        {
            //Constructor
            public Cono(float altura, float radio)
            {
                this.radio = radio;
                this.altura = altura;
            }
            //Implementación de métodos abstractos
            public override double calcularVolumen()
            {
                return volumen =  (Math.PI * Math.Pow(radio, 2) * altura)/3;//modifique la formula porque si ponia (1/3)*Math.PI * Math.Pow(radio,2) * altura me daba 0
            }
            public override void desplegarVolumen()
            {
                Console.WriteLine("==Cono==");
                Console.WriteLine("El radio del Cono es: " + radio);
                Console.WriteLine("La altura del Cono es: " + altura);
                Console.WriteLine("El volumen del Cono es: " + volumen);
            }
            //destructor
            ~Cono()
            {
                Console.WriteLine("Memoria Liberada Objeto Cono ");
            }
        }

        static void Main(string[] args)
        {
            //Variables auxiliares
            int l;
            float  r1, rci, aci, rco,aco;
            Console.WriteLine("==Volumen de Figuras==");
            //Captura datos esfera
            Console.WriteLine("Ingrese los valores para la Esfera:");
            Console.Write("Radio: ");
            r1 = Single.Parse(Console.ReadLine());
            //Creacion objeto esfera
            Esfera E = new Esfera(r1);
            E.calcularVolumen();
            E.desplegarVolumen();
            Console.Write("Presione cualquier tecla para ir a la siguiente figura");
            Console.ReadKey();
            Console.Clear();
            //captura datos cubo
            Console.WriteLine("Ingrese los valores para el Cubo:");
            Console.Write("Lado: ");
            l = int.Parse(Console.ReadLine());
            //Creacion objeto cubo
            Cubo C = new Cubo(l);
            C.calcularVolumen();
            C.desplegarVolumen();
            Console.Write("Presione cualquier tecla para ir a la siguiente figura");
            Console.ReadKey();
            Console.Clear();
            //captura datos cilindro
            Console.WriteLine("Ingrese los valores para el Cilíndro:");
            Console.Write("Radio: ");
            rci = Single.Parse(Console.ReadLine());
            Console.Write("Altura: ");
            aci = Single.Parse(Console.ReadLine());
            //Creación del objeto Cilíndro
            Cilindro CI = new Cilindro(rci, aci);
            CI.calcularVolumen();
            CI.desplegarVolumen();
            Console.Write("Presione cualquier tecla para ir a la siguiente figura");
            Console.ReadKey();
            Console.Clear();
            //Captura datos cono
            Console.WriteLine("Ingrese los valores para el Cono:");
            Console.Write("Radio: ");
            rco = Single.Parse(Console.ReadLine());
            Console.Write("Altura: ");
            aco = Single.Parse(Console.ReadLine());
            //Creación del objeto Cono
            Cono CO = new Cono(rco, aco);
            CO.calcularVolumen();
            CO.desplegarVolumen();
            Console.Write("Presione cualquier tecla para salir:");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
