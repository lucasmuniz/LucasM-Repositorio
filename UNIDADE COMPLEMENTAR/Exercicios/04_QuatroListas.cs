using System;
using System.Collections;
using System.Collections.Generic;

namespace UNIDADE_COMPLEMENTAR.Exercicios
{
    internal class _04_QuatroListas
    {
        public static void Main04(string[] args)
        {
            /*4) Faça 4 listas com diferentes coleções, List, ArrayList, IList, Dictionary. Adicione dados em cada uma delas e no
             * final liste-os*/

            List<int> _List = new List<int>();
            ArrayList _ArrayList = new ArrayList();
            IList<int> _Ilist = new List<int>();
            Dictionary<int, string> _Dictionary = new Dictionary<int, string>();
            _List.Add(1);
            _ArrayList.Add(2);
            _Ilist.Add(3);
            _Dictionary.Add(1, "Lucas");

            foreach (var x in _List)
            {
                Console.WriteLine(x);
            }
            foreach (var x in _ArrayList)
            {
                Console.WriteLine(x);
            }
            foreach (var x in _Ilist)
            {
                Console.WriteLine(x);
            }
            foreach (var x in _Dictionary)
            {
                Console.WriteLine(x);
            }
            Console.ReadKey();
        }
    }
}