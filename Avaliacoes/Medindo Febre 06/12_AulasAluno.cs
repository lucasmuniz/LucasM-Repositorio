using System;

namespace Avaliacoes.Medindo_Febre_06
{
    internal class _12_AulasAluno
    {
        public static double MediaDaTurma, TotalDeNotas, Reprovado, Aprovado, MediaAritmetica, TotAlunos, MaiorMedia = 0, MenorMedia = 11;

        public static void Main(string[] args)
        {
            int numeroMatricula, aulasComparecidas;
            double n1, n2, n3;
            for (int i = 1; i <= 100; i++)
            {
                TotAlunos++;
                Console.Write("Digite o número de matricula: ");
                numeroMatricula = Convert.ToInt32(Console.ReadLine());
                Console.Write("Digite a nota 1: ");
                n1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Digite a nota 2: ");
                n2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Digite a nota 3: ");
                n3 = Convert.ToDouble(Console.ReadLine());
                if (n1 > 10 || n2 > 10 || n3 > 10)
                {
                    Console.WriteLine("NÃO EXISTE NOTA MAIOR QUE 10!!");
                    break;
                }
                Console.Write("Digite o total de aulas que voce compareceu: \n");
                aulasComparecidas = Convert.ToInt32(Console.ReadLine());

                if (aulasComparecidas >= 40)
                {
                    MediaAritmetica = (n1 + n2 + n3) / 3;

                    if (MediaAritmetica > MaiorMedia)
                    {
                        MaiorMedia = MediaAritmetica;
                    }
                    if (MediaAritmetica < MenorMedia)
                    {
                        MenorMedia = MediaAritmetica;
                    }

                    TotalDeNotas = n1 + n2 + n3;

                    if (MediaAritmetica >= 6.0)
                    {
                        Aprovado++;
                        Console.WriteLine("Número de matrícula é: {0}", numeroMatricula);
                        Console.WriteLine("Voce foi aprovado com média: {0}", MediaAritmetica.ToString("##.##"));
                        Console.WriteLine("Compareceu {0} aulas.\n", aulasComparecidas);
                    }
                    else if (aulasComparecidas < 40 || MediaAritmetica < 6.0)
                    {
                        Reprovado++;
                    }
                }
                
            }
            MediaDaTurma = TotalDeNotas / 100;
            Console.WriteLine("\n");
            Console.WriteLine("A media total da turma foi {0}", MediaDaTurma.ToString("##.##"));
            Console.WriteLine("A maior media da turma é: {0}", MaiorMedia.ToString("##.##"));
            Console.WriteLine("A menor media da turma é: {0}", MenorMedia.ToString("##.##"));
            Console.WriteLine("Total de alunos: {0}", TotAlunos);
            Console.WriteLine("Total reprovados: {0}", Reprovado);
            Console.WriteLine("Total aprovados: {0}", Aprovado);
            Console.ReadKey();
        }
    }
}