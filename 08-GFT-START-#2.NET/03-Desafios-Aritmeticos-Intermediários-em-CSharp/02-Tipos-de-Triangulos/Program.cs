using System;
using System.Globalization;

namespace Tipos_de_Triangulos
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            double a, b, c, aux;
            a = double.Parse(s[0], CultureInfo.InvariantCulture);
            b = double.Parse(s[1], CultureInfo.InvariantCulture);
            c = double.Parse(s[2], CultureInfo.InvariantCulture);

            if(a > b && a > c && c > b)
            {
                aux = b;
                b = c;
                c = aux;
            }
            if(b > a && b > c)
            {
                aux = a;
                a = b;
                b = aux;

                if(c > b)
                {
                    aux = c;
                    c = b;
                    b = aux;
                }
            }
            if(c > a && c > b)
            {
                aux = a;
                a = c;
                c = aux;

                if(c > b)
                {
                    aux = c;
                    c = b;
                    b = aux;
                }
            }
            if(a >= (b + c)) { Console.WriteLine("NAO FORMA TRIANGULO"); }
            else if(a * a == (b * b + c * c)) { Console.WriteLine("TRIANGULO RETANGULO"); }
            else if(a * a > (b * b + c * c)) { Console.WriteLine("TRIANGULO OBTUSANGULO"); }
            else { Console.WriteLine("TRIANGULO ACUTANGULO"); }
            if(a == b && b == c) { Console.WriteLine("TRIANGULO EQUILATERO"); }
            else if(a == b || a == c || b == c) { Console.WriteLine("TRIANGULO ISOSCELES"); }
        }
    }
}
