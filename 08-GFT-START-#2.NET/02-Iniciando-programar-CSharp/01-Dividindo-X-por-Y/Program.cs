using System;
using System.Globalization;

namespace Dividindo_X_Por_Y
{
    class Program
    {
        static void Main(string[] args)
        {
            double r;
            int n, x, y;
            n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                x = int.Parse(s[0], CultureInfo.InvariantCulture);
                y = int.Parse(s[1], CultureInfo.InvariantCulture);

                if(y == 0)
                {
                    Console.WriteLine("divisao impossivel");
                }
                else
                {
                    r = (double)x / y;
                    Console.WriteLine(r.ToString("F1", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}
