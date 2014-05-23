using System;

namespace Unidade_X.Exercicios_Fixação
{
    internal class _04_IndiceDeMassaCorporal
    {
        public static double Peso, Altura, CalculoQuadrado, Resultado;

        public static void Main04(string[] args)
        {
            /*Na pasta funcoes-ou-metodos, crie um arquivo chamado IMC.cs. Implemente um programa em
             C# definindo um método que realize o cálculo do índice de massa corporal e outro que
             determina a situação da pessoa a partir desse índice.     IMC=PESO*ALTURA²       */
            Console.Write("Digite o seu peso :");
            Peso = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a sua altura: ");
            CalculoIMC();
            InformaResultado();
            Console.WriteLine("\n");
            Console.WriteLine("======= REUSLTADO =======\n");
            Console.WriteLine("Seu IMC é: {0}", Resultado);
            Console.ReadKey();
        }

        private static void InformaResultado()
        {
            if (Resultado < 17)
            {
                Console.WriteLine("Muito abaixo do peso! ");
            }
            if (Resultado >= 17 && Resultado <= 18.49)
            {
                Console.WriteLine("Abaixo do peso");
            }
            if (Resultado >= 18.5 && Resultado <= 24.99)
            {
                Console.WriteLine("Peso Normal");
            }
            if (Resultado >= 25 && Resultado <= 29.99)
            {
                Console.WriteLine("Acima do Peso");
            }
            if (Resultado >= 30 && Resultado <= 34.99)
            {
                Console.WriteLine("Obesidade I");
            }
            if (Resultado >= 35 && Resultado <= 39.99)
            {
                Console.WriteLine("Obesidade II");
            }
            if (Resultado >= 40)
            {
                Console.WriteLine("Obesidade III");
            }
        }

        private static void CalculoIMC()
        {
            Altura = Convert.ToDouble(Console.ReadLine());
            CalculoQuadrado = Math.Pow(Altura, 2);
            Resultado = Peso / CalculoQuadrado;
        }
    }
}