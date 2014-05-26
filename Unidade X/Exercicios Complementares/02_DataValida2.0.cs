using System;

namespace Unidade_X.Exercicios_Complementares
{
    internal class _02_DataValida2
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite a data: (DD/MM/AAAA) ");
            string data = Console.ReadLine();
            DateTime dataDigitada;
            if (DateTime.TryParse(data, out dataDigitada))
            {
                Console.WriteLine("Data válida!!");
            }
            else
            {
                Console.WriteLine("Data inválida!!");
            }
            Console.ReadKey();
        }
    }
}