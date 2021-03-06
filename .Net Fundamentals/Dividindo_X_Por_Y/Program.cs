using System;

namespace Dividindo_X_Por_Y
{
    class Program
    {
        /*
        Escreva um algoritmo que leia 2 números e imprima o resultado da divisão do primeiro pelo segundo. 
        Caso não for possível mostre a mensagem “divisao impossivel” para os valores em questão.
        Entrada: A entrada contém um número inteiro N. Este N será a quantidade de pares de valores inteiros 
        (X e Y) que serão lidos em seguida.
        Saída: Para cada caso mostre o resultado da divisão com um dígito após o ponto decimal, ou “divisao impossivel” 
        caso não seja possível efetuar o cálculo.
        Obs.: Cuide que a divisão entre dois inteiros em algumas linguagens como o C e C++ gera outro inteiro. Utilize cast :)
        Exemplo de Entrada 	Exemplo de Saída
        3                   -1.5
        3 -2                divisao impossivel
        -8 0                0.0
        0 8
        */

        static void Main(string[] args)
        {
            double r;
            int n, x, y;
            n = int.Parse(Console.ReadLine());
            for ( int i = 0; i < n; i++ )
            {
                string[] s = Console.ReadLine().Split(' ');
                x = int.Parse(s[0]);
                y = int.Parse(s[1]);

                if ( y == 0 )
                {
                    Console.WriteLine("divisao impossivel");
                }
                else
                {
                    r = ( double )x / y;
                    Console.WriteLine($"{r:f1}");
                }
            }
        }
    }
}
