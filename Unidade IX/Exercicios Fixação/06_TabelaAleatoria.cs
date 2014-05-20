using System;

namespace Unidade_IX.Exercicios_Fixação
{
    internal class _06_TabelaAleatoria
    {
        public static void Main6(string[] args)
        {
            Random gerador = new Random();
            int[,] tabela = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    tabela[i, j] = gerador.Next(0, 10);
                    Console.Write("{0} ", tabela[i, j]);
                }
                Console.WriteLine(" ");
            }
            Console.ReadKey();
        }
    }
}