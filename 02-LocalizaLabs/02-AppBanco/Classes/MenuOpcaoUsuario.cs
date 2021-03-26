using System;
using System.Collections.Generic;
using System.Text;

namespace AppBanco
{
    class MenuOpcaoUsuario
    {
        public char OpcaoUsuario { get; set; }

        public MenuOpcaoUsuario() { }

        // Menu de opções de escolha do usuário
        public string ImprimirMenu()
        {
            return $"\nInforme Uma Opção:\n" +
                   $"1- Listar Contas\n" +
                   $"2- Inserir Nova Conta\n" +
                   $"3- Transferir\n" +
                   $"4- Sacar\n" +
                   $"5- Depositar\n" +
                   $"C- Limpar Tela\n" +
                   $"X- Sair";
        }
    }
}
