using System;

namespace Trabajos_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int age=21, x=15, y=10, multi, resta;
            double gpa=9.9, division=0, x1= 6, y2= 5;
            string name="Genaro";
            bool student = true;
            
            Console.WriteLine("Nombre: "+name+"\nEdad: "+age+"\nPromedio: "+gpa+"\nAlumno: "+student);
            Console.WriteLine("suma= "+ (x + y));
            resta=x-y;
            Console.WriteLine("Resta= "+resta);
            multi= x*y;
            Console.WriteLine("Multiplicacion= "+multi);
            division = x1 / y2;
            Console.WriteLine("Division= "+ division);
            
        }
    }
}
