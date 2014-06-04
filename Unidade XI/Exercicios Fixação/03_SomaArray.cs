using System;

namespace Unidade_XI.Exercicios_Fixação
{
    internal class _03_SomaArray
    {
        public static void Main03(string[] args)
        {
            /* Na pasta problemas, crie um arquivo chamadoSomaElementos.cs. Implemente um programa em C#.*/

            int soma = 0;
            int[] array = new int[5];

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Digite o numero da posicao {0}: ", i);
                array[i] = Convert.ToInt16(Console.ReadLine());
                soma = soma + array[i];
            }
            Console.WriteLine("");
            Console.WriteLine("=========== RESULTADO ==========\n");
            Console.WriteLine("Soma: {0}", soma);
            Console.ReadKey();
        }
    }
}