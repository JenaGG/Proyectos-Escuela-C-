using System;

namespace Practica_Do_While
{
    class Program
    {
        static void Main(string[] args)
        {
            int c=0;
            string tecla;

            do
            {
                Console.WriteLine("Presione una tecla cualquiera"+"\nTeclas de opciones \nA)Dar de alta \nB)Dar de baja \nC)Consultar \nS para Salir");
                tecla=Console.ReadLine();
                if (tecla=="a"||tecla=="A")
                {
                    Console.WriteLine("Estas en la opcion A dar de alta");
                    c=0;
                }
                if (tecla=="b"||tecla=="B")
                {
                    Console.WriteLine("Estas en la opcion B dar de baja no lo haga compa");
                    c=0;
                }
                if (tecla=="c"||tecla=="C")
                {
                    Console.WriteLine("Estas en la opcion C Consultar");
                    c=0;
                }
                if (tecla=="s"||tecla=="S")
                {
                    c=1;
                    Console.WriteLine("Adios");
                }

            } while (c==0);

            do
            {
             Console.WriteLine("Presione una tecla");
             tecla=Console.ReadLine();
                if (tecla=="s")
            {
                c=1;
            }

            } while (c==0);
            

            do
            {
                Console.WriteLine(c);
                if (c==3)
                {
                    Console.WriteLine("Estas en el numero 3 ");
                }
                c++;
            } while (c<5);
           
        }
    }
}
