using System;
using System.Globalization;

namespace Notas_e_Moedas
{
    class Program
    {
        static void Main(string[] args)
        {
            int notas, moedas;
            string[] v = Console.ReadLine().Split('.');
            notas = int.Parse(v[0], CultureInfo.InvariantCulture);
            moedas = int.Parse(v[1], CultureInfo.InvariantCulture);

            Console.WriteLine("NOTAS:");
            Console.WriteLine($"{notas / 100} nota(s) de R$ 100.00");//576
            notas %= 100;//576 - 500 = 76
            Console.WriteLine($"{notas / 50} nota(s) de R$ 50.00");//76  
            notas %= 50;//76 - 50 = 26
            Console.WriteLine($"{notas / 20} nota(s) de R$ 20.00");//26
            notas %= 20;//26 - 20 = 6
            Console.WriteLine($"{notas / 10} nota(s) de R$ 10.00");//6
            notas %= 10;//6 - 10 = 0
            Console.WriteLine($"{notas / 5} nota(s) de R$ 5.00");//6
            notas %= 5;//6 - 5 = 1
            Console.WriteLine($"{notas / 2} nota(s) de R$ 2.00");//1
            //moedas
            Console.WriteLine("MOEDAS:");
            notas %= 2;
            Console.WriteLine($"{notas} moeda(s) de R$ 1.00");
            moedas %= 100;
            Console.WriteLine($"{moedas / 50} moeda(s) de R$ 0.50");
            moedas %= 50;
            Console.WriteLine($"{moedas / 25} moeda(s) de R$ 0.25");
            moedas %= 25;
            Console.WriteLine($"{moedas / 10} moeda(s) de R$ 0.10");
            moedas %= 10;
            Console.WriteLine($"{moedas / 5} moeda(s) de R$ 0.05");
            moedas %= 5;
            Console.WriteLine($"{moedas} moeda(s) de R$ 0.01");
        }
    }
}
