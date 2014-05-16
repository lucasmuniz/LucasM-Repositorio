using System;

namespace Unidade_VIII.Exercicio_Slide.Instrucoes_Repeticoes
{
    internal class _03_Imprime100ExcetoMultiplo3
    {
        public static void Main03(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 != 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}