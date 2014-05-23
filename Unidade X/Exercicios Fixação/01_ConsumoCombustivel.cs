using System;

namespace Unidade_X.Exercicios_Fixação
{
    internal class _01_ConsumoCombustivel
    {
        public static double KmPercorridos, LitrosAbastecidos, Calculo;

        public static void Main01(string[] args)
        {
            //Na pasta funcoes-ou-metodos, crie um arquivo chamado ConsumoDeCombustivel.cs. Implemente um programa em
            //C# definindo um método que realize o cálculo do consumo de combustível de um veículo.

            Console.Write("Digite quantos km você percorreu: ");
            KmPercorridos = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite quantos litros abasteceu: ");
            LitrosAbastecidos = Convert.ToDouble(Console.ReadLine());
            Consumo();
            Console.WriteLine("Seu consumo foi de : {0} km/l.", Calculo.ToString("##.##"));
            Console.ReadKey();
        }

        public static void Consumo()
        {
            Calculo = KmPercorridos / LitrosAbastecidos;
        }
    }
}