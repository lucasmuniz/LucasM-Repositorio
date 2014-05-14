using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade_VIII.Exercicio_Slide.Controle_de_Fluxo
{
    class _06_LançamentoDados
    {
        public static int soma;
        public static void Main06(string[] args)
        {
            Random geradorNum = new Random();
          
            for (int i = 0; i <= 5; i++)
            {
                
                int valorGerado = geradorNum.Next(0, 7);
                Console.WriteLine("Valor gerado {0}",valorGerado);

                soma = soma + valorGerado;
                if (soma>=19)
                {
                    Console.WriteLine("A soma é {0}",soma);
                    Console.WriteLine("VENCEDOR");
                    break;
                }
                if (i==5)
                {
                    if (soma<19)
                    {
                        Console.WriteLine("A soma é {0}",soma);
                        Console.WriteLine("PERDEDOR 19");
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
