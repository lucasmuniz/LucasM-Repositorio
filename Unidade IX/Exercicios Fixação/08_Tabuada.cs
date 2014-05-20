using System;

namespace ConsoleApplication1
{
    internal class Tabuada
    {
        //Na pasta arrays, crie um arquivo chamado Tabuada.cs. Implemente um programa em C# que armazene números inteiros em um array
        //de arrays. Ao final, exiba no terminal esses valores.

        private static void Main8(string[] args)
        {
            int[,] valores = new int[11, 11];

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(" ");
                Console.WriteLine("--------------------- ");
                Console.WriteLine("Tabuada do {0} ", i);
                Console.WriteLine("--------------------- ");
                Console.WriteLine(" ");
                for (int j = 0; j <= 10; j++)
                {
                    valores[i, j] = i * j;
                    Console.WriteLine("{0}x{1} = {2}", i, j, valores[i, j]);
                }
            }

            Console.ReadKey();
        }
    }
}