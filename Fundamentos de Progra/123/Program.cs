using System;

namespace Practica_3_For
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Program.nm();
            Program.ciclo();
            Program.mmi();
        }    
        static void nm()
        {
            int num1, num2;
            Console.WriteLine("Numeros mayor de 2, Ingrese 2 numeros");
            num1=Int32.Parse(Console.ReadLine());
            num2=Int32.Parse(Console.ReadLine());
            if(num1>num2)
            {
                Console.WriteLine(num1+" es mayor que "+num2);  
            }
            else
            {
                Console.WriteLine(num2+" es mayor que "+num1);  
            }
        }
        static void ciclo()
        {
            int  i;
            for(i=100; i>=0; i-=10)
            {
                Console.WriteLine(i);
            }
        }
        static void mmi()
        {
            int a, b;
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
