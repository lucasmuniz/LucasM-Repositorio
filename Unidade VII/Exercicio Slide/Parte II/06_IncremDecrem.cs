using System;

namespace Unidade_VII.Exercicio_Slide.Parte_II
{
    internal class _06_IncremDecrem
    {
        public static void Main06(string[] args)
        {
            //================= PÓS E PRÉ INCREMENTO ===============

            int j = 10;
            int k = 10;

            ++j;
            Console.WriteLine("++j:{0}", j);
            k++;
            Console.WriteLine("k++:{0}", j);

            //================ PÓS E PRÉ DECREMENTO ================

            int l = 10;
            int m = 10;

            --l;
            Console.WriteLine("--l:{0}", j);
            m--;
            Console.WriteLine("m--:{0}", j);

            Console.ReadKey();
        }
    }
}