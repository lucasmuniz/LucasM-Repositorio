using System;

namespace Unidade_VI.Exercicios_Complementares
{
    internal class _03_PesoIdeal
    {
        public static double Altura, PesoIdeal;

        public static void Main03(string[] args)
        {
            /*3) Tendo como entrada a altura e o sexo (codificado da seguinte forma: 1:feminino 2:masculino)
             *  de uma pessoa, construa um programa que calcule e imprima seu peso ideal, utilizando as seguintes fórmulas:
                - para homens : (72.7 * altura) – 58
                - para mulheres : (62.1 * altura) – 44.7
               */
            string sexo;
            Console.WriteLine("======== PESO IDEAL =======");
            Console.WriteLine("1 - Masculino");
            Console.WriteLine("2 - Feminino");
            Console.WriteLine("Digite o sexo: (1 ou 2) ");
            sexo = Console.ReadLine();
            if (sexo == "1")
            {
                Console.WriteLine("Digite a altura: (Utilize com virgula EX: 1,68)");
                Altura = Convert.ToDouble(Console.ReadLine());
                PesoIdeal = (72.7 * Altura) - 58;
                Console.WriteLine("O peso ideal é: {0} KG", PesoIdeal);
            }
            if (sexo == "2")
            {
                Console.WriteLine("Digite a altura: ");
                Altura = Convert.ToDouble(Console.ReadLine());
                PesoIdeal = (62.1 * Altura) - 44.7;
                Console.WriteLine("O peso ideal é: {0} KG", PesoIdeal);
            }
            Console.ReadKey();
        }
    }
}