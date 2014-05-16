using System;

namespace Unidade_VII.Exercicios_Fixação
{
    internal class _02_Prefeitura
    {
        public static int ContadorDeHabit, ContadorMenor_CentoECinquenta, Program = 1, TotalDeFilhos, FilhosPorFamilia;
        public static double SalarioHabitante, MediaSalarial, MediaDeFilhos, MaiorSalario = 0, Porcentagem_pobres;
        public static double ValorSalarioTotal;

        public static void Main02(string[] args)
        {
            /* A prefeitura de uma cidade deseja fazer uma pesquisa entre seus habitantes. Faça um algoritmos para
               coletar dados sobre o salário e número de filhos de cada habitante e após as leituras, escrever:
            a) Média de salário da população
            b) Média do número de filhos
            c) Maior salário dos habitantes
            d) Percentual de pessoas com salário menor que R$ 150,00
            Obs.: O final da leituras dos dados se dará com a entrada de um “salário negativo”
            */
            while (Program == 1)
            {
                Console.WriteLine("Digite o salario do habitante: ");
                SalarioHabitante = Convert.ToDouble(Console.ReadLine());
                ContadorDeHabit++;
                if (SalarioHabitante < 0)
                {
                    Program = 0;
                    ResultadoFinal();
                }
                if (SalarioHabitante < 150)
                {
                    ContadorMenor_CentoECinquenta++;
                }
                if (SalarioHabitante > MaiorSalario)
                {
                    MaiorSalario = SalarioHabitante;
                }
                ValorSalarioTotal = ValorSalarioTotal + SalarioHabitante;
                Console.WriteLine("Digite o total de filhos: ");
                FilhosPorFamilia = Convert.ToInt16(Console.ReadLine());
                TotalDeFilhos = TotalDeFilhos + FilhosPorFamilia;
            }

            ResultadoFinal();
            Program = 0;
        }

        private static void ResultadoFinal()
        {
            MediaSalarial = ValorSalarioTotal / ContadorDeHabit;
            MediaDeFilhos = TotalDeFilhos / ContadorDeHabit;
            Porcentagem_pobres = (ContadorDeHabit / ContadorMenor_CentoECinquenta) * 10;
            Console.WriteLine("========== RESULTADO FINAL DAS ENTREVISTAS ==========\n");
            Console.WriteLine("A média salarial de todos os habitantes é: {0}R$", MediaSalarial.ToString("##.##"));
            Console.WriteLine("A média de filhos por habitante na cidade e : {0}", MediaDeFilhos);
            Console.WriteLine("O maior salário da população é: {0}R$", MaiorSalario);
            Console.WriteLine("A porcentagem da população que possui baixa renda é {0}%", Porcentagem_pobres.ToString("##.##"));
            Console.ReadKey();
        }
    }
}