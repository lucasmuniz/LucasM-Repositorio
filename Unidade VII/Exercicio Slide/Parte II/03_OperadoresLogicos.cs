using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade_VII.Exercicio_Slide.Parte_II
{
    class _03_OperadoresLogicos
    {
        public static void Main03(string[] args)
        {
            //============ OPERADOR LOGICO ==============
            int a;
            int geradornum;

            Console.Write("Digite um número: ");
            a = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("\n\n");
            Console.WriteLine("---------------------------------------");
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
            if (a>10^a<15)
            {
                Console.WriteLine("Maior que 10 e menor que 15 OPERADOR ^");
            }
            Random gerador = new Random();
            geradornum = gerador.Next(0,50);
            Console.WriteLine("GERADOR => {0}",geradornum);
            Console.ReadKey();
        }
    }
}
