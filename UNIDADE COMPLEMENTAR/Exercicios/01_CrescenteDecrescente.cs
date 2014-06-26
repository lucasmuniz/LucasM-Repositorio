using System;
using System.Collections.Generic;

namespace UNIDADE_COMPLEMENTAR.Exercicios
{
    internal class _01_CrescenteDecrescente
    {
        public static void Main01(string[] args)
        {
            /*
                1) Faça um algoritmo que adicione 100 números em qualquer coleção que vocês preferirem, ao final imprima esses
                 * números decrescente e depois crescente.*/

            List<int> list = new List<int>();
            Console.WriteLine("Digite os valores: ");
            for (int i = 0; i < 100; i++)
            {
                list.Add(Convert.ToInt32(Console.ReadLine()));
            }
            list.Sort();


            Console.WriteLine("==== LISTA CRESCENTE ===\n"); //sort
            foreach (int x in list)
            {
                Console.Write(x + " ");
            }


            Console.WriteLine("\n\n");
            list.Reverse();
            Console.WriteLine("==== LISTA DECRESCENTE ===\n"); //reverse
            foreach (int x in list)
            {
                Console.Write(x + " ");
            }

            Console.ReadKey();
        }
    }
}