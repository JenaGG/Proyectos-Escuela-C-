using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volumenes;

namespace Programa19_LibreríaVolumenes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables auxiliares
            int l;
            float r1, rci, aci, rco, aco;
            Console.WriteLine("==Volumen de Figuras==");
            //Captura datos esfera
            Console.WriteLine("Ingrese los valores para la Esfera:");
            Console.Write("Radio: ");
            r1 = Single.Parse(Console.ReadLine());
            //Creacion objeto esfera
            Esfera E = new Esfera(r1);
            E.calcularVolumen();
            E.desplegarVolumen();
            Console.Write("Presione cualquier tecla para ir a la siguiente figura");
            Console.ReadKey();
            Console.Clear();
            //captura datos cubo
            Console.WriteLine("Ingrese los valores para el Cubo:");
            Console.Write("Lado: ");
            l = int.Parse(Console.ReadLine());
            //Creacion objeto cubo
            Cubo C = new Cubo(l);
            C.calcularVolumen();
            C.desplegarVolumen();
            Console.Write("Presione cualquier tecla para ir a la siguiente figura");
            Console.ReadKey();
            Console.Clear();
            //captura datos cilindro
            Console.WriteLine("Ingrese los valores para el Cilíndro:");
            Console.Write("Radio: ");
            rci = Single.Parse(Console.ReadLine());
            Console.Write("Altura: ");
            aci = Single.Parse(Console.ReadLine());
            //Creación del objeto Cilíndro
            Cilindro CI = new Cilindro(rci, aci);
            CI.calcularVolumen();
            CI.desplegarVolumen();
            Console.Write("Presione cualquier tecla para ir a la siguiente figura");
            Console.ReadKey();
            Console.Clear();
            //Captura datos cono
            Console.WriteLine("Ingrese los valores para el Cono:");
            Console.Write("Radio: ");
            rco = Single.Parse(Console.ReadLine());
            Console.Write("Altura: ");
            aco = Single.Parse(Console.ReadLine());
            //Creación del objeto Cono
            Cono CO = new Cono(rco, aco);
            CO.calcularVolumen();
            CO.desplegarVolumen();
            Console.Write("Presione cualquier tecla para salir:");
            Console.ReadKey();
            Console.Clear();
        }
    }
}