using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade_VI.Exercicios_Fixação
{
    class _02_VetorConcatenacao
    {

        static void Main02(string[] args)
        {
            // Ler dois vetores A e B de tamanho 10 e 15 elementos respectivamente, 
            //em seguida geram um terceiro vetor C sendo a concatenação (junção) dos vetores: A e B.

            int[] vetorA = new int [10];
            int[] vetorB = new int[15];
            int[] vetorC = new int[25];

            for (int i = 0; i <=9 ; i++)
            {
                Console.WriteLine("VETOR A - Digite o valor para a posicao {0}: ",i);
                vetorA[i] = Convert.ToInt32(Console.ReadLine());
                vetorC[i] = vetorA[i];
            }
            for (int i = 0; i <=14; i++)
            {
                Console.WriteLine("VETOR B - Digite o valor para a posicao {0}: ",i);
                vetorB[i] = Convert.ToInt32(Console.ReadLine());
                vetorC[i+10] = vetorB[i]; //i+10 pra entrar na posicao 11.
;            }
            for (int i= 0; i <=24; i++)
            {
                Console.WriteLine("==== CONCATENAÇÃO ====");
                Console.Write(" "+vetorC[i]);
                
            }
            Console.ReadKey();

        }
    }
}
