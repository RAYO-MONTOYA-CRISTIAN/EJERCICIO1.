using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la temperatura en grados Fahrenheit:");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());

            double celsius = ( fahrenheit - 32) * 5 / 9;

            Console.WriteLine($"La temperatura en grados Celsius es: {celsius:F2}");
        }
    }
}
