using System;
using System.Collections.Generic;

namespace Unidade_XII.Exemplos.Dictionary
{
    internal class _01_Exemplo
    {
        public static void Main01(string[] args)
        {
            Dictionary<string, string> Matriz = new Dictionary<string, string>();
            Matriz.Add("1", "Lucas");
            Console.WriteLine(Matriz["1"]); //Classe Dictionary(TKey, TValue) TKEY COMO SE FOSSE UM ID
            Console.ReadKey();
        }
    }
}