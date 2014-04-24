using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade_VI.Exercicios_Fixação
{
    class _04_Temperatura
    {
        public static double mediaTemp;
        public static double mediaFinal;
        static void Main(string[] args)
        {
            
            // Ler um vetor armazenando a temperatura média do dia durante um mês completo.
            //Ao final calcular a temperatura média no mês, considerando 30 dias, e calcular a quantidade de dias que a 
            //temperatura passou da média de 35 graus no dia.

            int[] temp = new int[5];
            
            int contMedia = 0;
            for (int i = 0; i<temp.Length; i++)
            {
                Console.WriteLine("Digite a temperatura do dia {0}: ",i+1);
                temp[i] = Convert.ToInt16(Console.ReadLine());
                mediaTemp = mediaTemp + temp[i];
                if (temp[i]>35)
                {
                    contMedia++;
                }
                
            }
            
            mediaFinal = mediaTemp / 30;
            Console.WriteLine("Total de dias que a temp foi maior que 35 graus: {0}",contMedia+" dias");
            Console.WriteLine("A media da temperatura do mes foi de: {0}",mediaFinal.ToString("##.##")+" graus");
            Console.ReadKey();
        }
    }
}
