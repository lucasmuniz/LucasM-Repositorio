using System;

namespace Unidade_IX.Exercicios_Complementares
{
    internal class _07_SomaVetores
    {
        public static int somaSubtração;

        public static void Main07(string[] args)
        {
            /*Faça um algoritmo que leia dois vetores (A e B) de 50 posições de números inteiros. O algoritmo deve, então,
             * subtrair o primeiro elemento de A do último de B, acumulando o valor, subtrair o segundo elemento de A do
             * penúltimo de B, acumulando o valor, e assim por diante. Mostre o resultado da soma final.*/
            int[] vetorA = new int[50];
            int[] vetorB = new int[50];
            int subtraçaõ;

            for (int i = 0; i < vetorA.Length; i++)
            {
                Console.Write("Digite o valor da posição {0} do vetor A: ", i);
                vetorA[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < vetorB.Length; i++)
            {
                Console.Write("Digite o valor da posição {0} do vetor B: ", i);
                vetorB[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < 50; i++)
            {
                subtraçaõ = vetorA[i] - vetorB[50 - 1];
                somaSubtração += subtraçaõ;
            }
            Console.WriteLine("");
            Console.WriteLine("========== RESULTADO ==========\n");

            Console.WriteLine("Soma de todas as subtrações feitas: {0}",somaSubtração);

            Console.ReadKey();
        }
    }
}