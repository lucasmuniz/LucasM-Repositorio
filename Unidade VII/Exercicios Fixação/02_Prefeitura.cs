using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade_VII.Exercicios_Fixação
{
    class _02_Prefeitura
    {
        public static int contadorDeHabit, contadorMenor_CentoECinquenta, program = 1, totalDeFilhos, filhosPorFamilia;
        public static double salarioHabitante,mediaSalarial,mediaDeFilhos,maiorSalario=0,porcentagem_pobres;
        public static double valorSalarioTotal;

        public static void Main(string[] args)
        {
            /* A prefeitura de uma cidade deseja fazer uma pesquisa entre seus habitantes. Faça um algoritmos para 
             * coletar dados sobre o salário e número de filhos de cada habitante e após as leituras, escrever:           
            a) Média de salário da população 
            b) Média do número de filhos 
            c) Maior salário dos habitantes 
            d) Percentual de pessoas com salário menor que R$ 150,00 
            Obs.: O final da leituras dos dados se dará com a entrada de um “salário negativo”
            */
            while (program==1)
            {
                Console.WriteLine("Digite o salario do habitante: ");
                salarioHabitante = Convert.ToDouble(Console.ReadLine());
                contadorDeHabit++;
                if (salarioHabitante<0)
                {
                    program = 0;
                    ResultadoFinal();
                }
                if (salarioHabitante<150)
                {
                    contadorMenor_CentoECinquenta++;
                }
                if (salarioHabitante>maiorSalario)
                {
                    maiorSalario = salarioHabitante;
                }
                
                valorSalarioTotal = valorSalarioTotal + salarioHabitante;

                Console.WriteLine("Digite o total de filhos: ");
                filhosPorFamilia = Convert.ToInt16(Console.ReadLine());
                totalDeFilhos = totalDeFilhos + filhosPorFamilia;
                
          
            }

            ResultadoFinal();
            program = 0;
        }

        private static void ResultadoFinal()
        {
            
            mediaSalarial = valorSalarioTotal / contadorDeHabit;
            mediaDeFilhos = totalDeFilhos / contadorDeHabit;         
            porcentagem_pobres =(contadorDeHabit/contadorMenor_CentoECinquenta)*10;
            Console.WriteLine("========== RESULTADO FINAL DAS ENTREVISTAS ==========\n");
            Console.WriteLine("A média salarial de todos os habitantes é: {0}R$", mediaSalarial.ToString("##.##"));
            Console.WriteLine("A média de filhos por habitante na cidade e : {0}",mediaDeFilhos);
            Console.WriteLine("O maior salário da população é: {0}R$",maiorSalario);
            Console.WriteLine("A porcentagem da população que possui baixa renda é {0}%", porcentagem_pobres.ToString("##.##"));

            Console.ReadKey();
        }
        
    }
}
            
            

            
   
