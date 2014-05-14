using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade_VIII.Exercicio_Slide.Instrucoes_Repeticoes
{
    class _04_DivideMaiorInteiro
    {
        public static void Main04(string[] args)
        {
            int maiorNumero = 2147483647;
            while (maiorNumero>100)
            {
                maiorNumero = maiorNumero / 2;
                if (maiorNumero>100)
                {
                    Console.WriteLine(maiorNumero);    
                }               
            }
            Console.ReadKey();
        }
    }
}
