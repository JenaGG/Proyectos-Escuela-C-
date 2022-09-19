using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa16_PolimorfismoClaseAnimal
{
    class Program
    {
        //clase base
        class Animal
        {
            //método
            public virtual void Desplazarse()
            {
                //vacio
            }
            //destructor
            ~Animal()
            {
                Console.WriteLine("Memoria Liberada clase base Animal ");
            }
        }
        //clase derivada 1
        class Mamífero : Animal
        {
            //campos
            string nombre;
            //constructor
            public Mamífero(string nombre)
            {
                this.nombre = nombre;
            }
            //métodos
            public override void Desplazarse()
            {
                Console.WriteLine("Hola mi nombre es " + nombre + " y me desplazo caminando");
                base.Desplazarse();
            }
            //destructor
            ~Mamífero()
            {
                Console.WriteLine("Memoria Liberada clase derivada Mamífero " + nombre);
            }
        }
        //clase derivada 2
        class Ave : Animal
        {
            //campos
            string nombre;
            //constructor
            public Ave(string nombre)
            {
                this.nombre = nombre;
            }
            //métodos
            public override void Desplazarse()
            {
                Console.WriteLine("Hola mi nombre es " + nombre + " y me desplazo volando");
                base.Desplazarse();
            }
            //destructor
            ~Ave()
            {
                Console.WriteLine("Memoria Liberada clase derivada Ave " + nombre);
            }
        }
        //clase derivada 3
        class Pez : Animal
        {
            //campos
            string nombre;
            //constructor
            public Pez(string nombre) { this.nombre = nombre; }
            //métodos
            public override void Desplazarse()
            {
                Console.WriteLine("Hola mi nombre es " + nombre + " y me desplazo nadando");
                base.Desplazarse();
            }
            //destructor
            ~Pez()
            {
                Console.WriteLine("Memoria Liberada clase derivada Pez " + nombre);
            }
        }
        //clase derivada 4
        class Reptil : Animal
        {
            //campos
            string nombre;
            //constructor
            public Reptil(string nombre)
            {
                this.nombre = nombre;
            }
            //métodos
            public override void Desplazarse()
            {
                Console.WriteLine("Hola mi nombre es " + nombre + " y me desplazo reptando");
                base.Desplazarse();
            }
            //destructor
            ~Reptil()
            {
                Console.WriteLine("Memoria Liberada clase derivada Reptil " + nombre);
            }
        }
        static void Main(string[] args)
        {
            //variable auxiliar
            string nombre;
            //captura de datos y crear los bjetos correpondiente, la variable nombre se actualiza en cada caso  

            Console.WriteLine("==Animales==");
            Console.Write("Favor de ingresar el nombre para el mamífero: ");
            nombre = Console.ReadLine();
            Mamífero perro = new Mamífero(nombre);
            Console.Write("Favor de ingresar el nombre para el ave: ");
            nombre = Console.ReadLine();
            Ave guajolote = new Ave(nombre);
            Console.Write("Favor de ingresar el nombre para el pez: ");
            nombre = Console.ReadLine();
            Pez mojarra = new Pez(nombre);
            Console.Write("Favor de ingresar el nombre para el reptil: ");
            nombre = Console.ReadLine();
            Reptil lagartija = new Reptil(nombre);
            Console.Clear();

            //despliegue y ejecución de los métodos
            Console.WriteLine("Los Animales te están saludando!!!\n");
            perro.Desplazarse();
            guajolote.Desplazarse();
            mojarra.Desplazarse();
            lagartija.Desplazarse();
            Console.WriteLine("\nPresione cualquier tecla para salir");
            Console.ReadKey();
        }
    }
}
