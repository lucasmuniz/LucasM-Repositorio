using System;

namespace Unidade_X.Exercicios_Fixação
{
    internal class _05_NumerosArray
    {
        public static Random gerador = new Random();
        public static int[] array = new int[50];

        public static void Main05(string[] args)
        {
            /*Implemente um programa em C# definindo um método que preencha um array com números inteiros aleatórios no
             * intervalo de 0 a 99 e outro que exiba no terminal os valores armazenados em um array.*/
            GeraValores();
            MostraVetor();
            Console.ReadKey();
        }

        private static void GeraValores()
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = gerador.Next(0, 100);
            }
        }

        private static void MostraVetor()
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Posicao {0}  Valor {1}", i, array[i]);
            }
        }
    }
}