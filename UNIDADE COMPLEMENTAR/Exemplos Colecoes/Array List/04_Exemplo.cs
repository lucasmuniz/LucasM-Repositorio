using System;
using System.Collections;

namespace Unidade_XII.Exemplos.Array_List
{
    internal class _04_Exemplo
    {
        public static void Main04(string[] args)
        {
            Console.WriteLine("Quantos numeros deseja digitar? ");
            int tot = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite os valores: ");

            ArrayList myAL = new ArrayList();
            for (int i = 0; i < tot; i++)
            {
                myAL.Add(Convert.ToInt32(Console.ReadLine())); //ADD VALORES
            }
            Console.WriteLine("ESCREVE OS VALORES\n\n");
            foreach (int i in myAL)
            {                                                   //ESCREVE OS VALORES
                Console.Write("Numeros: {0}", i + "");
                Console.WriteLine("");
            }

            Console.WriteLine("CONTADOR \n\n");                 //CONTADOR
            Console.WriteLine("Contador: {0}", myAL.Count);
            Console.WriteLine("");

            Console.WriteLine("ORDEM CRESCENTE \n\n");
            myAL.Sort();                                        //CRESCENTE
            foreach (int i in myAL)
            {
                Console.Write("Ordenado Crescente: {0}", i + "");
                Console.WriteLine("");
            }
            myAL.Reverse();                                     //DECRESCENTE
            foreach (int i in myAL)
            {
                Console.Write("Ordenado Decrescente: {0}", i + "");
                Console.WriteLine("");
            }

            Console.ReadKey();
        }
    }
}