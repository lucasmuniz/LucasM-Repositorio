using System;

namespace Unidade_XI.Exercicios_Complementares
{
    internal class _01_MegaSena
    {
        public static int[] arrayMega = new int[6];
        public static int[] gabaritoMega = new int[6];
        public static Random gerador = new Random();

        public static void Main01(string[] args)
        {
            /*implemente um gerador (Aleatório) de números sorteados da mega-sena. É necessário acertar a sena, o que significa obter coincidência
             * entre seis dos números apostados e os seis números sorteados, de um total de sessenta dezenas (de 01 a 60), independentemente da
             * ordem da aposta ou da ordem do sorteio.*/

            GabaritoMega();

            MegaSorteada();

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

        private static void MegaSorteada()
        {
            for (int i = 0; i < arrayMega.Length; i++)
            {
                arrayMega[i] = gerador.Next(0, 60);
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