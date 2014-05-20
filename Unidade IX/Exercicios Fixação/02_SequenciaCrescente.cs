using System;

namespace Unidade_IX.Exercicios_Fixação
{
    internal class _02_SequenciaCrescente
    {
        public static void Main2(string[] args)
        {
            //Na pasta arrays, crie um arquivo chamado SequenciaCrescente.cs. Implemente um programa em C#
            //que armazene 10 números
            //inteiros em um array. Preencha todas as posições do array com valores sequenciais. Ao final,
            //exiba no terminal esses valores.
            int[] vetor = new int[10];

            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = (i + 1);
                Console.WriteLine("Valores na posição {0}: {1}", i, vetor[i]);
            }

            Console.ReadKey();
        }
    }
}