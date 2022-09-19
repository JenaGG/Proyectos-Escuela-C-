using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volumenes
{
    public class Esfera
    {
        //campos
        double volumen;
        float radio;
        //constructor
        public Esfera(float radio)
        {
            this.radio = radio;
        }
        //metodo
        public double calcularVolumen()
        {
            return volumen = (4 / 3) * Math.PI * Math.Pow(radio, 3);
        }
        public void desplegarVolumen()
        {
            Console.WriteLine("==Esfera==");
            Console.WriteLine("El radio de la Esfera es: " + radio);
            Console.WriteLine("El Volumen de la Esfera es: " + volumen);
        }
        //destructor
        ~Esfera()
        {
            Console.WriteLine("Memoria Liberada Objeto Esfera ");
        }
    }
    public class Cubo
    {
        //campos
        double volumen;
        float lado;
        //constructor
        public Cubo(float lado)
        {
            this.lado = lado;
        }
        //metodo
        public double calcularVolumen()
        {
            return volumen = Math.Pow(lado, 3);
        }
        public void desplegarVolumen()
        {
            Console.WriteLine("==Cubo==");
            Console.WriteLine("El lado del Cubo es: " + lado);
            Console.WriteLine("El volumen del Cubo es: " + volumen);
        }
        //destructor
        ~Cubo()
        {
            Console.WriteLine("Memoria Liberada Objeto Cubo ");
        }
    }
    public class Cilindro
    {
        //campos
        double volumen;
        float radio, altura;
        //constructor
        public Cilindro(float radio, float altura)
        {
            this.radio = radio;
            this.altura = altura;
        }
        //metodo
        public double calcularVolumen()
        {
            return volumen = Math.PI * Math.Pow(radio, 2) * altura;
        }
        public void desplegarVolumen()
        {
            Console.WriteLine("==Cilindro==");
            Console.WriteLine("El radio del Cilindro es: " + radio);
            Console.WriteLine("La altura del Cilindro es: " + altura);
            Console.WriteLine("El volumen del Cilindro es: " + volumen);
        }
        //destructor
        ~Cilindro()
        {
            Console.WriteLine("Memoria Liberada Objeto Cilindro ");
        }
    }
    public class Cono
    {
        //campos
        double volumen;
        float radio, altura;
        //constructor
        public Cono(float radio, float altura)
        {
            this.radio = radio;
            this.altura = altura;
        }
        //metodos
        public double calcularVolumen()
        {
            return volumen = (Math.PI * Math.Pow(radio, 2) * altura) / 3;//modifique la formula porque si ponia (1/3)*Math.PI * Math.Pow(radio,2) * altura me daba 0
        }
        public void desplegarVolumen()
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
}

