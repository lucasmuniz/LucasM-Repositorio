using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade_VIII.Exercicio_Slide.Controle_de_Fluxo
{
    class _07_LançamentoDadosImpares
    {
        public static int num,somaNum;
        public static void Main07(string[]args)
        
        {
            Random gerador = new Random();

            for (int i = 1; i <= 4; i++)
            {
                num = gerador.Next(0, 7);
                Console.WriteLine("Numero gerado: {0}",num);
                if (num%2==0)
                { 
                    continue;
                }
                somaNum += num; //somaNum = SomaNum + num;
                if (somaNum>9)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("VENCEU ");
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
