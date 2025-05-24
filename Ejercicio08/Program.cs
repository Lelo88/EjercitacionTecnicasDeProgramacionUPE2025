using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Write("Ingrese un año: ");
                    int year = Convert.ToInt32(Console.ReadLine());

                    if (EsBisiesto(year))
                    {
                        Console.WriteLine($"{year} es bisiesto.");
                    }
                    else
                    {
                        Console.WriteLine($"{year} no es bisiesto.");
                    }
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: Debe ingresar un año válido.");
                    LimpiarPantalla();
                }
            }
        }

        static bool EsBisiesto(int year)
        {
            if (year < 1582)
            {
                return year % 4 == 0;
            }
            else
            {
                return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
            }
        }

        static void LimpiarPantalla()
        {
            Console.ReadKey();
            Console.Clear();
        }
    }


}
