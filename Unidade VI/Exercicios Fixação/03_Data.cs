using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade_VI.Exercicios_Fixação
{
    class _03_Data
    {
        static void Main03(string[] args)
        {

        //Crie um algoritmo que receba o dia, mês e ano de uma data de nascimento (como parâmetros de entrada do método) e
        //imprima a data por extenso no formato: dia de nome_mes de ano.

            int dia, ano, mes;
            Console.WriteLine("Digite o dia: ");
            dia = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o mes: ");
            mes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite  ano: ");
            ano = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0}/{1}/{2}",dia,mes,ano);

            Console.ReadKey();
        }
        
    }
}
