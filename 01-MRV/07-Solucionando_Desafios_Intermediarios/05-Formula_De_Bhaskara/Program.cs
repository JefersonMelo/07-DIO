using System;
using System.Globalization;

namespace Formula_De_Bhaskara
{
    class Program
    {
        /*
        Leia 3 valores de ponto flutuante e efetue o cálculo das raízes da equação de Bhaskara. 
        Se não for possível calcular as raízes, mostre a mensagem correspondente “Impossivel calcular”, 
        caso haja uma divisão por 0 ou raiz de numero negativo.
        Entrada: Leia três valores de ponto flutuante (double) A, B e C.
        Saída: Se não houver possibilidade de calcular as raízes, apresente a mensagem "Impossivel calcular". 
        Caso contrário, imprima o resultado das raízes com 5 dígitos após o ponto, com uma mensagem correspondente 
        conforme exemplo abaixo. Imprima sempre o final de linha após cada mensagem.
        Exemplos de Entrada 	    Exemplos de Saída
        10.0 20.1 5.1               R1 = -0.29788
                                    R2 = -1.71212

        0.0 20.0 5.0                Impossivel calcular

        10.3 203.0 5.0              R1 = -0.02466
                                    R2 = -19.68408
         */
        static void Main(string[] args)
        {
            double a, b, c, delta, x1, x2;
            string[] s = Console.ReadLine().Split(' ');
            a = double.Parse(s[0]);
            b = double.Parse(s[1]);
            c = double.Parse(s[2]);
            delta = Math.Pow(b, 2) - 4 * a * c;
            if ( delta >= 0 && a != 0 )
            {
                x1 = ( -b + Math.Sqrt(delta) ) / ( 2 * a );
                x2 = ( -b - Math.Sqrt(delta) ) / ( 2 * a );
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
