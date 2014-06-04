using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade_XI.Exercicios_Fixação
{
    class _02_MediaArray
    {
        public static int pontuacaoTotal = 0,media=0;
        public static void Main02(string[] args)
        {
            /*Considere umarrayque armazena a quantidade de pontos que uma equipe de basquete efetuou nos jogos de um campeonato.
             * A primeira posição doarrayarmazena a quantidade de pontos efetuados no primeiro jogo. A segunda posição armazena a 
             * quantidade de pontos efetuados no segundo jogo. E assim por diante. A nossa tarefa é calcular quantos pontos em média essa 
             * equipe efetua por partida*/
            int[] pontuacaoJogos = new int[4];

            for (int i = 0; i < pontuacaoJogos.Length; i++)
            {
                Console.Write("Digite a pontuação final do jogo {0}: ", i);
                pontuacaoJogos[i] = Convert.ToInt16(Console.ReadLine());
                pontuacaoTotal = pontuacaoTotal + pontuacaoJogos[i];
            }
            media = pontuacaoTotal / pontuacaoJogos.Length;
            Console.WriteLine("");
            Console.WriteLine("========= RESULTADO =========");
            Console.WriteLine("Média das pontuações: {0}",media);
            Console.ReadKey();
        }
    }
}
