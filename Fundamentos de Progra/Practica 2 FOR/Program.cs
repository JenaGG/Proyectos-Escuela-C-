using System;

namespace Practica_2_FOR
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,ini,f,n,r;
            Console.WriteLine("Digite la tabla que quiere consultar");
            n=Int32.Parse(Console.ReadLine());
            Console.WriteLine("Desde que numero quiere iniciar?");
            ini=Int32.Parse(Console.ReadLine());
            Console.WriteLine("Hasta que numero quiere llegar?");
            f=Int32.Parse(Console.ReadLine());

            for(i=ini; i<=f; i++)
            {
                r=i*n;
                Console.WriteLine(n+" * "+i+" = "+r);
            }
        }
    }
}
