using System;

namespace Unidade_VIII.Exercicios_Complementares
{
    internal class _02_Estrelinhas
    {
        public static void Main02(string[] args)
        {
            /*)  Crie um programa em C# que exiba o seguinte padrão no terminal.
             **********
              **********
               **********
                **********
                 **********
            **********
             **********
              **********
               **********
                **********
            **********
             **********
              **********
               **********
                **********
             */
            for (int i = 0; i <= 2; i++)
            {
                Console.WriteLine("*********");

                Console.WriteLine(" **********");

                Console.WriteLine("  **********");

                Console.WriteLine("   **********");

                Console.WriteLine("   **********");
            }
            Console.ReadKey();
        }
    }
}