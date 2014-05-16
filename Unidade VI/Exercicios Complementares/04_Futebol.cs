using System;

namespace Unidade_VI.Exercicios_Complementares
{
    internal class _04_Futebol
    {
        /*
         * 4) Escreva um programa para receber números aleatórios de gols marcados pelo Grêmio e o
         * número de gols marcados pelo Inter em um GRENAL. Escrever o nome do vencedor. Mostre no final o vencedor
         * e quando foi a partida. Caso não haja vencedor deverá ser impressa a palavra EMPATE.
         */

        private static void Main04(string[] args)
        {
            int GolGremio, GolGrenal2, cont1 = 0, cont2 = 0;

            Random gerador = new Random();
            for (int i = 0; i <= 5; i++)
            {
                GolGremio = gerador.Next(0, 2);
                cont1 = cont1 + GolGremio;
                GolGrenal2 = gerador.Next(0, 2);
                cont2 = cont2 + GolGrenal2;
            }
            if (cont1 > cont2)
            {
                Console.WriteLine("GREMIO GANHOU O JOGO DEU {0}x{1}!!!", cont1, cont2);
            }
            if (cont1 < cont2)
            {
                Console.WriteLine("GRENAL GANHOU O JOGO DEU {0}x{1}!!!", cont2, cont1);
            }
            else if (cont1 == cont2)
            {
                Console.WriteLine("O JOGO EMPATOU {0}x{1}", cont1, cont2);
            }
            Console.ReadKey();
        }
    }
}