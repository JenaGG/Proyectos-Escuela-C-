using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa_ejemplo_destructor_y_constructor_de
{
    class Program
    {
        //clase base
        class Animal
        {
            //destructor
            ~Animal()
            {
                Console.WriteLine("Liberado Animal ...");
            }
        }
        //clase derivada
        class Mamífero : Animal
        {
            //destructor clase derivada
            ~Mamífero()
            {
                Console.WriteLine("Liberado Mamífero ...");
            }
        }
        //clase derivada
        class Perro : Mamífero
        {
            //destructor clase derivada
            ~Perro()
            {
                Console.WriteLine("Liberado Perro ...");
            }
        }
        static void Main(string[] args)
        {
            Perro Fido = new Perro();
        }
    }
}
