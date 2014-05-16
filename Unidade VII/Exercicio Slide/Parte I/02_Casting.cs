using System;

namespace Unidade_VII.Exercicio_Slide
{
    internal class _02_Casting
    {
        public static void Main02(string[] args)
        {
            double a = 1.5, b = 2.0, c;
            c = (int)a + b;
            Console.WriteLine("O valor de C é: {0}", c);
            Console.ReadKey();
        }
    }
}