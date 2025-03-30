using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool esPalabraValida = false;

            while (!esPalabraValida)
            {
                try
                {
                    string primeraPalabra = ObtenerPalabra("Ingrese la primera palabra: ");
                    string segundaPalabra = ObtenerPalabra("Ingrese la segunda palabra: ");

                    if (string.IsNullOrEmpty(primeraPalabra) || string.IsNullOrEmpty(segundaPalabra))
                    {
                        Console.WriteLine("La palabra no puede estar vacía.");
                    }
                    else
                    {
                        CompararPalabras(primeraPalabra, segundaPalabra);
                    }

                esPalabraValida = true;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Error de formato: " + ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ocurrió un error inesperado: " + ex.Message);
                }
            }
        }

        static string ObtenerPalabra(string mensaje)
        {
            Console.WriteLine(mensaje);
            return Console.ReadLine().Split(' ')[0];
        }

        static void CompararPalabras(string primeraPalabra, string segundaPalabra)
        {
            if (primeraPalabra.Equals(segundaPalabra))
            {
                Console.WriteLine("Las palabras son iguales.");
            }
            else if (string.Compare(primeraPalabra, segundaPalabra, StringComparison.OrdinalIgnoreCase) == 0)
            {
                Console.WriteLine("Las palabras son iguales, pero con diferente formato.");
            }
            else
            {
                if (primeraPalabra.Length > segundaPalabra.Length)
                {
                    Console.WriteLine($"La palabra {primeraPalabra} es mayor en longitud que la palabra {segundaPalabra}.");
                }
                else if (primeraPalabra.Length < segundaPalabra.Length)
                {
                    Console.WriteLine($"La palabra {segundaPalabra} es mayor en longitud que la palabra {primeraPalabra}.");
                }
                else
                {
                    Console.WriteLine("Las palabras tienen la misma longitud.");
                }
            }
        }
    }
}
