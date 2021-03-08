using System;
using System.Text.RegularExpressions;

namespace Validador_De_Senhas_Com_Requisitos
{
    class Program
    {
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
        }
    }
}

