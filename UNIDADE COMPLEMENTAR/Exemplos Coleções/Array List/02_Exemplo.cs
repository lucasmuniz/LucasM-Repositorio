using System;
using System.Collections;

namespace Unidade_XII.Exemplos.Array_List
{
    internal class _02_Exemplo
    {
        public static void Main02(string[] args)
        {
            ArrayList myAL = new ArrayList();
            for (int i = 0; i < 10; i++)
            {
                myAL.Add(Convert.ToInt32(Console.ReadLine()));
            }
            Console.WriteLine("ESCREVE OS VALORES\n\n");
            foreach (int i in myAL)
            {
                Console.WriteLine(i);
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}