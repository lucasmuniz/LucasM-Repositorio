using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade_XI.Exercicios_Complementares
{
    
    class _02_MegaSena2
    {
        /*2) Continuando na questão 1, o usuário agora deve informar os 6 números que ele deseja escolher. Esses 6 dados devem ser
         * armazenados em um array também, como os números premiados da questão 1. Caso o usuário escolha um número fora do intervalo 
         * do cartão da mega-sena, o software deve avisa-lo.*/

        public static int[] arrayMega = new int[6];
        public static Random gerador = new Random();
        public static int[] gabaritoMega = new int[6];
        public static void Main02(string[] args)
        {

            GabaritoMega();

            for (int i = 0; i < arrayMega.Length; i++)
            {
                Console.WriteLine("Digite o numero que deseja marcar: ");
                arrayMega[i] = Convert.ToInt16(Console.ReadLine());
                if (arrayMega[i]<0||arrayMega[i]>60)
                {
                    Console.WriteLine("Voce Digitou errado!!!");
                    return;
                }
            }

            ResultadoMega();
            Console.ReadKey();


        }

        private static void ResultadoMega()
        {
            Console.WriteLine("APOSTOU:");
            for (int i = 0; i < arrayMega.Length; i++)
            {
                Console.WriteLine(arrayMega[i]);
            }
            Console.WriteLine("");
            Console.WriteLine("GABARITO:");
            for (int i = 0; i < gabaritoMega.Length; i++)
            {
                Console.WriteLine(gabaritoMega[i]);
            }
        }

        private static void GabaritoMega()
        {
            for (int i = 0; i < gabaritoMega.Length; i++)
            {
                gabaritoMega[i] = gerador.Next(0, 60);
            }
        }
    }
}
