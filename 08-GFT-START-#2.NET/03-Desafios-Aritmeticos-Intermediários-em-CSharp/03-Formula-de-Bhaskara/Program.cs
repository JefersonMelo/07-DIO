using System;
using System.Globalization;

namespace Formula_de_Bhaskara
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, delta, x1, x2;
            string[] s = Console.ReadLine().Split(' ');
            a = double.Parse(s[0]);
            b = double.Parse(s[1]);
            c = double.Parse(s[2]);
            delta = Math.Pow(b, 2) - 4 * a * c;
            if(delta >= 0 && a != 0)
            {
                x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine($"R1 = {x1.ToString("F5", CultureInfo.InvariantCulture)}");
                Console.WriteLine($"R2 = {x2.ToString("F5", CultureInfo.InvariantCulture)}");
            }
            else
            {
                Console.WriteLine("Impossivel calcular");
            }
        }
    }
}
