using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa13_Reutilizacion_Empresa_Trabajor
{
    class Program
    {
        //Clase base
        class Empresa
        {
            public string RazonSocial, Domicilio;
            public long Telefono;
            //Constructor clase base
            public Empresa(string RazonSocial, string Domicilio, long Telefono)
            {
                this.RazonSocial = RazonSocial;
                this.Domicilio = Domicilio;
                this.Telefono = Telefono;
            }
            public void Desplegar()
            {
                Console.WriteLine("====Datos de la Empresa====");
                Console.WriteLine("El nombre de la Empresa es: "+RazonSocial);
                Console.WriteLine("Su domicilio es: "+Domicilio);
                Console.WriteLine("Su telefono es: "+Telefono);
            }
            //Destructor clase base
            ~Empresa()
            {
                Console.WriteLine("Memoria Objeto Empresa Liberada"+RazonSocial);
            }

        }
        class Trabajador:Empresa
        {
            public string Nombre, Departamento;
            public float SalarioDiario, Sueldo;
            public int DiasTrabajados;
            public Trabajador(string RazonSocial, string Domicilio, long Telefono, string Nombre, string Departamento,float SalarioDiario, int DiasTrabajados ):base(RazonSocial,Domicilio,Telefono)
            {
                this.Nombre = Nombre;
                this.Departamento = Departamento;
                this.SalarioDiario = SalarioDiario;
                this.DiasTrabajados = DiasTrabajados;

            }
            public float Calcular()
            {
                return Sueldo = SalarioDiario * DiasTrabajados;
            }
            new public void Desplegar()
            {
                base.Desplegar();
                Console.WriteLine("====Datos Trabajador====");
                Console.WriteLine("El nombre del trabajador es: "+Nombre);
                Console.WriteLine("Su departamento es: "+Departamento);
                Console.WriteLine("Su salario diario es de: $"+SalarioDiario);
                Console.WriteLine("Total de dias trabajados: "+DiasTrabajados);
                Console.WriteLine("Sueldo total: $"+Sueldo);
            }
            ~Trabajador()
            {
                Console.WriteLine("Memoria Objeto Traabajador Liberada "+Nombre);
            }
        }
        static void Main(string[] args)
        {
            string rs, dom, nombre, dep;
            int dt;
            long tel;
            float sd;
            Console.WriteLine("===DATOS EMPRESA===");
            Console.WriteLine("Favor de ingresar los sig. datos:");
            Console.Write("Razon social: ");
            rs = Console.ReadLine();
            Console.WriteLine("Domicilio:");
            dom = Console.ReadLine();
            Console.Write("Telefono ");
            tel = long.Parse(Console.ReadLine());
            Empresa E= new Empresa(rs, dom, tel);
            Console.Write("Nombre del empleado: ");
            nombre= Console.ReadLine();
            Console.Write("Departamento: ");
            dep = Console.ReadLine();
            Console.Write("Dias trabajados: ");
            dt = Int16.Parse(Console.ReadLine());
            Console.Write("Salario diario: ");
            sd = float.Parse(Console.ReadLine());
            Console.Clear();
            Trabajador empleado = new Trabajador(E.RazonSocial, E.Domicilio, E.Telefono, nombre, dep, sd, dt);
            empleado.Calcular();
            empleado.Desplegar();
            Console.ReadKey();

        }
    }
}
