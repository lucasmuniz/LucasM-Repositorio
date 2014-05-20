using System;

namespace ConsoleApplication1
{
    internal class TabelaQualquer
    {
        //Na pasta arrays, crie um arquivo chamado TabelaQualquer.cs. Implemente um programa em C# que armazene números inteiros em uma array de arrays.
        //Ao final, exiba no terminal esses valores.

        private static void Main(string[] args)
        {
            int[,] valores = new int[3, 2];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write("Digite um número qualquer: ");
                    valores[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("\n");
            Console.WriteLine("===================================\n");

            for (int i = 0; i < 3; i++) //escrever os valores
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write("{0} ", valores[i, j]);
                }
                Console.WriteLine(" ");
            }

            Console.ReadKey();
        }
    }
}