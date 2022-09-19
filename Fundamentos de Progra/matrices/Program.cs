using System;

namespace matrices
{
    class Program
    {
        static void Main(string[] args)
        {
            //Arreglos bidimensionales 
            int [,] A={{5,7,8,7},{5,7,8,7},{5,7,8,7}};
            for(int i=0; i<3;i++)
            {
                for(int j=0; j<4; j++)
                {
                    Console.Write(A[i,j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //practica
            int [,]matriz={{1,0,0,0},{0,1,0,0},{0,0,1,0},{0,0,0,1}};
            for(int i=0; i<4;i++)
            {
                for(int j=0; j<4; j++)
                {
                    Console.Write(matriz[j,i] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            
            //practica 2
            int [,]mat=new int[4,4];
            for(int i=0; i<4;i++)
            {
                for(int j=0; j<4; j++)
                {
                    if(i==j)
                    {
                        mat[j,i]=1;
                    }
                    else
                    {
                        mat[j,i]=0;
                    }
                        Console.Write(mat[j,i] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            //Ejercicio
            tipopersona[]persona= new tipopersona[5];
            persona[0].nombre="Daniel";
            persona[0].edad=15;
            for(int i=0; i<5;i++)
            {
                Console.WriteLine("ingrese el nombre");
                persona[i].nombre=Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("ingrese la edad de");
                persona[i].edad=Int32.Parse(Console.ReadLine());
                Console.WriteLine();
            }
            for(int i=0; i<5;i++)
            {
                Console.WriteLine("Nombre "+persona[i].nombre+" y su edad "+persona[i].edad);
            }

        }
        struct tipopersona
        {
            public string nombre;
            public int edad;
        }
    }
}
