using System;

namespace Unidade_IX.Exercicios_Complementares
{
    internal class _03_MenorElemento
    {
        public static void Main(string[] args)
        {
            /*Escreva um algoritmo que leia um vetor de 7 elementos inteiros. Encontre e mostre o menor elemento
             e sua posição no vetor.*/
            int[] vetor = new int[7];
            int maiorNumero = 0, posicao = 0;
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.Write("Digite um numero para o elemento {0}: ", i);
                vetor[i] = Convert.ToInt32(Console.ReadLine());
                if (vetor[i] > maiorNumero)
                {
                    maiorNumero = vetor[i];
                    posicao = i;
                }
            }
            Console.WriteLine("");
            Console.WriteLine("=========Resultado=========\n");
            Console.WriteLine("Maior numero é: {0} e está na posição: {1} ", maiorNumero, posicao);
            Console.ReadKey();
        }
    }
}