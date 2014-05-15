using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaliacoes.Medindo_Febre_06
{
    class _12_AulasAluno
    {
        public static double mediaDaTurma, totalDeNotas, reprovado, aprovado, mediaAritmetica,totAlunos,maiorMedia=0,menorMedia=11;
        public static void Main(string[]args)
        {
            int numeroMatricula,aulasComparecidas;
            double n1, n2, n3;
            for (int i = 1; i <= 100; i++)
            {
                totAlunos++;
                Console.Write("Digite o número de matricula: ");
                numeroMatricula = Convert.ToInt32(Console.ReadLine());
                Console.Write("Digite a nota 1: ");
                n1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Digite a nota 2: ");
                n2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Digite a nota 3: ");
                n3 = Convert.ToDouble(Console.ReadLine());
                if (n1>10 || n2>10 || n3>10)
                {
                    Console.WriteLine("NÃO EXISTE NOTA MAIOR QUE 10!!");
                    break;
                }
                Console.Write("Digite o total de aulas que voce compareceu: \n");
                aulasComparecidas = Convert.ToInt32(Console.ReadLine());

                if (aulasComparecidas>=40)
                {
                    mediaAritmetica = (n1 + n2 + n3) / 3;     
                    
                    if (mediaAritmetica>maiorMedia)
                    {
                        maiorMedia = mediaAritmetica;
                    }
                    if (mediaAritmetica<menorMedia)
                    {
                        menorMedia = mediaAritmetica;
                    }
            
                    totalDeNotas = n1+n2+n3;
                  
                    if (mediaAritmetica>=6.0)
                    {
                        aprovado++;
                        Console.WriteLine("Número de matrícula é: {0}",numeroMatricula);
                        Console.WriteLine("Voce foi aprovado com média: {0}",mediaAritmetica.ToString("##.##"));
                        Console.WriteLine("Compareceu {0} aulas.\n",aulasComparecidas);
                    }
                }
                else if (aulasComparecidas<40||mediaAritmetica<6.0)
                {
                    reprovado++;
                }              
            }
            mediaDaTurma = totalDeNotas / 100;
            Console.WriteLine("\n");
            Console.WriteLine("A media total da turma foi {0}", mediaDaTurma.ToString("##.##"));
            Console.WriteLine("A maior media da turma é: {0}", maiorMedia.ToString("##.##"));
            Console.WriteLine("A menor media da turma é: {0}", menorMedia.ToString("##.##"));
            Console.WriteLine("Total de alunos: {0}",totAlunos);
            Console.WriteLine("Total reprovados: {0}",reprovado);
            Console.WriteLine("Total aprovados: {0}",aprovado);
            Console.ReadKey();
        }
    }
}
