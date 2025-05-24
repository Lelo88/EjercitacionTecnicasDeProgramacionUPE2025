using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Write("Cantidad de palabras: ");
                    int n = Convert.ToInt32(Console.ReadLine());

                    if (n <= 0)
                    {
                        Console.WriteLine("Error: La cantidad de palabras debe ser un número entero positivo.");
                        LimpiarPantalla();
                        continue;
                    }

                    string[] palabras = new string[n];

                    for (int i = 0; i < n; i++)
                    {
                        Console.Write($"Palabra {i + 1}: ");
                        palabras[i] = Console.ReadLine();
                    }

                    string palabraMasLarga = ObtenerPalabraMasLarga(palabras);
                    string palabraMasCorta = ObtenerPalabraMasCorta(palabras);

                    Console.WriteLine($"La palabra más larga es {palabraMasLarga}");
                    Console.WriteLine($"La palabra más corta es {palabraMasCorta}");
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: Debe ingresar un número entero válido.");
                    LimpiarPantalla();
                }
            }
        }

        static string ObtenerPalabraMasLarga(string[] palabras)
        {
            string palabraMasLarga = palabras[0];

            foreach (string palabra in palabras)
            {
                if (palabra.Length > palabraMasLarga.Length)
                {
                    palabraMasLarga = palabra;
                }
            }

            return palabraMasLarga;
        }
        static string ObtenerPalabraMasCorta(string[] palabras)
        {
            string palabraMasCorta = palabras[0];

            foreach (string palabra in palabras)
            {
                if (palabra.Length < palabraMasCorta.Length)
                {
                    palabraMasCorta = palabra;
                }
            }

            return palabraMasCorta;
        }

        static void LimpiarPantalla()
        {
            Console.ReadKey();
            Console.Clear();
        }
    }
}
