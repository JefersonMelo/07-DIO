using System;
using System.Linq;

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
        https://docs.microsoft.com/pt-br/dotnet/api/system.text.regularexpressions.regex.ismatch?view=net-5.0
        https://docs.microsoft.com/pt-br/dotnet/api/system.string.contains?view=net-5.0
        https://docs.microsoft.com/pt-br/dotnet/standard/base-types/regular-expressions
        https://docs.microsoft.com/pt-br/dotnet/csharp/how-to/compare-strings
        https://docs.microsoft.com/pt-br/dotnet/standard/base-types/trimming
        https://www.regular-expressions.info/

         */
        static void Main( )
        {
            string senha = Console.ReadLine();

            while ( senha != "" )
            {

                if ( senha.Length < 6
                  || senha.Length > 32
                  || senha.Count(char.IsUpper) < 1
                  || senha.Count(char.IsLower) < 1
                  || senha.Contains(' ')
                  || senha.Contains('!')
                  || senha.Contains('?')
                  || senha.Contains(',')
                  || senha.Contains(';')
                  || senha.Contains('.')
                  || senha.Contains('Ä')
                  || senha.Contains('Å')
                  || senha.Contains('Á')
                  || senha.Contains('À')
                  || senha.Contains('Ã')
                  || senha.Contains('ä')
                  || senha.Contains('á')
                  || senha.Contains('â')
                  || senha.Contains('à')
                  || senha.Contains('ã')
                  || senha.Contains('É')
                  || senha.Contains('Ê')
                  || senha.Contains('Ë')
                  || senha.Contains('È')
                  || senha.Contains('é')
                  || senha.Contains('ê')
                  || senha.Contains('ë')
                  || senha.Contains('è')
                  || senha.Contains('Í')
                  || senha.Contains('Î')
                  || senha.Contains('Ï')
                  || senha.Contains('Ì')
                  || senha.Contains('í')
                  || senha.Contains('î')
                  || senha.Contains('ï')
                  || senha.Contains('ì')
                  || senha.Contains('Ö')
                  || senha.Contains('Ö')
                  || senha.Contains('Ó')
                  || senha.Contains('Ô')
                  || senha.Contains('Ò')
                  || senha.Contains('Õ')
                  || senha.Contains('ö')
                  || senha.Contains('ó')
                  || senha.Contains('ô')
                  || senha.Contains('ò')
                  || senha.Contains('õ')
                  || senha.Contains('Ü')
                  || senha.Contains('Ú')
                  || senha.Contains('Û')
                  || senha.Contains('ü')
                  || senha.Contains('ú')
                  || senha.Contains('û')
                  || senha.Contains('ù')
                  || senha.Contains('Ç')
                  || senha.Contains('ç')
                  || senha.Contains('´')
                  || senha.Contains('^')
                  || senha.Contains('~')
                  || senha.Contains('`')
                  || senha.Contains('¨')
                  || senha.Contains('<')
                  || senha.Contains('>')
                  || senha.Contains('@')
                  || senha.Contains('%')
                  || senha.Contains('#')
                  || senha.Contains('$')
                  || senha.Contains('&')
                  || senha.Contains('(')
                  || senha.Contains(')')
                  || senha.Contains('-')
                  || senha.Contains(':')
                  || senha.Contains('/')
                  || senha.Contains('|')
                  || senha.Contains('_')
                  || senha.Contains('=')
                  || senha.Contains('+')
                  || senha.Contains('§')
                  || senha.Contains('[')
                  || senha.Contains(']')
                  || senha.Contains('ª')
                  || senha.Contains('º')
                  || senha.Contains('{')
                  || senha.Contains('}')
                  || senha.Contains('°')
                  || senha.Contains('"')
                  || senha.Contains("'")
                  || senha.Contains("\n")

                  )
                {
                    Console.WriteLine("Senha invalida.");
                }
                else
                {
                    Console.WriteLine("Senha valida.");

                }
                senha = Console.ReadLine();
            }
        }
    }
}
using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Threading;

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
        static void Main( )
        {
            string senha = Console.ReadLine();
            var contMinusculo = Regex.Matches(senha, "[a-z]").Count;
            var contMaiusculo = Regex.Matches(senha, "[A-Z]").Count;
            var contNumero = Regex.Matches(senha, "[0-9]").Count;

            while ( senha != "" )
            {
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

                senha = Console.ReadLine();
                contMinusculo = Regex.Matches(senha, "[a-z]").Count;
                contMaiusculo = Regex.Matches(senha, "[A-Z]").Count;
                contNumero = Regex.Matches(senha, "[0-9]").Count;
            }

            //Console.WriteLine(count);

            //    int contMinusculo = 0, contMaiusculo = 0, contNumero = 0;

            //    while ( senha.Length != 0 )
            //    {
            //        if ( senha.Length >= 6 && senha.Length <= 32 && !senha.Contains(' ') )
            //        {
            //            for ( int i = 0; i < senha.Length; i++ )
            //            {
            //                if ( senha[i] >= 'a' && senha[i] <= 'z' )
            //                {
            //                    contMinusculo++;
            //                }
            //                if ( senha[i] >= 'A' && senha[i] <= 'Z' )
            //                {
            //                    contMaiusculo++;
            //                }
            //                if ( senha[i] >= '0' && senha[i] <= '9' )
            //                {
            //                    contNumero++;
            //                }
            //            }
            //        }
            //        if ( contMinusculo > 0 && contMaiusculo > 0 && contNumero > 0 )
            //        {
            //            Console.WriteLine("Senha valida.");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Senha invalida.");
            //        }
            //        contMinusculo = 0;
            //        contMaiusculo = 0;
            //        contNumero = 0;
            //        senha = Console.ReadLine();
            //    }
            //}

            //private static void AppDomainSetup(string v)
            //{
            //    throw new NotImplementedException();
        }
    }
}

