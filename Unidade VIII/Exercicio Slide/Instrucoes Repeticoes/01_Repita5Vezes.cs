using System;

namespace Unidade_VIII.Exercicio_Slide.Instrucoes_Repeticoes
{
    internal class _01_Repita5Vezes
    {
        public static void Main01(string[] args)
        {
            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine("REPETICAO {0}", i);
            }
            Console.ReadKey();
        }
    }
}