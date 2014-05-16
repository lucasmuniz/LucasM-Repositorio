using System;

namespace Unidade_VIII.Exercicios_Complementares
{
    internal class _06_NumAleatorio
    {
        public static void Main(string[] args)
        {
            /*Crie um programa em C# que gere e exiba no terminal um número aleatório.
             Além disso, esse programa deve contabilizar a quantidade de dígitos “1” do número aleatório e
             exibir essa quantidade no terminal. Complete o código abaixo.*/
            int contUm = 0, num;
            Random gerador = new Random();
            for (int i = 1; i < 10; i++)
            {
                num = gerador.Next(0, 5);
                if (num == 1)
                {
                    contUm++;
                }
            }
            Console.WriteLine("Total de numeros '1': {0}", contUm);
            Console.ReadKey();
        }
    }
}