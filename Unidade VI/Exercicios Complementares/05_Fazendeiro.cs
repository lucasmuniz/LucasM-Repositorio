using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade_VI.Exercicios_Complementares
{
    class _06_Fazendeiro
    {
        public static int id,totCaixas,idade;
        public static double salarioCaixas, acrescimo,total;
        public static void Main06(string[] args)
        {
            /*6) Um fazendeiro vai contratar uma equipe de trabalhadores para a colheita de laranjas de sua fazenda. 
             * Os trabalhadores serão identificados por um número e pela sua idade. O fazendeiro pagará aos
             * trabalhadores no final do dia conforme a quantidade de caixas colhidas segundo a tabela abaixo:
             * */
            // ate 5     2.00 
            // de 6 a 10     2.50
            // 11 a 20       3.50
            //21 ou mais 5.00
            // IDADE
            // 18 a 45 10%
            //45 a 65 20%
            for (int i = 0; i <=3 ; i++)
            {
                Console.Write("Digite a sua identificação: ");
                id = Convert.ToInt16(Console.ReadLine());
                Console.Write("Digite o total de caixas: ");
                totCaixas = Convert.ToInt32(Console.ReadLine());
                Console.Write("Digite a sua idade: ");
                idade = Convert.ToInt16(Console.ReadLine());
                if (totCaixas<=5)
                {
                    salarioCaixas=totCaixas*2.00;                    
                }
                if (totCaixas>=6 && totCaixas<=10)
                {
                    salarioCaixas = totCaixas * 2.50;
                }
                if (totCaixas>=11 && totCaixas<=20)
                {
                    salarioCaixas = totCaixas * 3.50;
                }
                if (totCaixas>=21)
                {
                    salarioCaixas = totCaixas * 5.00;
                }
                if (idade>=18 && idade<=45)
                {
                    acrescimo = salarioCaixas * 0.10;
                    total = salarioCaixas + acrescimo;
                    Console.WriteLine("O salario final do empregado {0} é R${1}\n",id,total);

                }
                if (idade>=46 && idade <=65)
                {
                    acrescimo = salarioCaixas * 0.20;
                    total = salarioCaixas + acrescimo;
                    Console.WriteLine("O salario do empregado {0} é R${1}\n",id,total);
                }
                if (idade<18 && idade>65)
                {
                    Console.WriteLine("O salario do empregado {0} é de R${1}\n",id,salarioCaixas);
                }
            }
            

            

        }
    }
}
