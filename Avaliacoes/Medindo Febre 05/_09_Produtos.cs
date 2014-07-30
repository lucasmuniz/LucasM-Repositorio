using System;

namespace Avaliacoes.Medindo_a_Febre_05
{
    internal class _09_Produtos
    {
        public static string NomeProduto;
        public static double PrecoUnitario, ValorTotal, ValorDoDesconto, ValorFinal;
        public static int QntAdquirida;

        public static void Main09(string[] args)
        {
            Console.WriteLine("Digite o nome do produto: ");
            NomeProduto = Console.ReadLine();
            Console.WriteLine("Digite a quantidade adquirida do produto {0}: ", NomeProduto);
            QntAdquirida = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o preço unitario do produto {0}: ", NomeProduto);
            PrecoUnitario = Convert.ToDouble(Console.ReadLine());
            ValorTotal = QntAdquirida * PrecoUnitario;

            if (QntAdquirida <= 5)
            {
                Console.WriteLine("\n");
                Console.WriteLine("========= NOTA FISCAL =========");
                Console.WriteLine("Valor sem desconto: R${0}", ValorTotal.ToString("##.##"));
                ValorDoDesconto = ValorTotal * 0.02;
                ValorFinal = ValorTotal - ValorDoDesconto;
                Console.WriteLine("Valor do desconto: R${0}", ValorDoDesconto.ToString("##.##"));
                Console.WriteLine("Valor com desconto: R${0}", ValorFinal.ToString("##.##"));
            }
            else if (QntAdquirida > 5 && QntAdquirida <= 10)
            {
                Console.WriteLine("\n");
                Console.WriteLine("========= NOTA FISCAL =========");
                Console.WriteLine("Valor sem desconto: R${0}", ValorTotal.ToString("##.##"));
                ValorDoDesconto = ValorTotal * 0.03;
                ValorFinal = ValorTotal - ValorDoDesconto;
                Console.WriteLine("Valor do desconto: R${0}", ValorDoDesconto.ToString("##.##"));
                Console.WriteLine("Valor com desconto: R${0}", ValorFinal.ToString("##.##"));
            }
            else
            {
                Console.WriteLine("\n");
                Console.WriteLine("========= NOTA FISCAL =========");
                Console.WriteLine("Valor sem desconto: R${0}", ValorTotal.ToString("##.##"));
                ValorDoDesconto = ValorTotal * 0.05;
                ValorFinal = ValorTotal - ValorDoDesconto;
                Console.WriteLine("Valor do desconto: R${0}", ValorDoDesconto.ToString("##.##"));
                Console.WriteLine("Valor com desconto: R${0}", ValorFinal.ToString("##.##"));
            }

            Console.WriteLine("Você comprou {0} unidades de {1}.", QntAdquirida, NomeProduto);
            Console.WriteLine("O valor final da compra é: R${0}", ValorFinal.ToString("##.##"));

            Console.ReadKey();
        }
    }
}