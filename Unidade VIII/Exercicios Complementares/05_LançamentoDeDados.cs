using System;

namespace Unidade_VIII.Exercicios_Complementares
{
    internal class _05_LançamentoDeDados
    {
        public static int Valor, Soma, ContSeis;

        public static void Main05(string[] args)
        {
            /*Considere um jogo no qual o jogador lança um dado 10 vezes. O jogador ganha se a soma
             dos valores obtidos nos lançamentos for ímpar. Se o número 6 for sorteado 2 vezes o jogador
             perde imediatamente. O número 1 deve ser desconsiderado na somatória. Implemente um programa em
             C# para simular a execução desse jogo.*/
            Random gerador = new Random();

            for (int i = 1; i <= 10; i++)
            {
                Valor = gerador.Next(0, 7);
                if (Valor == 1)
                {
                    continue;
                }
                if (Valor == 6)
                {
                    ContSeis++;
                    if (ContSeis == 2)
                    {
                        Console.WriteLine("\n");
                        Console.WriteLine("2 NUMEROS 6 FORAM SORTEADOS, VOCE PERDEU!!");
                        Console.WriteLine("FIM DE JOGO! APERTE QUALQUER TECLA PARA SAIR");
                        break;
                    }
                }
                Soma += Valor;
            }
            if (Soma % 2 != 0 && ContSeis != 2)
            {
                Console.WriteLine("\n\a");
                Console.WriteLine("========== FIM DE JOGO =========\n");
                Console.WriteLine("A SOMA FOI DE: {0}", Soma);
                Console.WriteLine("VOCÊ VENCEU ESTA JOGADA!!");
            }
            else
            {
                if (ContSeis != 2)
                {
                    Console.WriteLine("\n\a");
                    Console.WriteLine("========== FIM DE JOGO =========\n");
                    Console.WriteLine("A SOMA FOI DE: {0}", Soma);
                    Console.WriteLine("VOCE PERDEU ESTA JOGADA!!");
                }
            }
            Console.ReadKey();
        }
    }
}