using System;

namespace Trabajo_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string Nom, Edad, Carrera, LN, FN, P1, P2;
            int suma, multi, resta, x, y, puntos1=100, puntos2=999, ataque1= 50, ataque2=100, atk;
            
            Console.WriteLine("Ejercicio 1");

            Console.WriteLine("\n╔═════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║Ingrese su nombre:                                               ║");
            Nom=Console.ReadLine();
            Console.WriteLine("║Ingrese su edad:                                                 ║");
            Edad=Console.ReadLine();
            Console.WriteLine("║Ingrese Su Carrera:                                              ║");
            Carrera=Console.ReadLine();
            Console.WriteLine("║Lugar de Nacimiento:                                             ║");
            LN=Console.ReadLine();
            Console.WriteLine("║Fecha de Nacimiento:                                             ║");
            FN=Console.ReadLine();
            Console.WriteLine("║                                                                 ║");
            Console.WriteLine("║                                                                 ║");
            Console.WriteLine("║                                                                 ║");
            Console.WriteLine("║                                                                 ║");
            Console.WriteLine("╚═════════════════════════════════════════════════════════════════╝");

            Console.WriteLine("\nEjercicio 2");

            Console.WriteLine("\nDigita Un Numero: ");
            x=Int32.Parse(Console.ReadLine());
            Console.WriteLine("Digita Otro Numero: ");
            y=Int32.Parse(Console.ReadLine());
            suma=x+y;
            resta=x-y;
            multi=x*y;
            Console.WriteLine("La suma de los numeros es: "+suma);
            Console.WriteLine("La resta de los numeros es: "+resta);
            Console.WriteLine("La multiplicacion de los numeros es: "+multi);

            Console.WriteLine("\nEjercicio 3");
            Console.WriteLine("\nHola, ingresa el nombre del player 1");
            P1=Console.ReadLine();
            Console.WriteLine("\nHola "+P1+" Tus puntos son "+puntos1+" y tu ataque es "+ataque1);
            Console.WriteLine("\nAhora ingresa el nombre del player 2");
            P2=Console.ReadLine();
            Console.WriteLine("\nHola "+P2+" Tus puntos son "+puntos2+" y tu ataque es "+ataque2);
            Console.WriteLine(P1+ "Ataca a "+P2);
            atk=puntos2-ataque1;
            Console.WriteLine(P2+" Tus puntos son "+atk);
            Console.WriteLine(P2+" Ataca a "+P1);
            atk=puntos1-ataque2;
            Console.WriteLine(P1+" Tus puntos son "+atk);
            Console.WriteLine(P2+" Moriste");

        }
    }
}
