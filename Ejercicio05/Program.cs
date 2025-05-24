using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;

            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("Menú Principal:");
                Console.WriteLine("1. Ingresar un carácter");
                Console.WriteLine("2. Salir");
                Console.Write("Seleccione una opción: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        IngresarCaracter();
                        break;
                    case "2":
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Presione una tecla para continuar...");
                        Console.ReadKey();
                        break;
                }
            }
        }

        static void IngresarCaracter()
            {
            Console.Clear();
            try
                {
                    Console.WriteLine("Ingrese un carácter:");
                    char caracter = Console.ReadKey().KeyChar;
                    Console.WriteLine();

                    switch (caracter)
                    {
                        case char c when Char.IsDigit(c):
                            Console.WriteLine("Es número.");
                            break;
                        case char c when Char.IsLetter(c):
                            switch (c)
                            {
                                case char l when Char.IsUpper(l):
                                    Console.WriteLine("Es letra mayúscula.");
                                    break;
                                case char l when Char.IsLower(l):
                                    Console.WriteLine("Es letra minúscula.");
                                    break;
                            }
                            break;
                        default:
                            Console.WriteLine("No es letra ni número.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ocurrió un error: " + ex.Message);
                }

                Console.WriteLine("Presione una tecla para volver al menú principal...");
                Console.ReadKey();
            }
    }
}
