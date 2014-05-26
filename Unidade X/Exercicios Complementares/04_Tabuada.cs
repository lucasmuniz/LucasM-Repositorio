using System;

namespace Unidade_X.Exercicios_Complementares
{
    internal class _04_Tabuada
    {
        public static void Main04(string[] args)
        {
            /*4) Faça um método chamado tabuada que passa por parâmetro o número da tabuada. Por exemplo se passar 4 por parâmetro ela deve retornar a
             * tabuada completa do 4.*/
            int numeroTabuada;
            Console.WriteLine("Digite qual tabuada voce deseja ver: ");
            numeroTabuada = Convert.ToInt16(Console.ReadLine());
            Tabuada(numeroTabuada);
            Console.ReadKey();
        }

        private static void Tabuada(int numeroTabuada)
        {
            for (int i = 0; i <= 10; i++)
            {
                int resultado;
                resultado = numeroTabuada * i;
                ExibeTabuada(numeroTabuada, i, resultado);
            }
        }

        private static void ExibeTabuada(int numeroTabuada, int i, int resultado)
        {
            Console.WriteLine("{0}x{1}: {2}", numeroTabuada, i, resultado);
        }
    }
}