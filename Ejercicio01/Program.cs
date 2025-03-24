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
            // Inicializamos variables que utilizaremos en el código.
            // Creamos un array de 4 elementos para almacenar los números que el usuario introducirá.
            // Creamos una variable para almacenar la suma de los números.
            int[] numeros = new int[4];
            int suma = 0;

            // Iteramos 4 veces para pedir al usuario que introduzca un número.
            for (int i = 0; i < 4; i++)
            {
                // Creamos un bucle que se repetirá hasta que el usuario introduzca un número.
                bool esNumero = false;

                while (!esNumero) 
                { 
                    try
                    {
                        Console.Write("Introduce un número: ");
                        numeros[i] = Convert.ToInt32(Console.ReadLine());
                        esNumero = true;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("El valor introducido no es un número. Intentalo de nuevo.");
                    }
                }

                // Sumamos el número introducido al total.
                suma += numeros[i];
            }

            // Calculamos el promedio de los números.
            double promedio = (double)suma / numeros.Length;
            Console.WriteLine("El promedio de los números es: " + promedio);
        }
    }
}
