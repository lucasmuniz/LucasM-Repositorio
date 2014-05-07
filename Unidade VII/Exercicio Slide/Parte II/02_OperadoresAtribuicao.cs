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
            int a = 10;
            Console.WriteLine(a++);
            Console.WriteLine(a--);
            Console.WriteLine(a+=1);
            Console.WriteLine(a-=1);
            Console.WriteLine(a%=2);
            Console.WriteLine(a/=2);
            Console.ReadKey();
        }
    }
}
