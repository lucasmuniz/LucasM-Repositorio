using System;

namespace Unidade_VIII.Exercicio_Slide.Instrucoes_Repeticoes
{
    internal class _04_DivideMaiorInteiro
    {
        public static void Main04(string[] args)
        {
            int maiorNumero = 2147483647;
            while (maiorNumero > 100)
            {
                maiorNumero = maiorNumero / 2;
                if (maiorNumero > 100)
                {
                    Console.WriteLine(maiorNumero);
                }
            }
            Console.ReadKey();
        }
    }
}