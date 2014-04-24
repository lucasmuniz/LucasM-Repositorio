using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade_VI.Exercicios_Fixação
{
    class _04_Temperatura
    {
        static void Main(string[] args)
        {

            // Ler um vetor armazenando a temperatura média do dia durante um mês completo.
            //Ao final calcular a temperatura média no mês, considerando 30 dias, e calcular a quantidade de dias que a 
            //temperatura passou da média de 35 graus no dia.

            int[] temp = new int[30];
            
            int contMedia = 0;
            for (int i = 1; i <=30; i++)
            {
                Console.WriteLine("Digite a temperatura do dia {0}: ",i);
                temp[i] = Convert.ToInt16(Console.ReadLine());
                if (temp[i]>35)
                {
                    contMedia++;
                }
            }
            Console.ReadKey();
        }
    }
}
