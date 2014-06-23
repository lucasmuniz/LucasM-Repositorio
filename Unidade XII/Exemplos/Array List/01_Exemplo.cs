using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade_XII.Exemplos.Array_List
{
    class _01_Exemplo
    {
        public static void Main01(string[] args)
        {
            ArrayList myAL = new ArrayList();

            myAL.Add(Convert.ToInt32(Console.ReadLine()));

            foreach (int i in myAL)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();


        }
    }
}
