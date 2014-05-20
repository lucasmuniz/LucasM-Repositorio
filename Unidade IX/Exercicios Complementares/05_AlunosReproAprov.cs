using System;

namespace Unidade_IX.Exercicios_Complementares
{
    internal class _05_AlunosReproAprov
    {
        public static void Main5(string[] args)
        {
            /*) Escreva um algoritmo que leia um vetor de 10 posições do tipo caracter, que representa o
             * gabarito de uma prova. A seguir, para cada um dos 20 alunos da turma, leia o vetor de respostas
             * (R) do aluno de 10 posições do tipo caracter e conte o número de acertos. Mostre o nº de acertos do aluno e
             * uma mensagem APROVADO, se a nota for maior ou igual a 6; e mostre uma mensagem de REPROVADO, caso contrário.*/

            string[] gabarito = new string[10];
            string[] aluno = new string[20];
            string[] gabaritoAluno = new string[10];
            int contAcertos = 0;

            for (int i = 0; i < gabarito.Length; i++)
            {
                Console.Write("Digite a resposta Gabarito da prova da questao {0}: ", i + 1);
                gabarito[i] = Console.ReadLine();
            }
            for (int i = 0; i < aluno.Length; i++)
            {
                contAcertos = 0;
                for (int j = 0; j < gabaritoAluno.Length; j++)
                {
                    Console.Write("Digite a sua resposta questao {0}: ", j + 1);
                    gabaritoAluno[i] = Console.ReadLine();
                    if (gabaritoAluno[i] == gabarito[i])
                    {
                        contAcertos++;
                    }
                }
                Console.WriteLine("======= RESULTADO ======\n");
                Console.WriteLine("Acertou {0} questões. ", contAcertos);
                Console.WriteLine("Sua nota foi: {0}", contAcertos);
                if (contAcertos >= 6)
                {
                    Console.WriteLine("APROVADO");
                }
                else if (contAcertos < 6)
                {
                    Console.WriteLine("REPROVADO ");
                }
                Console.WriteLine("");
            }

            Console.ReadKey();
        }
    }
}