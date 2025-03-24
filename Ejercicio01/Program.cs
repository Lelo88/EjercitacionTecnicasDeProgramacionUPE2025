using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[4];
            int suma = 0;

            for (int i = 0; i < 4; i++)
            {
                Console.Write("Introduce un número: ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
                suma += numeros[i];
            }

            double promedio = (double)suma / numeros.Length;
            Console.WriteLine("El promedio de los números es: " + promedio);
        }
    }
}
