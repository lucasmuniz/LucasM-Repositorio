using System;

namespace Unidade_IX.Exercicios_Complementares
{
    internal class _02_VagasEstacionamento
    {
        public static void Main2(string[] args)
        {
            /*Considere um programa de computador que controla as vagas de um estacionamento. Esse programa deve
              armazenar em uma tabela (array de arrays) a situação das vagas (ocupada ou livre) por andar. Implemente
              um programa em C# que defina aleatoriamente a situação das vagas de um estacionamento de quatro andares numerados
              de 1 a 4. Considere que a capacidade de cada andar é de 10 vagas.*/
            Random gerador = new Random();
            int[,] vagas = new int[4, 10];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    vagas[i, j] = gerador.Next(0, 2);

                    Console.WriteLine("Andar: {0}", i);
                    Console.WriteLine(" Ocupada (0)/ Vaga (1): Sua vaga está: {0} ", vagas[i, j]);
                    Console.WriteLine(" ");
                }
            }

            Console.ReadKey();
        }
    }
}