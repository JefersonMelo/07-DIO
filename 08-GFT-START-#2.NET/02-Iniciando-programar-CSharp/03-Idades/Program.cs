using System;
using System.Globalization;

namespace Idades
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1;
            int cont = 0;
            int soma = 0;

            while(n > 0)
            {
                n = int.Parse(Console.ReadLine());

                if(n > 0)
                {
                    soma += n;
                    cont++;
                }
            }
            double media = (double)soma / cont;

            Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
