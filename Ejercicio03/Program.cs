using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isFechaValida = false;

            while (!isFechaValida)
            {

            try
            {
                Console.WriteLine("Ingrese su fecha de nacimiento (dd/MM/yyyy):");
                string input = Console.ReadLine();
                DateTime fechaNacimiento;

                if (DateTime.TryParseExact(input, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out fechaNacimiento))
                {
                    int edad = CalcularEdad(fechaNacimiento);
                    Console.WriteLine($"Su edad es: {edad} años.");
                        isFechaValida = true;
                    }
                else
                {
                    Console.WriteLine("Fecha de nacimiento no válida. Por favor, use el formato dd/MM/yyyy.");
                }
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

        static int CalcularEdad(DateTime fechaNacimiento)
        {
            DateTime fechaActual = DateTime.Today;
            int edad = fechaActual.Year - fechaNacimiento.Year;

            if (fechaNacimiento.Date > fechaActual.AddYears(-edad)) edad--;

            return edad;
        }
    }
}
