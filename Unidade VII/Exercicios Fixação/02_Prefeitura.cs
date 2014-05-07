using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade_VII.Exercicios_Fixação
{
    class _02_Prefeitura
    {
        public static int numero_De_Filhos,program=1,cont_menor;
        public static double salario_Familia, media_Salarial, media_Filhos, maior_Salario = 0, salario_menor,porc_Menor,cont_Filhos;
        
        public static void Main(string[]args)
        {
            /* A prefeitura de uma cidade deseja fazer uma pesquisa entre seus habitantes. Faça um algoritmos para coletar dados 
             * sobre o salário e número de filhos de cada habitante e após as leituras, escrever: 
            a) Média de salário da população 
            b) Média do número de filhos 
            c) Maior salário dos habitantes 
            d) Percentual de pessoas com salário menor que R$ 150,00 
            Obs.: O final da leituras dos dados se dará com a entrada de um “salário negativo”
            */
            while (program == 1)
            {
                Console.WriteLine("Digite o número de filhos que possui na família: ");
                numero_De_Filhos = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite o salário da família: ");
                if (salario_Familia<0)
                {
                    program = 0;
                }
                if (salario_Familia<150)
                {
                    salario_menor = salario_menor + salario_menor;
                    cont_menor++;
                }
                salario_Familia = Convert.ToDouble(Console.ReadLine());
                if (salario_Familia > maior_Salario)
                {
                    maior_Salario = salario_Familia;
                }

            }
            porc_Menor = salario_menor / cont_menor;
            
            

        }
    }
}
