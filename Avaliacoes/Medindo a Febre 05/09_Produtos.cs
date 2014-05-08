using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaliacoes.Medindo_a_Febre_05
{
    class _09_Produtos
    {
        public static string nomeProduto;
        public static double  precoUnitario, valorTotal, valorDoDesconto, valorFinal;
        public static int qntAdquirida;
        public static void Main09(string[] args)
        {
            Console.WriteLine("Digite o nome do produto: ");
            nomeProduto = Console.ReadLine();
            Console.WriteLine("Digite a quantidade adquirida do produto {0}: ",nomeProduto);
            qntAdquirida = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o preço unitario do produto {0}: ",nomeProduto);
            precoUnitario = Convert.ToDouble(Console.ReadLine());
            valorTotal = qntAdquirida * precoUnitario;

            if (qntAdquirida<=5)
            {
                Console.WriteLine("\n");
                Console.WriteLine("========= NOTA FISCAL =========");
                Console.WriteLine("Valor sem desconto: R${0}", valorTotal.ToString("##.##"));
                valorDoDesconto = valorTotal * 0.02;
                valorFinal = valorTotal - valorDoDesconto;
                Console.WriteLine("Valor do desconto: R${0}", valorDoDesconto.ToString("##.##"));
                Console.WriteLine("Valor com desconto: R${0}", valorFinal.ToString("##.##"));
                
            }
            else if (qntAdquirida>5 && qntAdquirida<=10)
            {
                Console.WriteLine("\n");
                Console.WriteLine("========= NOTA FISCAL =========");
                Console.WriteLine("Valor sem desconto: R${0}", valorTotal.ToString("##.##"));
                valorDoDesconto = valorTotal * 0.03;
                valorFinal = valorTotal - valorDoDesconto;
                Console.WriteLine("Valor do desconto: R${0}", valorDoDesconto.ToString("##.##"));
                Console.WriteLine("Valor com desconto: R${0}", valorFinal.ToString("##.##"));
            }
            else
            {
                Console.WriteLine("\n");
                Console.WriteLine("========= NOTA FISCAL =========");
                Console.WriteLine("Valor sem desconto: R${0}", valorTotal.ToString("##.##"));
                valorDoDesconto = valorTotal * 0.05;
                valorFinal = valorTotal - valorDoDesconto;
                Console.WriteLine("Valor do desconto: R${0}", valorDoDesconto.ToString("##.##"));
                Console.WriteLine("Valor com desconto: R${0}", valorFinal.ToString("##.##"));
            }
            
            Console.WriteLine("Você comprou {0} unidades de {1}.",qntAdquirida,nomeProduto);
            Console.WriteLine("O valor final da compra é: R${0}", valorFinal.ToString("##.##"));

            Console.ReadKey();

        }
    }
}
