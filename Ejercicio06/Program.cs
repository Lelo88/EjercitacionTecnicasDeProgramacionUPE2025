using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try {
                    Console.WriteLine("Ingrese el valor del lado A: ");
                    double ladoA = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese el valor del lado B: ");
                    double ladoB = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese el valor del lado C: ");
                    double ladoC = Convert.ToDouble(Console.ReadLine());

                    if (EsTrianguloValido(ladoA, ladoB, ladoC))
                    {
                        string tipoTriangulo = ObtenerTipoTruangulo(ladoA, ladoB, ladoC);
                        Console.WriteLine($"Los lados ingresados forman un triángulo {tipoTriangulo}.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Los lados ingresados no forman un triángulo.");
                        LimpiarPantalla();
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: Debe ingresar un número válido.");
                    LimpiarPantalla();
                }
            }
        }

        static bool EsTrianguloValido(double ladoA, double ladoB, double ladoC)
        {
            return (ladoA + ladoB > ladoC) && (ladoA + ladoC > ladoB) && (ladoB + ladoC > ladoA);
        }

        static string ObtenerTipoTruangulo(double ladoA, double ladoB, double ladoC)
        {
            if (ladoA == ladoB && ladoB == ladoC)
            {
                return "Equilátero";
            }
            else if (ladoA == ladoB || ladoA == ladoC || ladoB == ladoC)
            {
                return "Isósceles";
            }
            else
            {
                return "Escaleno";
            }
        }
        
        static void LimpiarPantalla()
        {
            Console.ReadKey();
            Console.Clear();
        }
    }

}
