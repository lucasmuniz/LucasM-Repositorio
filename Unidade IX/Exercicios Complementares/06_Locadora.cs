using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade_IX.Exercicios_Complementares
{
    class _06_Locadora
    {
        public static void Main06(string[] args)
        {
            /*Uma locadora de vídeos tem guardada, em um vetor de 50 posições, a quantidade de filmes retirados por seus 
             * clientes durante o ano de 2004. Agora, está locadora está fazendo uma promoção e, para cada 10 filmes retirados, 
             * o cliente tem direito a uma locação grátis. Faça um algoritmo que crie um outro vetor contendo a quantidade de 
             * locações gratuitas a que cada cliente tem direito.*/
            int[] totFilmes = new int[50];
            int[] filmesGratis = new int[50];

            for (int i = 0; i < totFilmes.Length; i++)
            {
                Console.WriteLine("Quantos filmes o cliente numero {0} alugou? ",i+1);
                totFilmes[i] = Convert.ToInt32(Console.ReadLine());
                filmesGratis[i] = totFilmes[i] / 10;
            }
            Console.WriteLine("======== RESULTADO =======");
            for (int i = 0; i < filmesGratis.Length; i++)
			{
			 Console.WriteLine("O cliente numero {0} tem direito à {1} filmes grátis!",i,filmesGratis[i]);
			}
            Console.ReadKey();
            
        }
    }
}
