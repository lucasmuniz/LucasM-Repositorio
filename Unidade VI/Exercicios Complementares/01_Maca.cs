using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade_VI.Exercicios_Complementares
{
    class _01_Maca
    {
        /*1) As maçãs custam R$ 0,30 cada se forem compradas menos do que uma dúzia, e R$ 0,25 se forem compradas pelo menos doze. 
         * Escreva um programa que leia o número de maçãs compradas, calcule e escreva o valor total da compra.
         * */
        static void Main01(string[] args)
        {
            int totalMacas;
            double valorMaca, valorFinal;
            Console.WriteLine("Digite o total de maças compradas: ");
            totalMacas = Convert.ToInt16(Console.ReadLine());
            if (totalMacas<12)
            {
                valorMaca = 0.30;
                valorFinal = totalMacas * valorMaca;
                Console.WriteLine("O valor da compra é: {0}",valorFinal);
            }
            if (totalMacas>=12)
            {
                valorMaca = 0.25;
                valorFinal = totalMacas * valorMaca;
                Console.WriteLine("O valor da compra é: {0}",valorFinal); 
            }
            Console.ReadKey();
        }
    }
}
