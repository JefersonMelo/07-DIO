using System;

namespace Area_do_Circulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14159, r;
            double a;

            r = Convert.ToDouble(Console.ReadLine());

            a = pi * ( r * r );

            Console.WriteLine("A=" + a.ToString("F4"));
        }

    }
}
