using System;

namespace Teste_Selecao
{
    class Program
    {
        /*
        Desafio: Leia 4 valores inteiros A, B, C e D. Com base nisso, se o valor de B for maior do que de C 
        e se D for maior do que A, e a soma de C com D for maior que a soma de A e B e se tanto C quanto D 
        forem positivos e, ainda, se a variável A for par, escreva a mensagem "Valores aceitos", 
        senão escrever "Valores nao aceitos".
        Entrada: Quatro números inteiros A, B, C e D.
        Saída: Imprima a mensagem corretamente esperada pela validação dos valores.
        Exemplo de Entrada 	    Exemplo de Saída
        5 6 7 8                 Valores nao aceitos
        2 3 2 6                 Valores aceitos
         */
        static void Main(string[] args)
        {
            int a, b, c, d;
            string[] s = Console.ReadLine().Split(' ');
            a = int.Parse(s[0]);
            b = int.Parse(s[1]);
            c = int.Parse(s[2]);
            d = int.Parse(s[3]);
            if ( b > c && d > a && ( c + d ) > ( a + b ) && a % 2 == 0 && c > 0 && d > 0 )
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
