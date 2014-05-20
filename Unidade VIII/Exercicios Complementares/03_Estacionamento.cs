using System;

namespace Unidade_VIII.Exercicios_Complementares
{
    internal class _03_Estacionamento
    {
        public static void Main(string[] args)
        {
            /*Para controlar o estacionamento de um condomínio, devemos implementar um programa em C# para gerar os
             cartões das vagas dos moradores. Nos cartões, é necessário constar o número do bloco e o número do apartamento.
             Nesse condômino, há três blocos numerados de 1 a 3. Em cada bloco, há 9 andares. Em cada andar,
             há 4 apartamentos. No primeiro andar, os números dos
             Apartamentos são: 11, 12, 13 e 14. No segundo andar, os números dos apartamentos são: 21, 22, 23 e 24.
             Nos outros andares, a lógica de numeração é a mesma.
             */
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    for (int k = 1; k <= 4; k++)
                    {
                        Console.WriteLine("Bloco {0}: Apartamento: {0}{1} Vaga: {0}{1}{2}", i, j);
                    }
                }
            }

            Console.ReadKey();
        }
    }
}