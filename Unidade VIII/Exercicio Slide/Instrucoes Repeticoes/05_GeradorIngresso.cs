using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade_VIII.Exercicio_Slide.Instrucoes_Repeticoes
{
    class _05_GeradorIngresso
    {
        public static void Main05(string[]args)
        {
            for (int i = 1; i <= 4; i++)
            {
                
                for (int j = 1; j <= 20; j++)
                {
                    Console.WriteLine("SETOR: {0} LUGAR: {1}", i, j);   
                }
            }
            Console.ReadKey();
        }
    }
}
