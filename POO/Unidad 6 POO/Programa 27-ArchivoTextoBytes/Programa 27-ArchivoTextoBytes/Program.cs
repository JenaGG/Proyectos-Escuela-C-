using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;//Libreria necesaria para que funcione el programa

namespace Programa_27_ArchivoTextoBytes
{
    class Program
    {
        public class TextoBytes
        {
            //campos
            FileStream fe = null; // flujo de entrada - lectura
            FileStream fs = null; //fluje de salida - escritura
            char[] cBuffer = new char[81]; //arreglo de caracteres
            byte[] bBuffer = new byte[81]; //arreglo de bytes
            int nbytes = 0, car;

            //métodos
            //creación del archivo
            public void CrearArchivo(string archivo)
            {
                try
                {
                    //Crea un flujo hacia el archivo de texto ".txt"
                    fs = new FileStream(archivo, FileMode.Create, FileAccess.Write);
                    Console.WriteLine("\nEscriba el texto que desea almacenar en el archivo, al finalizar presione <enter>:");
                    while ((car = Console.Read()) != '\n' && (nbytes < bBuffer.Length))
                    {
                        bBuffer[nbytes] = (byte)car; //convierte en byte el carácter leido
                        nbytes++;
                    }
                    //Escribe la linea de texto en el archivo
                    fs.Write(bBuffer, 0, nbytes);
                }
                catch (IOException es)
                {
                    Console.WriteLine("Mensaje del Error: " + es.Message);
                    Console.WriteLine("Ruta del Error: " + es.StackTrace);
                }
                finally
                {
                    if (fs != null) fs.Close(); //cierra el flujo de escritura
                }
            }
            //lectura del archivo
            public void LeerArchivo(string archivo)
            {
                try
                {
                    //Crea un flujo desde el archivo
                   fe = new FileStream(archivo, FileMode.Open, FileAccess.Read);
                    //Lee una linea de texto del archivo
                    nbytes = fe.Read(bBuffer, 0, 81);
                    //Crea un objeto string con el texto leido
                    Array.Copy(bBuffer, cBuffer, bBuffer.Length);
                    String str = new String(cBuffer, 0, nbytes);
                    //Muestra el texto leído
                    Console.WriteLine("\nCONTENIDO DEL ARCHIVO");
                    Console.WriteLine(str);
                }
                catch (IOException el)
                {
                    Console.WriteLine("Mensaje del Error: " + el.Message);
                    Console.WriteLine("Ruta del Error: " + el.StackTrace);
                }
                finally
                {
                    if (fe != null) fe.Close();  //cierra el flujo lectura
                                                 // escribir mensaje del finally. 

                }
            }
        }
        static void Main(string[] args)
        {
            //variables auxiliares
            char tecla = '0';
            string archivo;
            //creación del objeto

            TextoBytes arc = new TextoBytes();
            //menu del programa

            do
            {

                Console.Clear();
                Console.WriteLine("==Menu Archivos de Texto con Flujos de Bytes==");
                Console.WriteLine("Digite una opcion");
                Console.WriteLine("a) Crear archivo.");
                Console.WriteLine("b) Leer archivo.");
                Console.WriteLine("c) Salir de Programa.");
                Console.Write("Opción: ");
                tecla = char.Parse(Console.ReadLine().ToLower());
                switch (tecla)
                {
                    case 'a':
                        Console.Clear();
                        Console.WriteLine("Favor de ingresar el nombre deseado para el archivo y su extencion.");
                        Console.Write("Nombre: ");
                        archivo = Console.ReadLine();
                        arc.CrearArchivo(archivo);
                        Console.Write("Presione cualquier tecla para continuar: \n");
                            Console.ReadKey();
                        break;

                    case 'b':
                        Console.Clear();
                        Console.WriteLine("Favor de ingresar el nombre del archivo a leer con su extension.");
                        Console.WriteLine("Nombre: ");
                        archivo = Console.ReadLine();
                        arc.LeerArchivo(archivo);
                        Console.Write("Presione cualquier tecla para continuar: ");
                        Console.ReadKey();
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
            }while (tecla != 'c');
        }
    }
}
