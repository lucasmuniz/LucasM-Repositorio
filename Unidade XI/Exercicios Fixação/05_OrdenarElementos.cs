using System;

namespace Unidade_XI.Exercicios_Fixação
{
    internal class _05_OrdenarElementos
    {
        public static void Main05(string[] args)
        {
            /*Considere um array contendo os preços dos produtos de uma loja. Esse valores não estão ordenados. Implemente um método
             para ordenar esse elementos do menor para o maior.
             Por mais contraditório que pareça, podemos ordenar um array com uma pequena alteração no método que embaralha. A alteração
             consiste em selecionar a cada iteração o menor elemento do array ao invés de um elemento aleatório.*/
            
        }

        public static void Troca(int[] array, int i, int j)
        {
            int auxiliar = array[i];
            array[i] = array[j];
            array[j] = auxiliar;
        }

        public static int Menor(int[] array, int inicio)
        {
            int menor = inicio;

            for (int i = inicio + 1; i < array.Length; i++)
            {
                if (array[menor] > array[i])
                {
                    menor = i;
                }
            }
            return menor;
        }

        public static void Ordenar(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int menor = Menor(array, i);
                Troca(array, i, menor);
                Console.WriteLine();
            }
        }
    }
}