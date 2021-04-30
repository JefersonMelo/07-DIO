using System;

namespace _02_Teste_de_Selecao_1
{
    class Program
    {
        static void Main(string[] args)
        {

            int a, b, c, d;
            string[] s = Console.ReadLine().Split(' ');
            a = int.Parse(s[0]);
            b = int.Parse(s[1]);
            c = int.Parse(s[2]);
            d = int.Parse(s[3]);
            if (b > c && d > a && (c + d) > (a + b) && a % 2 == 0 && c > 0 && d > 0)
            {
                Console.WriteLine("Valores aceitos");
            }
            else
            {
                Console.WriteLine("Valores nao aceitos");
            }
        }
    }
}
