using System;
using System.Globalization;

namespace Triangulo
{
    class Program
    {
        /*
        Leia 3 valores reais (A, B e C) e verifique se eles formam ou não um triângulo. Em caso positivo, 
        calcule o perímetro do triângulo e apresente a mensagem: Perimetro = XX.X
        Em caso negativo, calcule a área do trapézio que tem A e B como base e C como altura, 
        mostrando a mensagem: Area = XX.X
        Entrada: A entrada contém três valores reais.
        Saída: O resultado deve ser apresentado com uma casa decimal.
        Exemplo de Entrada 	    Exemplo de Saída
        6.0 4.0 2.0             Area = 10.0
        6.0 4.0 2.1             Perimetro = 12.1
         */
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            double a, b, c, result;
            a = double.Parse(s[0]);
            b = double.Parse(s[1]);
            c = double.Parse(s[2]);
            if ( a < ( b + c ) && b < ( a + c ) && c < ( a + b ) )
            {
                result = a + b + c;

                Console.WriteLine($"Perimetro = {result.ToString("F1", CultureInfo.InvariantCulture)}");
            }
            else
            {
                result = ( a + b ) * c / 2.0;
                Console.WriteLine($"Area = {result.ToString("F1", CultureInfo.InvariantCulture)}");
            }
        }
    }
}
