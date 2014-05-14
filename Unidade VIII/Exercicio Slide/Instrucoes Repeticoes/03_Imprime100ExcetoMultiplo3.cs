using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade_VIII.Exercicio_Slide.Instrucoes_Repeticoes
{
    class _03_Imprime100ExcetoMultiplo3
    {
        public static void Main03(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i%3!=0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
