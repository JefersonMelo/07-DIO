using System;
using System.Text.RegularExpressions;

namespace Validador_De_Senhas_Com_Requisitos
{
    class Program
    {
        /*
       Pedro e Fernando são os desenvolvedores em uma stratup e vão desenvolver o novo sistema de 
       cadastro, e pediram a sua ajuda. Sua task é fazer o código que valide as senhas que são cadastradas, 
       para isso você deve atentar aos requisitos a seguir:
           A senha deve conter, no mínimo, uma letra maiúscula, uma letra minúscula e um número;
           A mesma não pode ter nenhum caractere de pontuação, acentuação ou espaço;
           Além disso, a senha pode ter de 6 a 32 caracteres.
       Entrada: A entrada contém vários casos de teste e termina com final de arquivo. Cada linha tem uma 
       string S, correspondente a senha que é inserida pelo usuário no momento do cadastro.
       Saída: A saída contém uma linha, que pode ser “Senha valida.”, caso a senha tenha cada item dos 
       requisitos solicitados anteriormente, ou “Senha invalida.”, se um ou mais requisitos não forem atendidos.
       Exemplo de Entrada 	            Exemplo de Saída
       Digítal Innóvation One          Senha invalida.
       AbcdEfgh99                      Senha valida.
       DigitalInnovationOne123         Senha valida.
       Digital Innovation One 123      Senha invalida.
       Aass9                           Senha invalida.
       Aassd9                          Senha valida.
       https://web.digitalinnovation.one/topics/busca-por-padroes-em-strings-usando-expressoes-regulares?back=%2Ftrack%2Fnet-fundamentals&page=1&order=oldest
       https://social.msdn.microsoft.com/Forums/pt-BR/f8f6bbe4-78a9-429b-afef-d2c7a76fd1eb/validadarverificar-caracteres-especiais-e-acentos-?forum=aspnetpt
       https://pt.stackoverflow.com/questions/57552/como-contar-quantos-caracteres-mai%C3%BAsculos-existem-em-uma-string
       https://docs.microsoft.com/pt-br/dotnet/standard/base-types/how-to-verify-that-strings-are-in-valid-email-format
       //Indica se a expressão regular encontra uma correspondência na sequência de entrada.
       https://docs.microsoft.com/pt-br/dotnet/standard/base-types/regular-expression-language-quick-reference
       https://docs.microsoft.com/pt-br/dotnet/api/system.text.regularexpressions.regex.ismatch?view=net-5.0
       https://github.com/CavanhaMan/Cavanha-URI/blob/master/URI-2253_Validador_de_Senhas.java
       https://docs.microsoft.com/pt-br/dotnet/api/system.string.contains?view=net-5.0
       https://docs.microsoft.com/pt-br/dotnet/standard/base-types/regular-expressions
       https://docs.microsoft.com/pt-br/dotnet/csharp/how-to/compare-strings
       https://docs.microsoft.com/pt-br/dotnet/standard/base-types/trimming
       https://www.regular-expressions.info/

        */
        static void Main(string[] args)
        {
            string senha;

            while ( !string.IsNullOrEmpty(senha = Console.ReadLine()) )
            {
                var contMinusculo = Regex.Matches(senha, "[a-z]").Count;
                var contMaiusculo = Regex.Matches(senha, "[A-Z]").Count;
                var contNumero = Regex.Matches(senha, "[0-9]").Count;

                if ( senha.Length >= 6
                  && senha.Length <= 32
                  && contMinusculo > 0
                  && contMaiusculo > 0
                  && contNumero > 0
                  && ( contMinusculo + contMaiusculo + contNumero == senha.Length ) )
                {
                    Console.WriteLine("Senha valida.");
                }
                else
                {
                    Console.WriteLine("Senha invalida.");
                }
            }
        }
    }
}

