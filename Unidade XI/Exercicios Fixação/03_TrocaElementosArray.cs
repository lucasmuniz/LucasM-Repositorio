using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade_XI.Exercicios_Fixação
{
    class _03_TrocaElementosArray
    {
		public static void Main (string[] args)
        {
			/*Considere a distribuição das vagas da garagem de um condomínio. Essas vagas foram numeradas de 1 a 100 e cada vaga está associada 
             * ao número do apartamento que a utilizará.
             * 22}. De acordo com as informações contidas nessearray, podemos deduzir que a vaga 1 pertence ao apartamento 12, a vaga 2 ao apartamento 34,
             * a vaga 3 ao apartamento 11 e a vaga 4 ao apartamento 22. De acordo com o interesse dos moradores, as vagas podem ser trocadas entre os 
             * apartamentos. implemente um método que realize a troca dos valores contidos em duas posições de um array.*/

            int[] array = new int[2];
            int[] segundoArray = new int[2];
            int auxiliar1;
            int auxiliar2;

            for (int i = 0; i < array.Length; i++)
            {

                Console.Write("Digite o valor da posição {0}: ", i); 
                array[i] = Convert.ToInt16(Console.ReadLine());
				auxiliar1=array[0];
				auxiliar2=array[1];

                segundoArray[0] = auxiliar2;
                segundoArray[1] = auxiliar1;
            }

            for (int j = 0; j < segundoArray.Length; j++)
            {

                Console.WriteLine("Resultado {0}",segundoArray[j]);
            }
            
            Console.ReadKey();
        }
    }
}
