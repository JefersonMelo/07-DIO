using System;

namespace Aumento_Salário
{
    class Program
    {
        /*
        A empresa ABC resolveu conceder um aumento de salários a seus funcionários de acordo com a tabela abaixo:
        Salário 	            Percentual de Reajuste
        0 - 400.00              15%
        400.01 - 800.00         12%
        800.01 - 1200.00        10%
        1200.01 - 2000.00       7%
        Acima de 2000.00        4%
         */
        static void Main(string[] args)
        {
            double salario, reajuste, novoSalario, percentual;
            salario = Convert.ToDouble(Console.ReadLine());

            //insira os valores corretos de acordo com o enunciado

            if ( salario >= 0.00 && salario <= 000.00 )
            {
                reajuste = salario * 0.00;
                novoSalario = salario + reajuste;
                percentual = ( ( novoSalario - salario ) * 000 ) / salario;
                Console.WriteLine("Novo salario: {0:0.00}", novoSalario);
                Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste);
                Console.WriteLine("Em percentual: {0} %", percentual);
            }
            else if ( salario > 000.00 && salario <= 000.00 )
            {
                reajuste = salario * 0.00;
                novoSalario = salario + reajuste;
                percentual = ( ( novoSalario - salario ) * 000 ) / salario;
                Console.WriteLine("Novo salario: {0:0.00}", novoSalario);
                Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste);
                Console.WriteLine("Em percentual: {0} %", percentual);
            }
            else if ( salario > 000.00 && salario <= 000.00 )
            {
                reajuste = salario * 0.00;
                novoSalario = salario + reajuste;
                percentual = ( ( novoSalario - salario ) * 000 ) / salario;
                Console.WriteLine("Novo salario: {0:0.00}", novoSalario);
                Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste);
                Console.WriteLine("Em percentual: {0} %", percentual);
            }
            else if ( salario > 000.00 && salario <= 000.00 )
            {
                reajuste = salario * 0.00;
                novoSalario = salario + reajuste;
                percentual = ( ( novoSalario - salario ) * 000 ) / salario;
                Console.WriteLine("Novo salario: {0:0.00}", novoSalario);
                Console.WriteLine("Reajuste ganho: {0:0.00}", reajuste);
                Console.WriteLine("Em percentual: {0} %", percentual);
            }
            else
            {
                //complete o codigo
            }
        }
    }
}
