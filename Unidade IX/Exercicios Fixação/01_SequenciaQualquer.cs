using System;

namespace Unidade_IX.Exercicios_Fixação
{
    internal class _01_SequenciaQualquer
    {
        public static void Main1(string[] args)
        {
            //Na pasta arrays, crie um arquivo chamado SequenciaAleatoria.cs. Implemente um programa em C# que armazene
            //10 números inteiros aleatórios
            //em um array. Ao final, exiba no terminal esses valores.

            int[] sequenciaQlqr = new int[10];
            for (int i = 0; i < sequenciaQlqr.Length; i++)
            {
                Console.WriteLine("Digite o valor da posição {0}.", i);
                sequenciaQlqr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < sequenciaQlqr.Length; i++)
            {
                Console.WriteLine("Valor na posição {0}: {1}", i, sequenciaQlqr[i]);
            }
            Console.ReadKey();
        }
    }
}