using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_12_HerenciaEscuelaAlumno
{
    class Program
    {
        //Clase Base
        class Escuela
        {
            public string Instituto, Direccion;
            public int Telefono;
            //Constructor clase base
            public Escuela(string instituto, string direccion, int telefono)
            {
                Instituto = instituto;
                Direccion = direccion;
                Telefono = telefono;
            }
            public void DesplegarEscuela()
            {
                Console.WriteLine("===Datos de Institucion===");
                Console.WriteLine("Instituto "+ Instituto);
                Console.WriteLine("Direccion: "+Direccion);
                Console.WriteLine("Telefono: "+Telefono);

            }
            ~Escuela()
            {
                Console.WriteLine("Memoria liberada ObjetoEscuela "+Instituto);
            }
        }
        //Clase Derivada
        class Alumno:Escuela
        {
            public string Nombre, Carrera;
           
            public int NControl, Semestre, Promedio;
            //Constructor clase derivada
            public Alumno(string instituto, string direccion, int telefono, string nombre,string carrera, int promedio, int ncontrol, int semestre):base(instituto, direccion, telefono)    
            {
                Nombre = nombre;
                Carrera = carrera;
                Promedio = promedio;
                NControl = ncontrol;
                Semestre = semestre;
            }
            public void DesplegarAlumno()
            {
                base.DesplegarEscuela();
                Console.WriteLine("===Datos de Alumno===");
                Console.WriteLine("Nombre: "+Nombre);
                Console.WriteLine("Carrera: "+Carrera);
                Console.WriteLine("Promedio: "+Promedio);
                Console.WriteLine("Numero de control: "+NControl);
                Console.WriteLine("Semestre: "+Semestre);
            }
            //Destructor clase derivada
            ~Alumno()
            {
                Console.WriteLine("Memoria Liberada Objeto Alumno "+Nombre);
            }

        }
        static void Main(string[] args)
        {
            string D1, D2;
            int D3;
            //Captura de datos
            Console.Write("Ingrese el nombre de su instituto: ");
            D1 = Console.ReadLine();
            Console.Write("Ingrese la direccion de su instituto: ");
            D2 = Console.ReadLine();
            Console.Write("Ingrese el telefono de su instituto: ");
            D3 = Int32.Parse(Console.ReadLine());
            Escuela I = new Escuela(D1, D2, D3);
            Console.Clear();
            I.DesplegarEscuela();
            Console.WriteLine("\nPresione una tecla para capturar datos de alumno");
            Console.ReadKey();
            Console.Clear();
            //nombre,ncontrol,carrera, semestre, promedio
            string D4, D5;
            int D6,D7, D8;
            Console.Write("\nIngrese el nombre del alumno: ");
            D4 = Console.ReadLine();
            Console.Write("Ingrese la carrera cursada: ");
            D5 = Console.ReadLine();
            Console.Write("Ingrese el promedio del alumno: ");
            D6 = Int32.Parse(Console.ReadLine());
            Console.Write("Ingrese su numero de control: ");
            D7 = Int32.Parse(Console.ReadLine());
            Console.Write("Ingrese el semestre cursado: ");
            D8 = Int16.Parse(Console.ReadLine());
            Alumno F = new Alumno(I.Instituto,I.Direccion,I.Telefono, D4,D5,D6,D7,D8);
            Console.Clear();
            F.DesplegarAlumno();
            Console.WriteLine("\nPresione una tecla para finalizar");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
