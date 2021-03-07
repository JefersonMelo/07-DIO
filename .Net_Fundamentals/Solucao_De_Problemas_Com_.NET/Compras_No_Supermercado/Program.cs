using System;
using System.Collections.Generic;
using System.Linq;

namespace Compras_No_Supermercado
{
    class Program
    {
        /*
        Desafio: Pedro trabalha sempre até tarde todos os dias, com isso tem pouco tempo tempo 
        para as tarefas domésticas. Para economizar tempo ele faz a lista de compras do supermercado 
        em um aplicativo e costuma anotar cada item na mesma hora que percebe a falta dele em casa.
        O problema é que o aplicativo não exclui itens duplicados, como Pedro anota o mesmo item mais 
        de uma vez e a lista acaba ficando extensa. Sua tarefa é melhorar o aplicativo de notas desenvolvendo 
        um código que exclua os itens duplicados da lista de compras e que os ordene alfabeticamente.
        Entrada: A primeira linha de entrada contém um inteiro N (N < 100) com a quantidade de casos de teste 
        que vem a seguir, ou melhor, a quantidade de listas de compras para organizar. Cada lista de compra 
        consiste de uma única linha que contém de 1 a 1000 itens ou palavras compostas apenas de letras 
        minúsculas (de 1 a 20 letras), sem acentos e separadas por um espaço.
        Saída: A saída contém N linhas, cada uma representando uma lista de compra, sem os itens repetidos 
        e em ordem alfabética.
        Exemplo de Entrada 	                            Exemplo de Saída
        carne laranja suco picles laranja picles        carne laranja picles suco                   
        laranja pera laranja pera pera                  laranja pera     
        https://docs.microsoft.com/pt-br/dotnet/api/system.linq.queryable.distinct?view=net-5.0
        https://docs.microsoft.com/pt-br/dotnet/framework/data/adonet/sql/linq/eliminate-duplicate-elements-from-a-sequence#:~:text=Use%20o%20operador%20de%20Distinct,duplicate%20elements%20from%20a%20sequence.
         */
        static void Main(string[] args)
        {
            string[] prods;
            List<string> list = new List<string>();
            int n = int.Parse(Console.ReadLine());

            for ( int i = 0; i < n; i++ )
            {
                prods = Console.ReadLine().Split(' ');
                for ( int j = 0; j < prods.Length; j++ )
                {
                    list.Add(prods[j]);
                }
                list.Sort();
                IEnumerable<string> listLimpa = list.AsQueryable().Distinct();
                int a = listLimpa.Count();
                foreach ( var item in listLimpa )
                {

                    if ( a > 1 )
                    {
                        Console.Write($"{item}");
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write($"{item}");
                    }
                    a--;

                }
                list.Clear();
                Console.WriteLine();
            }
        }
    }
}