using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade_VI.Exercicios_Fixação
{
    class _01_LerVetor
    {

        static void Main01(string[] args)
        {
            //1) Declarar um vetor de 20 números inteiros, em seguida ler os elementos do vetor, 
            //e ao final mostrar somente os número positivos, e mostrar ainda a quantidade de positivos, 
            //a quantidade de negativos e a quantidade de nulos (0).
            
            int contadorPositivo=0, contadorNegativo=0, contadorNulos=0;
            int[] vetor = new int[20];
            
            
            for (int i = 0; i <= 19; i++)
            {
                Console.Write("Digite o valor da posição {0}: ", i);
                vetor[i] = Convert.ToInt32(Console.ReadLine());
                if (vetor[i] > 0)
                {
                    contadorPositivo++;

                }
                else if (vetor[i] < 0)
                {
                    contadorNegativo++;
                }
                else if (vetor[i] == 0)
                {
                    contadorNulos++;
                }
            }
            Console.WriteLine("========= RESULTADO ========");
            for (int i = 0; i <=19; i++)
			{
               if (vetor[i]>0)
               {
                   Console.WriteLine("Numeros positivos: {0}",vetor[i]);
                   
               }
    
			}
            Console.WriteLine("O total de numeros positivos é: {0}", contadorPositivo);
            Console.WriteLine("O total de numeros negativos é: {0}", contadorNegativo);
            Console.WriteLine("O total de numeros zeros é: {0}", contadorNulos);
            Console.ReadKey();

        }
    

    }
}
