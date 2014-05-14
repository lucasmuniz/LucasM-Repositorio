using System;

namespace Unidade_VIII.Exercicios_Complementares
{
    internal class _01_NumerosAleatorios
    {
        public static void Main(string[] args)
        {
            /* Crie um programa em C# que gere dois números aleatórios e exiba o valor desses números.
               Além disso, esse programa deve exibir a mensagem “Primeiro > Segundo” se o primeiro número for
               maior do que o segundo, a mensagem “Segundo > Primeiro” se o segundo número for maior do que o primeiro e
               mensagem “Primeiro = Segundo” se o primeiro número for igual ao segundo.
           */

            Random geradorNum = new Random();

            int primeiro;
            int segundo;

            primeiro = geradorNum.Next(0, 10);
            segundo = geradorNum.Next(0, 10);
            if (primeiro > segundo)
            {
                Console.WriteLine("");
                Console.WriteLine("Primeiro: {0} Segundo {1}", primeiro, segundo);
                Console.WriteLine("PRIMEIRO > SEGUNDO");
            }
            if (primeiro < segundo)
            {
                Console.WriteLine("");
                Console.WriteLine("Primeiro: {0} Segundo {1}", primeiro, segundo);
                Console.WriteLine("PRIMEIRO < SEGUNDO");
            }

            Console.ReadKey();
        }
    }
}