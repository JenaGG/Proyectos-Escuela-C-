using System;

namespace Practica_3_For
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, a, b;
            for(i=100; i>=0; i-=10)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Introduzca 2 numeros");
            a=Int32.Parse(Console.ReadLine());
            b=Int32.Parse(Console.ReadLine());
            if(a>b)
            {
                Console.WriteLine(a+" es mayor que "+b);
            }
            if(a<b)
            {
                Console.WriteLine(b+" es mayor que "+a);
            }
            if(a==b)
            {
                Console.WriteLine("Son iguales");
            }
        }
    }
}
