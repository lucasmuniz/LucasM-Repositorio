using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade_VII.Exercicio_Slide.Parte_II
{
    class _03_OperadoresLogicos
    {
        public static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Digite um número: ");
            a = Convert.ToInt16(Console.ReadLine());
            if (a>10||a<15)
            {
                Console.WriteLine("Maior que 10 menor que 15 OPERADOR ||");
            }
            if (a>10|a<15)
            {
                Console.WriteLine("Maior que 10 menor que 15 OPERADOR |");
            }
            if (a>10&&a<15)
            {
                Console.WriteLine("Maior que 10 menor que 15 OPERADOR &&");
            }
            if (a>10&a<15)
            {
                Console.WriteLine("Maior que 10 e menor que 15 OPERADOR &");
            }
            Console.ReadKey();
        }
    }
}
