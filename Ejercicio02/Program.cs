using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Inicializamos variables que utilizaremos en el código.
            double pesos = 0, dolares;
            int opcion = 0;
            bool cambiarPesos = true;

            // Creamos un bucle que se repetirá hasta que el usuario decida salir. 
            do
            {
                if (cambiarPesos)
                {
                    Console.Write("Introduce la cantidad de pesos: ");
                    try
                    {
                        pesos = Convert.ToDouble(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Entrada no válida. Por favor, introduce un número.");
                        continue;
                    }
                }

                Console.Clear();
                Console.WriteLine("¿Qué deseas hacer?");
                Console.WriteLine("1. Convertir pesos a dólar oficial.");
                Console.WriteLine("2. Convertir pesos a dólar blue.");
                Console.WriteLine("3. Convertir pesos a dólar tarjeta");
                Console.WriteLine("4. Convertir pesos a dólar turista.");
                Console.WriteLine("5. Convertir pesos a dólar MEP.");
                Console.WriteLine("6. Convertir pesos a dólar CCL.");
                Console.WriteLine("7. Convertir pesos a dólar mayorista.");
                Console.WriteLine("8. Salir.");
                Console.Write("Opción: ");
                try
                {
                    opcion = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Opción no válida. Inténtalo de nuevo.");
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        dolares = pesos / 1091;
                        Console.WriteLine("La cantidad de dólares es: " + dolares);
                        break;
                    case 2:
                        dolares = pesos / 1280;
                        Console.WriteLine("La cantidad de dólares es: " + dolares);
                        break;
                    case 3:
                    case 4:
                        dolares = pesos / 1418.3;
                        Console.WriteLine("La cantidad de dólares es: " + dolares);
                        break;
                    case 5:
                        dolares = pesos / 1287.22;
                        Console.WriteLine("La cantidad de dólares es: " + dolares);
                        break;
                    case 6:
                        dolares = pesos / 1286.95;
                        Console.WriteLine("La cantidad de dólares es: " + dolares);
                        break;
                    case 7:
                        dolares = pesos / 1068.5;
                        Console.WriteLine("La cantidad de dólares es: " + dolares);
                        break;
                    case 8:
                        Console.WriteLine("¡Hasta luego!");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Inténtalo de nuevo.");
                        break;
                }

                // Si la opción elegida no es salir, preguntamos al usuario si desea cambiar la cantidad de pesos.
                if (opcion != 8)
                {
                    Console.WriteLine("Presiona cualquier tecla para continuar...");
                    Console.ReadKey();
                    Console.Clear();

                    Console.Write("¿Deseas cambiar la cantidad de pesos? (s/n): ");
                    string respuesta = Console.ReadLine().ToLower();
                    cambiarPesos = respuesta == "s";
                }

            }while (opcion != 8);
        }
    }
}
