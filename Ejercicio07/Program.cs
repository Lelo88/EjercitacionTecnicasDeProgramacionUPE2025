using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
                while (true)
                {
                    try
                    {
                    Console.WriteLine("Ingrese el primer número; ");
                    int numero1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese el segundo número; ");
                    int numero2 = Convert.ToInt32(Console.ReadLine());

                    if (numero1 == numero2)
                    {
                        Console.WriteLine("Los números no deben ser iguales. Por favor ingrese los datos nuevamente.");
                        LimpiarPantalla();
                        continue;
                    }

                    int suma = CalcularSumaEntreNumeros(numero1, numero2);
                    Console.WriteLine($"La suma de los números entre {numero1} y {numero2} es: {suma}");
                    break;
                }
                    catch (FormatException)
                    {
                        Console.WriteLine("Error: Debe ingresar números válidos.");
                        LimpiarPantalla();
                    }
                }
        }

        static int CalcularSumaEntreNumeros(int numero1, int numero2)
        {
            int suma = 0;
            int inicio = Math.Min(numero1, numero2) + 1;
            int fin = Math.Max(numero1, numero2);

            for (int i = inicio; i < fin; i++)
            {
                suma += i;
            }

            return suma;
        }

        static void LimpiarPantalla()
        {
            Console.ReadKey();
            Console.Clear();
        }
    }
}
