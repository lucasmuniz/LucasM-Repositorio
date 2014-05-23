using System;

namespace Unidade_X.Exercicios_Fixação
{
    internal class _02_JuroComposto
    {
        public static double CapitalInicial, Montante, TaxaDeJuros, Tempo, calculo1;

        public static void Main02(string[] args)
        {
            /*Na pasta funcoes-ou-metodos, crie um arquivo chamado JurosComposto.cs.
              Implemente um programa em C# definindo um método que realize o cálculo do montante obtido com a
              aplicação de juros compostos. M = C * (1 + i)t */

            Console.Write("Digite o seu Capital inicial: ");
            CapitalInicial = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a taxa de juros: ");
            TaxaDeJuros = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o tempo: ");
            Calculos();
            Console.WriteLine("============= RESULTADO ===========\a\n");
            Console.WriteLine("Montante: {0}", Montante.ToString("##.##"));
            Console.ReadKey();
        }

        public static void Calculos()
        {
            Tempo = Convert.ToDouble(Console.ReadLine());
            calculo1 = Math.Pow(1 + TaxaDeJuros, Tempo);
            Montante = CapitalInicial * calculo1;
            //Montante=CapitalInicial*(1+TaxaDeJuros);
        }
    }
}