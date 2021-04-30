using System;

namespace Bazinga
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtdTeste = int.Parse(Console.ReadLine());
            string v1, v2;
            for (int i = 1; i <= qtdTeste; i++) //insira a variavel correta
            {
                string[] valores = Console.ReadLine().Split();
                v1 = valores[0];
                v2 = valores[1];
                //complete a solução
                if ((v1 == "tesoura" && v2 == "papel") //1. a tesoura corta o papel;
                    || (v1 == "papel" && v2 == "pedra") //2. o papel embrulha a pedra;
                    || (v1 == "pedra" && v2 == "lagarto")   //3. a pedra esmaga o lagarto;
                    || (v1 == "lagarto" && v2 == "Spock")  //4. o lagarto envenena Spock;
                    || (v1 == "Spock" && v2 == "tesoura") //5. Spock destrói a tesoura;
                    || (v1 == "tesoura" && v2 == "lagarto") //6.a tesoura decapita o lagarto;
                    || (v1 == "lagarto" && v2 == "papel") //7. o lagarto come o papel;
                    || (v1 == "papel" && v2 == "Spock") //8. o papel contesta Spock;
                    || (v1 == "Spock" && v2 == "pedra") //9. Spock vaporiza a pedra;
                    || (v1 == "pedra" && v2 == "tesoura")) //10. a pedra quebra a tesoura.
                    Console.WriteLine("Caso #{0}: Bazinga!", i);

                //complete a solucao
                else if (v1.ToString() == v2.ToString())
                    Console.WriteLine("Caso #{0}: De novo!", i);
                else
                    Console.WriteLine("Caso #{0}: Raj trapaceou!", i);
            }
        }
    }
}
