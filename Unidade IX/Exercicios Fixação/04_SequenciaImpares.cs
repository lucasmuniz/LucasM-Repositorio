using System;

namespace Unidade_IX.Exercicios_Fixação
{
    internal class _04_SequenciaImpares
    {
        public static void Main4(string[] args)
        {
            //Na pasta arrays, crie um arquivo chamado SequenciaImpar.cs.
            //Implemente um programa em C# que armazene 10 números inteiros ímpares em
            //um array. Ao final, exiba no terminal esses valores.
            int[] vetor = new int[10];
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine("Digite o valor ímpar da posição {0}.", i);
                vetor[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine("Valor na posição {0}: {1}", i, vetor[i]);
            }
            Console.ReadKey();
        }
    }
}