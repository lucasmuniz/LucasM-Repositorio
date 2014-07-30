using System;
using System.Collections.Generic;

namespace UNIDADE_COMPLEMENTAR.Exercicios
{
    internal class _03_Nomes
    {
        public static void Main03(string[] args)
        {
            /*3) Faça um programa que leia n nomes inserindo-os em uma lista de forma ordenada utilizando a ideia do
             * algoritmo da inserção. No final, o programa deve mostrar todos os nomes ordenados alfabeticamente. */

            List<string> Nomes = new List<string>();
            int contador = 0;
            Console.Write("Digite quantos nomes deseja inserir: ");
            contador = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");
            for (int i = 0; i < contador; i++)
            {
                Console.Write("Digite o nome {0}: ", i);
                Nomes.Add(Console.ReadLine());
            }

            Nomes.Sort();
            Console.WriteLine("\n\n");
            Console.WriteLine("Nomes Ordenados: ");
            foreach (string x in Nomes)
            {
                Console.WriteLine(x);
            }
            Console.ReadKey();
        }
    }
}