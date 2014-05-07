using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade_VII.Exercicios_Fixação
{
    class _01_Produtos
    {
        public static double media_Aritmetica, codigo_Produto, maior_Preco=0,valor_Produto,soma_Todos;
        public static void Main01(string[] args)
        {
            /*1) Faça um algoritmo para ler o código e o preço de 15 produtos, calcular e escrever: 
            - o maior preço lido 
            - a média aritmética dos preços dos produtos.
             */
            for (int i = 0; i <=14 ; i++)
            {
                Console.Write("Digite o código do Produto: ");
                codigo_Produto = Convert.ToInt16(Console.ReadLine());
                Console.Write("Digite o valor do produto numero {0}: ",i);
                valor_Produto = Convert.ToDouble(Console.ReadLine());
                soma_Todos = soma_Todos + valor_Produto;
                if (valor_Produto>maior_Preco)
                {
                    maior_Preco = valor_Produto;
                }
            }
            media_Aritmetica = soma_Todos / 15;
            Console.WriteLine("============== RESULTADO =============\n");
            Console.WriteLine("A média aritmetica de todos os produtos lidos é: {0}\n",media_Aritmetica.ToString("##.##"));
            Console.WriteLine("O maior preço digitado é: {0}",maior_Preco);

            Console.ReadKey();

        }
    }
}
