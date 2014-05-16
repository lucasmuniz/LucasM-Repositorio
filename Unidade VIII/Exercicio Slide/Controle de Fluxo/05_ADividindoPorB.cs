using System;

namespace Unidade_VIII.Exercicio_Slide.Controle_de_Fluxo
{
    internal class _05_ADividindoPorB
    {
        public static void Main05(string[] args)
        {
            Console.Write("Digite o valor de A: ");
            int a = Convert.ToInt16(Console.ReadLine());
            Console.Write("Digite o valor de B:");
            int b = Convert.ToInt16(Console.ReadLine());

            if (a % b == 0)
            {
                Console.WriteLine("É DIVISIVEL");
            }
            else
            {
                Console.WriteLine("Nao é divisivel");
            }
            Console.ReadKey();
        }
    }
}