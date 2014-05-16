using System;

namespace Unidade_VIII.Exercicio_Slide.Controle_de_Fluxo
{
    internal class _02_VerificaValorProduto
    {
        public static void Main02(string[] args)
        {
            Random geradorPreco = new Random();
            double precoProduto = geradorPreco.NextDouble();
            precoProduto = precoProduto * 10;
            if (precoProduto >= 5)
            {
                Console.WriteLine("Preco do produto: {0}", precoProduto.ToString("##.##"));
                Console.WriteLine("É CARO!");
            }
            else
            {
                Console.WriteLine("Precod o prodto: {0}", precoProduto.ToString("##.##"));
                Console.WriteLine("ESTÁ EM CONTA");
            }
            Console.ReadKey();
        }
    }
}