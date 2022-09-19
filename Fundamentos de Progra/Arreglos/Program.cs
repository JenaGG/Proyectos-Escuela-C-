using System;

namespace Arreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            string []nombre;
            nombre=new string[5];
            for(int i=1;i<5;i++)
            {
            Console.WriteLine("Ingresa un nombre",+i);
            nombre[i]=Console.ReadLine();
            }
            for(int i=1; i<5; i++)
            {
                Console.WriteLine("Los nombres son {0}:{1}",+i,nombre[i]);
            }
        }
    }
}