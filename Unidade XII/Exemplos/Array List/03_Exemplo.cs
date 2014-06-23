using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade_XII.Exemplos.Array_List
{
    class _03_Exemplo
    {
        public static void Main03(string[] args)
        {
            Console.WriteLine("Digite os valores: ");

            ArrayList myAL = new ArrayList();
            for (int i = 0; i < 10; i++)
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
