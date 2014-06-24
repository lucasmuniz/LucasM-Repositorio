using System;
using System.Collections;

namespace Unidade_XII.Exemplos.Array_List
{
    internal class _04_Exemplo
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Quantos numeros deseja digitar? ");
            int tot = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite os valores: ");

            ArrayList myAL = new ArrayList();
            for (int i = 0; i < tot; i++)
            {
                myAL.Add(Convert.ToInt32(Console.ReadLine()));
            }
            Console.WriteLine("ESCREVE OS VALORES\n\n");
            foreach (int i in myAL)
            {
                Console.Write("Numeros: {0}", i + "");
                Console.WriteLine("");
            }

            Console.WriteLine("CONTADOR \n\n");
            Console.WriteLine("Contador: {0}", myAL.Count);
            Console.WriteLine("");

            Console.WriteLine("ORDEM CRESCENTE \n\n");
            myAL.Sort();
            foreach (int i in myAL)
            {
                Console.Write("Ordenado: {0}", i + "");
                Console.WriteLine("");
            }

            Console.ReadKey();
        }
    }
}