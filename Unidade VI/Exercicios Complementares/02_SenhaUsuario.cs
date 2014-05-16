using System;

namespace Unidade_VI.Exercicios_Complementares
{
    internal class SenhaUsuario
    {
        public static void Main02(string[] args)
        {
            /*2) Escreva um programa que verifique a validade de uma senha fornecida pelo usuário. A senha válida é o número
             *  NomeUsuário123. Devem ser impressas as seguintes mensagens:
                ACESSO PERMITIDO caso a senha seja válida.
                ACESSO NEGADO caso a senha seja inválida.
            */
            string parte1Senha, senhaFinal, senhaDigitada;
            Console.WriteLine("Digite o seu nome: ");
            parte1Senha = Console.ReadLine();
            senhaFinal = parte1Senha + "123";
            Console.WriteLine("Digite a senha: ");
            senhaDigitada = Console.ReadLine();
            if (senhaDigitada != senhaFinal)
            {
                Console.WriteLine("ACESSO NEGADO");
            }
            else
            {
                Console.WriteLine("ACESSO PERMITIDO");
            }
            Console.ReadKey();
        }
    }
}