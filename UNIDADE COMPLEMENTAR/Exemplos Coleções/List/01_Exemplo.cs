using System;
using System.Collections.Generic;

namespace Unidade_XII.Exemplos.List
{
    internal class _01_Exemplo
    {
        public static void Main01(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(1);
            int x = list[0];
            Console.WriteLine("Valor fixo:", x);

            for (int i = 0; i <5; i++)
            {
                Console.WriteLine("Digite o valor: ");
                list.Add(Convert.ToInt32(Console.ReadLine()));
            }
            Console.WriteLine("Resultado !");
            foreach (int Y in list)
            {
                Console.WriteLine(Y);
            }

            Console.ReadKey();
        }
    }
}