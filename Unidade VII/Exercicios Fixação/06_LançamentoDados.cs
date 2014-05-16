using System;

namespace Unidade_VII.Exercicios_Fixação
{
    internal class _06_LançamentoDados
    {
        public static void Main(string[] args)
        {
            /*Faça um programa que simule um lançamento de dados. Lance o dado 100 vezes e armazene os resultados em um vetor.
             * Depois, mostre quantas vezes cada valor foi conseguido. Dica: use um vetor de contadores(1-6) e
             * uma função para gerar números aleatórios, simulando os lançamentos dos dados.
            */

            int[] contador = new int[6];
            Random gerador = new Random();
            for (int i = 0; i < 100; i++)
            {
                contador[gerador.Next(0, 6)]++;
            }
            Console.WriteLine("=== RESULTADO DOS LANÇAMENTOS ===");
            for (int i = 0; i < contador.Length; i++)
            {
                Console.WriteLine("Numero {0}: {1} vezes", i + 1, contador[i]);
            }
            Console.ReadKey();
        }
    }
}