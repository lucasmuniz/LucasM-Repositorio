using System;

namespace Unidade_VII.Exercicio_Slide.Parte_II
{
    internal class _01_OperadoresRelacionais
    {
        public static void Main01(string[] args)
        {
            //============ OPERADORES RELACIONAIS ===========
            int num = 5;
            if (num > 5)
            {
                Console.WriteLine("Maior que 5");
            }
            if (num == 5)
            {
                Console.WriteLine("Igual a 5");
            }
            if (num >= 5)
            {
                Console.WriteLine("Maior ou igual a 5");
            }
            if (num <= 5)
            {
                Console.WriteLine("Menor ou igual a 5");
            }
            if (num < 5)
            {
                Console.WriteLine("Menor que 5");
            }
            Console.ReadKey();
        }
    }
}