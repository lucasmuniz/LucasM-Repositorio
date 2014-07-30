using System;
using System.Collections.Generic;
using System.Linq;

namespace UNIDADE_COMPLEMENTAR.Exercicios
{
    internal class _02_MaiorMenorMedia
    {
        public static void Main02(string[] args)
        {
            /*2) Faça um algoritmo que leia uma coleção com 80 números decimais e encontre o menor valor, o maior valor, a média
             * e a soma de todos os valores.*/

            List<double> Lista = new List<double>();
            Console.WriteLine("Digite os valores: ");
            for (int i = 0; i < 8; i++)
            {
                Lista.Add(Convert.ToInt32(Console.ReadLine()));
            }
            Console.WriteLine("\n\n");
            Console.WriteLine("======= RESULTADOS =======\n");
            Console.WriteLine("Menor valor: {0}", Lista.Min());//min
            Console.WriteLine("Maior valor: {0}", Lista.Max());//max
            Console.WriteLine("Média: {0}", Lista.Average());  //average
            Console.WriteLine("Soma: {0}",Lista.Sum());        //sum
            Console.ReadKey();
        }
    }
}