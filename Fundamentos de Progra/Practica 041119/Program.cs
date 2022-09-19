using System;

namespace Practica_041119
{
    class Program
    {
        static void Main(string[] args)
        {
            int res;
            Program.captura("gena ",21);
            Console.WriteLine(suma(5,2));
            res=suma(5,2);
            Console.WriteLine(res*5);
        }
        static void captura(String name, int edad)
        {
            Console.WriteLine("Hola "+name+edad);
        }
        static int suma(int a, int b)
        {
            int res;
            res= a-b;
            return res;
        }

    }
}
