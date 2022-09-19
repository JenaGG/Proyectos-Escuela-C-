using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; //librería necesaria para el manejo de archivos

namespace Programa_28_ArchivoTextoCaracteres
{
    class Program
    {
        //clase para la escritura de carateres
        public class TextoCaracteres
        {
            //campos
            StreamWriter sw = null; //declaración flujo de escritura
            StreamReader sr = null; //declaración flujo de lectura
            String str;
            //metodos
            //Creación del archivo
            public void CrearArchivo(string a)
            {
                try
                {
                    //Crea el flujo de escritura hacia el archivo "doc.txt", si el archivo existe sobreescribe su contenido
                    sw = new StreamWriter(a );
                    Console.WriteLine("Escriba las lineas de texto para almacenar en el archivo.\n" + "Finalice cada línea pulsando la tecla <enter>.\n>" + "Para finalizar la escritura pulse sólo la tecla <ENTER>.\n");
                    //Lee una linea de la entrada estándar
                    str = Console.ReadLine();
                    //Mientras la cadena str no esté vacía escribe en el archivo
                    while (str.Length != 0)
                    {
                        //Escribe la líne leída en el archivo
                        sw.WriteLine(str);
                        //Lee la línea siguiente de la entrada estándar
                        str = Console.ReadLine();
                    }
                }
                catch (IOException es)
                {
                    Console.WriteLine("Mensaje del Error: " + es.Message);
                    Console.WriteLine("Ruta del Error: " + es.StackTrace);
                }
                finally
                {
                    //Cierra el flujo
                    if (sw != null) sw.Close();
                    //escribir el mensaje del finally
                    Console.Write("EL FLUJO DE CAPTURA HA FINALIZADO CON EXITO. PRESIONE CUALQUIER TECLA PARA CONTINUAR: ");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            //Lectura del archivo
            public void LeerArchivo(string a)
            {
                try
                {
                    //Crea el flujo de lectura desde el archivo "doc.txt"
                    sr = new StreamReader(a);
                    //Lee una línea de texto del archivo 
                    str = sr.ReadLine();
                    //Mientras la cadena str no esté vacia lee el archivo
                    while (str != null)
                    {
                        //Muestra la línea leída y lee la línea siguiente del archivo
                        Console.WriteLine(str);
                        str = sr.ReadLine();
                    }
                }
                catch (IOException el)
                {
                    Console.WriteLine("Mensaje del Error: " + el.Message);
                    Console.WriteLine("Ruta del Error: " + el.StackTrace);
                }
                finally
                {
                    //cierra el flujo
                    if (sr != null) sr.Close();
                    Console.Write("EL FLUJO DE LECTURA HA FINALIZADO CON EXITO. PRESIONE CUALQUIER TECLA PARA CONTINUAR: ");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
        static void Main(string[] args)
        {
            //auxiliar
            string t1;
            char t;
            //archivo
            TextoCaracteres txt = new TextoCaracteres();
            //Menu de opcion
            do
            {
                Console.WriteLine("==MENU Archivo de Texto con Flujos de Caracteres==");
                Console.WriteLine("Favor de escribir una de las opciones mostradas:");
                Console.WriteLine("a) Crear el archivo");
                Console.WriteLine("b) Leer el archivo");
                Console.WriteLine("c) Salir del Programa");
                Console.Write("Opción: ");
                t = char.Parse(Console.ReadLine().ToLower());
                Console.Clear();
                switch (t)
                {
                    case 'a':
                        Console.WriteLine("a) Crear el archivo");
                        Console.WriteLine("Por favor, ingrese el nombre deseado para el archivo: ");
                        Console.WriteLine("Nombre: ");
                        t1 = Console.ReadLine();
                        txt.CrearArchivo(t1);
                        break;
                    case 'b':
                        Console.WriteLine("b) Leer el archivo");
                        Console.WriteLine("Ingrese el nombre del archivo");
                        Console.Write("Nombre: ");
                        t1 = Console.ReadLine();
                        txt.LeerArchivo(t1);
                        break;
                    case 'c':
                        Console.WriteLine("Selecciono salir");
                        Console.Write("Presione cualquier tecla para salir ");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Seleccione una opcion valida");
                        Console.ReadKey();
                        break;
                }
            }
            while (t != 'c');
        }
    }
}
