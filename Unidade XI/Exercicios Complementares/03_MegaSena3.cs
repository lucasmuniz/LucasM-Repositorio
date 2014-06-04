using System;

namespace Unidade_XI.Exercicios_Complementares
{
    internal class _03_MegaSena3
    {
        public static int[] arrayMega = new int[6];
        public static Random gerador = new Random();
        public static int[] gabaritoMega = new int[6];

        public static void Main(string[] args)
        {
            /*3) Continuando no software da mega-sena. Faça um método que Ordene do menor para o maior número. E mostre os números
                 sorteados da seguinte forma: [ 2 ] [34] [36] [45] [51] [59]*/

            GabaritoMega();

            for (int i = 0; i < arrayMega.Length; i++)
            {
                Console.WriteLine("Digite o numero que deseja marcar: ");
                arrayMega[i] = Convert.ToInt16(Console.ReadLine());
                if (arrayMega[i] < 0 || arrayMega[i] > 60)
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