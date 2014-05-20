using System;

namespace Unidade_IX.Exercicios_Complementares
{
    internal class _01_GabaritoProva
    {
        public static void Main1(string[] args)
        {
            /* Considere um programa de computador que corrige provas de múltipla escolha. Esse programa deve armazenar
             em um array o gabarito de uma prova. Implemente um programa em C# que gere aleatoriamente o gabarito de uma
             prova com 10 questões de múltipla escolha. Considere que cada questão possui três alternativas numeradas de 1 a 3.
             Complete o código a seguir.*/

            int[] prova = new int[10];
            Random gerador = new Random(); //gera os valores
            for (int i = 0; i < prova.Length; i++)
            {
                prova[i] = gerador.Next(1, 4);
            }

            for (int i = 0; i < prova.Length; i++) //escreve o gabarito.
            {
                Console.WriteLine("Resposta da questão {0}: {1} ", i + 1, prova[i]);
            }
            Console.ReadKey();
        }
    }
}