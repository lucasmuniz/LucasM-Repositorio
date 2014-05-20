using System;

namespace Unidade_IX.Exercicios_Fixação
{
    internal class _03_SequenciaDecrescente
    {
        public static void Main3(string[] args)
        {
            //Na pasta arrays, crie um arquivo chamado SequenciaDecrescente.cs. Implemente um programa em C#
            //que armazene 10 números
            //inteiros em um array. Preencha todas as posições do array com valores sequenciais descrescentes.
            //Ao final, exiba no
            //terminal esses valores.

            int[] valores = new int[10];

            for (int i = 9; i >= 0; i--) //i--
            {
                valores[i] = (i + 1);
                Console.WriteLine("Ordem Decrescente: {0}", valores[i]);
            }
            Console.ReadKey();
        }
    }
}