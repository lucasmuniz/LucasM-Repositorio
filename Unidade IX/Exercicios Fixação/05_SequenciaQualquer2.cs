using System;

namespace Unidade_IX.Exercicios_Fixação
{
    internal class _05_SequenciaQualquer2
    {
        public static void Main5(string[] args)
        {
            //Na pasta arrays, crie um arquivo chamado SequenciaQualquer.cs. Implemente um programa em C# que armazene
            //10 números inteiros
            //em um array. Todas as posições do array devem ser preenchidas e o valor armazenado fica à sua escolha.
            //Após preencher o array,
            //exiba os seus valores no terminal.
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