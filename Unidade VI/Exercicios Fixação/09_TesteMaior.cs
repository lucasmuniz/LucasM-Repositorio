using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade_VI.Exercicios_Fixação
{
    class _09_TesteMaior
    {
        /*9) Faça um algoritmo que leia os valores A, B e C. Mostre uma mensagem que 
            informe se a soma de A com B é menor, maior ou igual a C. 
         */
        static void Main09(string[] args)
        {
            double valorA, valorB, valorC, soma;

            Console.WriteLine("Digite o valor de A: ");
            valorA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor de B: ");
            valorB = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor de C: ");
            valorC = Convert.ToDouble(Console.ReadLine());
            soma = valorA + valorB;
            if (soma>valorC)
            {
                Console.WriteLine("A soma de A+B = {0} é maior que o valor C : {1}.",soma,valorC);                
            }
            if (soma==valorC)
            {
                Console.WriteLine("A soma de A+B = {0} é igual ao valor C: {1}",soma,valorC);
            }
            if (soma<valorC)      
            {
                Console.WriteLine("A soma de A+B = {0} é menor que o valor C: {1}",soma,valorC);
            }
            Console.ReadKey();
        }
    }
}
