using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade_VI.Exercicios_Complementares
{
    class _03_PesoIdeal
    {
        public static double altura, pesoIdeal;
        public static void Main03(string[] args)
        {
            /*3) Tendo como entrada a altura e o sexo (codificado da seguinte forma: 1:feminino 2:masculino) 
             *  de uma pessoa, construa um programa que calcule e imprima seu peso ideal, utilizando as seguintes fórmulas:  
                - para homens : (72.7 * altura) – 58 
                - para mulheres : (62.1 * altura) – 44.7 
              * */
            string sexo;
            Console.WriteLine("======== PESO IDEAL =======");
            Console.WriteLine("1 - Masculino");
            Console.WriteLine("2 - Feminino");
            Console.WriteLine("Digite o sexo: (1 ou 2) ");                  
            sexo = Console.ReadLine();          
            if (sexo=="1")
            {
                Console.WriteLine("Digite a altura: (Utilize com virgula EX: 1,68)"); 
                altura = Convert.ToDouble(Console.ReadLine());
                pesoIdeal = (72.7 * altura) - 58;
                Console.WriteLine("O peso ideal é: {0} KG",pesoIdeal);
            }
            if (sexo=="2")
            {
                Console.WriteLine("Digite a altura: "); 
                altura = Convert.ToDouble(Console.ReadLine());
                pesoIdeal = (62.1 * altura) - 44.7;
                Console.WriteLine("O peso ideal é: {0} KG", pesoIdeal);
            }        
            Console.ReadKey();
        }
    }
}
