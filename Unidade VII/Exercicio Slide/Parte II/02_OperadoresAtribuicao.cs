using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade_VII.Exercicio_Slide.Parte_II
{
    class _02_OperadoresAtribuicao
    {
        public static void Main02(string[] args)
        {
            int a;
            Console.WriteLine("Digite um numero: ");
            a = Convert.ToInt16(Console.ReadLine());

            a *= 2;
            Console.WriteLine("*= : {0}",a);
            a /= 2;
            Console.WriteLine("/= : {0}", a);
            a %= 2;
            Console.WriteLine("%= : {0}", a);
            a -= 2;
            Console.WriteLine("-= : {0}", a);
            a += 1;
            Console.WriteLine("+= : {0}", a);
            a--;
            Console.WriteLine("-- : {0}", a);
            a++;
            Console.WriteLine("++ : {0}", a);           
            Console.ReadKey();
        }
    }
}
