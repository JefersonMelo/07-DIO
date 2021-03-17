using System;
using System.Collections;
using System.Collections.Generic;

namespace Fila_Do_Banco
{
    class Program
    {
        /*
        Desafio: O banco que você trabalha sempre tem problemas para organizar as filas de atendimento dos clientes.
        Após uma reunião com a gerência ficou decidido que os clientes ao chegar na agência receberão uma senha 
        numérica em seu aparelho de celular via sms e que a ordem da fila será dada não pela ordem de chegada, mas sim 
        pelo número recebido via sms. A ordem de atendimento será decrescente: aqueles que receberam número maior 
        deverão ser atendidos primeiro. Então, dada a ordem de chegada dos clientes reordene a fila de acordo com o 
        número recebido via sms, e diga quantos clientes não precisaram trocar de lugar nessa reordenação. 
        Entrada: A primeira linha contém um inteiro N, indicando o número de casos de teste a seguir.
        Cada caso de teste inicia com um inteiro M (1 ≤ M ≤ 1000), indicando o número de clientes. Em seguida haverá 
        M inteiros distintos Pi (1 ≤ Pi ≤ 1000), onde o i-ésimo inteiro indica o número recebido via sms do i-ésimo cliente.
        Os inteiros acima são dados em ordem de chegada, ou seja, o primeiro inteiro diz respeito ao primeiro cliente 
        a chegar na fila, o segundo inteiro diz respeito ao segundo cliente, e assim sucessivamente.
        Saída: Para cada caso de teste imprima uma linha, contendo um inteiro, indicando o número de clientes que não 
        precisaram trocar de lugar mesmo após a fila ser reordenada.
        Exemplo de Entrada 	    Exemplo de Saída
        3                       
        3
        100 80 90               1
        4                       
        100 120 30 50           0
        4   
        100 90 30 25            4
        https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.reverse?redirectedfrom=MSDN&view=net-5.0#System_Collections_Generic_List_1_Reverse
        https://social.msdn.microsoft.com/Forums/pt-BR/a19997f5-47b8-4732-84c2-74ed8a2468e9/ordem-decrescente?forum=vscsharppt
        https://www.devmedia.com.br/forum/3-numeros-em-ordem-crescente-csharp/597322
         */
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] notas;
            int qtdEntradas;
            int numReordem = 0;
            List<int> list = new List<int>();
            
            for ( int i = 0; i < n; i++ )
            {
                qtdEntradas = int.Parse(Console.ReadLine());
                string[] s = Console.ReadLine().Split(' ');
                notas = new int[qtdEntradas];
                for ( int j = 0; j < qtdEntradas; j++ )
                {
                    notas[j] = int.Parse(s[j]);
                    list.Add(notas[j]);

                    if ( j == ( qtdEntradas - 1 ) )
                    {
                        list.Sort();
                        list.Reverse();
                        for ( int k = 0; k < list.Count; k++ )
                        {
                            if ( notas[k] == list[k] )
                            {
                                numReordem++;
                            }
                        }

                    }                   
                }
                Console.WriteLine(numReordem);
                numReordem = 0;
                list.Clear();
            }
        }
    }
}
