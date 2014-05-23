using System;

namespace Unidade_X.Exercicios_Fixação
{
    internal class _03_ImpostoDeRenda
    {
        public static double Salario, Dependentes, InssDescontado, BaseDeCalculo, Aliquota;

        public static void Main03(string[] args)
        {
            /*Na pasta funcoes-ou-metodos, crie um arquivo chamado IRPF.cs. Implemente um programa em C# definindo
             um método que realize o cálculo do imposto de renda pessoa física. */
            Console.Write("Digite o salário: ");
            Salario = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o total de Dependentes: ");
            Dependentes = Convert.ToDouble(Console.ReadLine());
            CalculoDoImposto();
            Console.WriteLine("\n");
            Console.WriteLine("========= RESULTADO =======\n");
            Console.WriteLine("Imposto a pagar: {0}", Aliquota.ToString("##.##"));
            Console.ReadKey();
        }

        private static void CalculoDoImposto()
        {
            InssDescontado = Salario * 0.11;
            Dependentes = Dependentes * 117;
            BaseDeCalculo = Salario - InssDescontado - Dependentes;
            Aliquota = BaseDeCalculo * 0.15;
            Aliquota = Aliquota - 174.60;
        }
    }
}