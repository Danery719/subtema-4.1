using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subtema4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            string codigo="", carrera="", bienvenido="";
            do {
                Console.Clear();//limpia la consola por cada ejecucion
                Console.WriteLine("***********MENU DE OPCIONES*************");
                Console.WriteLine("1.Leer codigo de estudiante y carrera.");
                Console.WriteLine("2.Formar una nueva etiqueta textual con ambos(concatenado).");
                Console.WriteLine("3.Mostrar longitud de caracteres del codigo, carrera y etiqueta.");
                Console.WriteLine("4.Mostrar el primer y ultimo caracter del codigo.");
                Console.WriteLine("5.Imprimir la carrera caracter por caracter.");
                Console.WriteLine("6.Cree una nueva etiqueta de bienvenida agregando");
                Console.WriteLine("7.Generar formato de correo UPN");
                Console.WriteLine("8.Salir del menu");
                opcion = int.Parse(Console.ReadLine());// opcion= 8 , salir del menu
                switch (opcion) {
                    case 1:
                        Console.WriteLine("ingrese codigo de estudiante: ");
                        codigo = Console.ReadLine();
                        Console.Write("carrera: ");
                        carrera = Console.ReadLine();
                        break;
                    case 2:
                        bienvenido = codigo +" | carrera: "+ carrera; //concatenar unir ambas cadenas
                        Console.WriteLine("etiqueta generada: " + bienvenido);
                        break;
                    case 3:
                        Console.WriteLine("La longitud del codigo es: " + codigo.Length);
                        Console.WriteLine("La longitud de la carrera es: " + carrera.Length);
                        Console.WriteLine("La longitud del saludo es: " + bienvenido.Length);
                        break;
                    case 4:// ingenieria
                        Console.WriteLine("el primer caracter es: " + carrera[0]);
                        Console.WriteLine("el ultimo caracter es: " + carrera[carrera.Length - 1]);
                        break;
                    case 5:       //carrera = S I S T E M A S
                                            //0 1 2 3 4 5 6 7
                        for (int i = 0; i <carrera.Length; i++)
                        {
                            Console.WriteLine(carrera[i]);
                        }
                        break;
                    case 6:
                        Console.WriteLine("Sean bienvenidos" + bienvenido);
                        break;
                    case 7:
                        Console.Write("ingrese nombres y apellidos: ");
                        string alumno = Console.ReadLine();//alumno= danery huaman cruzado

                        string[] partes = alumno.Split(' ');
                        //partes[] = danery | huaman | cruzado
                            //         0        1         2
                        string primerNombre = partes[0];//primerNombre = danery
                        string iniciales = "";
                        for (int i = 1; i < partes.Length; i++)
                        {
                            iniciales += partes[i].Substring(0, 1);// iniciales += dhc
                        }
                        Console.WriteLine("correro UPN generado!!!");
                        //daneryhc@upn.pe
                        Console.WriteLine($"{primerNombre}{iniciales}@upn.pe");
                        break;
                    case 8: Console.WriteLine("saliendo....");
                        break;
                    default: Console.WriteLine("opcion no valida");
                        break;
                }
                Console.ReadKey();//pausar y esperar que el usuario presione el teclado para continuar

            }//7 distinto a 7 (true)
            while (opcion !=7);// > < >= <= ==     !=(distinto a)


        }
    }
}
