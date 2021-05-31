using System;

namespace Soma_Simples
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            int soma = a + b;

            Console.WriteLine("SOMA = {0}", soma);
        }
    }
}
