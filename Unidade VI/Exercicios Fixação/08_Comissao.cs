using System;

namespace Unidade_VI.Exercicios_Fixação
{
    internal class _08_Comissao
    {
        /*8) Uma empresa de vendas tem três corretores. A empresa paga ao corretor uma
        comissão calculada de acordo com o valor de suas vendas. Se o valor da venda
        de um corretor for maior que R$ 50.000.00 a comissão será de 12% do valor
        vendido. Se o valor da venda do corretor estiver entre R$ 30.000.00 e R$
        50.000.00 (incluindo extremos) a comissão será de 9.5%. Em qualquer outro
        caso, a comissão será de 7%. Escreva um algoritmo que gere um relatório
        contendo nome, valor da venda e comissão de cada um dos corretores. O
        relatório deve mostrar também o total de vendas da empresa.
         */
        public static double valorVenda, comissao;
        public static string nome;

        private static void Main08(string[] args)
        {
            Console.WriteLine("Digite o seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Digite o total de vendas do mes: ");
            valorVenda = Convert.ToDouble(Console.ReadLine());

            if (valorVenda > 50000)
            {
                comissao = valorVenda * 0.12;
            }
            if (valorVenda >= 30000 && valorVenda <= 50000)
            {
                comissao = valorVenda * 0.095;
            }
            else
            {
                comissao = valorVenda * 0.07;
            }

            Console.WriteLine("========= RESULTADO ========\n");
            Console.WriteLine("O nome do vendedor é: {0}", nome);
            Console.WriteLine("O valor das vendas é: {0}", valorVenda);
            Console.WriteLine("O valor da comissao é: {0}", comissao);
            Console.ReadKey();
        }
    }
}