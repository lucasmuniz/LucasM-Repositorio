using System;

namespace Unidade_VII.Exercicios_Fixação
{
    internal class _01_Produtos
    {
        public static double Media_Aritmetica, Codigo_Produto, Maior_Preco = 0, Valor_Produto, Soma_Todos;

        public static void Main01(string[] args)
        {
            /*1) Faça um algoritmo para ler o código e o preço de 15 produtos, calcular e escrever:
            - o maior preço lido
            - a média aritmética dos preços dos produtos.
             */
            for (int i = 0; i <= 14; i++)
            {
                Console.Write("Digite o código do Produto: ");
                Codigo_Produto = Convert.ToInt16(Console.ReadLine());
                Console.Write("Digite o valor do produto numero {0}: ", i);
                Valor_Produto = Convert.ToDouble(Console.ReadLine());
                Soma_Todos = Soma_Todos + Valor_Produto;
                if (Valor_Produto > Maior_Preco)
                {
                    Maior_Preco = Valor_Produto;
                }
            }
            Media_Aritmetica = Soma_Todos / 15;
            Console.WriteLine("============== RESULTADO =============\n");
            Console.WriteLine("A média aritmetica de todos os produtos lidos é: {0}\n", Media_Aritmetica.ToString("##.##"));
            Console.WriteLine("O maior preço digitado é: {0}", Maior_Preco);

            Console.ReadKey();
        }
    }
}