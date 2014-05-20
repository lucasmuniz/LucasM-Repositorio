using System;

namespace Unidade_IX.Exercicios_Complementares
{
    internal class _08_NumerosLoteria
    {
        public static void Main(string[] args)
        {
            /*Escreva um algoritmo que leia um vetor de 13 elementos inteiros, que é o Gabarito de um teste da loteria
              esportiva, contendo os valores 1(coluna 1), 2 (coluna 2) e 3 (coluna do meio). Leia, a seguir, para cada
              apostador, o número do seu cartão e um vetor de Respostas de 13 posições. Verifique para cada apostador os
              números de acertos, comparando o vetor de Gabarito com o vetor de Respostas. Escreva o número do apostador e
              o número de acertos. Se o apostador tiver 13 acertos, mostrar a mensagem "Ganhador".*/

            int[,] gabaritoLoteria = new int[3, 13];
            int[,] matrizLoteria = new int[3, 13];
            int contAcertos = 0;
            for (int i = 0; i < 3; i++) //gabarito
            {
                for (int j = 0; j < 13; j++)
                {
                    Console.Write("Digite o gabarito da posicao [{0},{1}]: ", i, j);
                    gabaritoLoteria[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int k = 0; k < 3; k++)
            {
                for (int i = 0; i < 13; i++)
                {
                    Console.Write("Digite o valor do seu jogo na posicao [{0},{1}]: ", k, i);
                    matrizLoteria[k, i] = Convert.ToInt32(Console.ReadLine());
                    if (matrizLoteria[k, i] == gabaritoLoteria[k, i])
                    {
                        contAcertos++;
                    }
                }
            }
            Console.WriteLine("");
            Console.WriteLine("========= RESULTADOS ===========");
            Console.WriteLine("Total de acertos: {0}", contAcertos);
            Console.WriteLine("Gabarito      |    Seu jogo");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    Console.WriteLine("[{0},{1}]:{2}         [{0},{1}]:{3}", i, j, gabaritoLoteria[i, j], matrizLoteria[i, j]);
                }
            }

            Console.ReadKey();
        }
    }
}