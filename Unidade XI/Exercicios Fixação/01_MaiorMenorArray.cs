using System;

namespace Unidade_XI.Exercicios_Fixação
{
    internal class _01_MaiorMenorArray
    {
        public static int pontuacaoTotal = 0;

        public static void Main(string[] args)
        {
            /* Crie uma pasta ou um projetoProblemas, crie um arquivo chamadoAchaMaiorOuMenor.cs.
             * Considere umarray que armazena a quantidade de pontos que uma equipe de basquete efetuou nos jogos de um campeonato.
             * A primeira posição do array armazena a quantidade de pontos efetuados no primeiro jogo. A segunda posição armazena a quantidade
             * de pontos efetuados no segundo jogo. E assim por diante. A nossa tarefa é calcular quantos pontos essa equipe fez no campeonato todo.*/

            int[] pontuacaoJogos = new int[4];

            for (int i = 0; i < pontuacaoJogos.Length; i++)
            {
                Console.Write("Digite a pontuação final do jogo {0}: ", i);
                pontuacaoJogos[i] = Convert.ToInt16(Console.ReadLine());
                pontuacaoTotal = pontuacaoTotal + pontuacaoJogos[i];
            }

            Console.WriteLine("");
            Console.WriteLine("========== RESULTADO ========");
            Console.WriteLine("O total de pontuação do time no campeonato é {0} pontos.", pontuacaoTotal);
            Console.ReadKey();
        }
    }
}