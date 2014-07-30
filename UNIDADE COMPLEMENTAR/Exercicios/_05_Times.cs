using System;
using System.Collections.Generic;

namespace UNIDADE_COMPLEMENTAR.Exercicios
{
    internal class _05_Times
    {
        public static void Main(string[] args)
        {
            /*5) Crie um algoritmo com uma coleção com todos os times da copa. Sabe-se que são 32 times que serão sorteados e
             * divididos em 8 grupos, do A ao H. Depois de sorteados e alocados o algoritmo deve imprimir na tela todos os grupos.*/
            Dictionary<string, char> _dictionary = new Dictionary<string, char>();
            List<char> Grupos = new List<char>() { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };
            List<string> Times = new List<string>() { "Alemanha", "Argentina", "Argélia", "Brasil" };
            Random sort = new Random();

            for (int i = 0; i < 4; i++)
            {
                int time = sort.Next(0, Times.Count);
                _dictionary.Add(Times[time], Grupos[0]);
                Times.Remove(Times[time]);
            }
        }
    }
}