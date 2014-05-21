using System;

namespace Unidade_IX.Exercicios_Complementares
{
    internal class _04_TrocaValoresVetor
    {
        public static void Main04(string[] args)
        {
            /* Escreva um algoritmo que leia um vetor inteiro de 12 posições e crie um segundo vetor, substituindo
               os valores nulos por 1. Mostre os 2 vetores.*/
            int[] vetor = new int[12];
            int[] vetorFormatado = new int[12];
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write("Digite o valor para a posicao {0}: ", i);
                vetor[i] = Convert.ToInt32(Console.ReadLine());
                vetorFormatado[i] = vetor[i];
                if (vetor[i] == 0)
                {
                    vetorFormatado[i] = 1;
                }
            }
            Console.WriteLine("");
            Console.WriteLine("========= RESULTADO =========\n");

            Console.WriteLine("Vetor Original:\n");
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine("Valor da posição [{0}]: {1}", i, vetor[i]);
            }
            Console.WriteLine("=============================");
            Console.WriteLine("Vetor Formatado:\n");
            for (int i = 0; i < vetorFormatado.Length; i++)
            {
                Console.WriteLine("Valor da posição [{0}]: {1}", i, vetorFormatado[i]);
            }
            Console.ReadKey();
        }
    }
}