using System;

namespace Unidade_VI.Exercicios_Complementares
{
    internal class _06_Fazendeiro
    {
        public static int Id, TotCaixas, Idade;
        public static double SalarioCaixas, Acrescimo, Total;

        public static void Main06(string[] args)
        {
            /*6) Um fazendeiro vai contratar uma equipe de trabalhadores para a colheita de laranjas de sua fazenda.
             * Os trabalhadores serão identificados por um número e pela sua idade. O fazendeiro pagará aos
             * trabalhadores no final do dia conforme a quantidade de caixas colhidas segundo a tabela abaixo:
             * */
            // ate 5     2.00
            // de 6 a 10     2.50
            // 11 a 20       3.50
            //21 ou mais 5.00
            // IDADE
            // 18 a 45 10%
            //45 a 65 20%
            for (int i = 0; i <= 3; i++)
            {
                Console.Write("Digite a sua identificação: ");
                Id = Convert.ToInt16(Console.ReadLine());
                Console.Write("Digite o total de caixas: ");
                TotCaixas = Convert.ToInt32(Console.ReadLine());
                Console.Write("Digite a sua idade: ");
                Idade = Convert.ToInt16(Console.ReadLine());
                if (TotCaixas <= 5)
                {
                    SalarioCaixas = TotCaixas * 2.00;
                }
                if (TotCaixas >= 6 && TotCaixas <= 10)
                {
                    SalarioCaixas = TotCaixas * 2.50;
                }
                if (TotCaixas >= 11 && TotCaixas <= 20)
                {
                    SalarioCaixas = TotCaixas * 3.50;
                }
                if (TotCaixas >= 21)
                {
                    SalarioCaixas = TotCaixas * 5.00;
                }
                if (Idade >= 18 && Idade <= 45)
                {
                    Acrescimo = SalarioCaixas * 0.10;
                    Total = SalarioCaixas + Acrescimo;
                    Console.WriteLine("O salario final do empregado {0} é R${1}\n", Id, Total);
                }
                if (Idade >= 46 && Idade <= 65)
                {
                    Acrescimo = SalarioCaixas * 0.20;
                    Total = SalarioCaixas + Acrescimo;
                    Console.WriteLine("O salario do empregado {0} é R${1}\n", Id, Total);
                }
                if (Idade < 18 && Idade > 65)
                {
                    Console.WriteLine("O salario do empregado {0} é de R${1}\n", Id, SalarioCaixas);
                }
            }
        }
    }
}