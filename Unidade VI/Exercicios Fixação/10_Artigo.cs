using System;

namespace Unidade_VI.Exercicios_Fixação
{
    internal class _10_Artigo
    {
        // Uma pessoa comprou quatro artigos em uma loja. Para cada artigo, tem-se
        //nome, preço e percentual de desconto. Faça um algoritmo que imprima nome,
        //preço e preço com desconto de cada artigo e o total a pagar.

        private static void Main10(string[] args)
        {
            string artigo1, artigo2, artigo3, artigo4;
            double valor1, valor2, valor3, valor4, desc1, desc2, desc3, desc4, tot1, tot2, tot3, tot4, preco1, preco2, preco3, preco4;
            Console.WriteLine("Informe o nome do artigo 1: ");
            artigo1 = Console.ReadLine();
            Console.WriteLine("Informe o valor do artigo 1: ");
            valor1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a porcentagem de desconto: ");
            desc1 = Convert.ToDouble(Console.ReadLine());
            tot1 = valor1 * desc1;
            preco1 = valor1 - tot1;

            Console.WriteLine("Informe o nome do artigo 2: ");
            artigo2 = Console.ReadLine();
            Console.WriteLine("Informe o valor do artigo 2: ");
            valor2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a porcentagem de desconto: ");
            desc2 = Convert.ToDouble(Console.ReadLine());
            tot2 = valor2 * desc2;
            preco2 = valor2 - tot2;

            Console.WriteLine("Informe o nome do artigo 3: ");
            artigo3 = Console.ReadLine();
            Console.WriteLine("Informe o valor do artigo 3: ");
            valor3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a porcentagem de desconto: ");
            desc3 = Convert.ToDouble(Console.ReadLine());
            tot3 = valor3 * desc3;
            preco3 = valor3 - tot3;

            Console.WriteLine("Informe o nome do artigo 4: ");
            artigo4 = Console.ReadLine();
            Console.WriteLine("Informe o valor do artigo 4: ");
            valor4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a porcentagem de desconto: ");
            desc4 = Convert.ToDouble(Console.ReadLine());
            tot4 = valor4 * desc4;
            preco4 = valor4 - tot4;

            Console.WriteLine("O valor do artigo 1: {0}", preco1);
            Console.WriteLine("O valor do artigo 2: {0}", preco2);
            Console.WriteLine("O valor do artigo 3: {0}", preco3);
            Console.WriteLine("O valor do artigo 4: {0}", preco4);

            Console.ReadKey();
        }
    }
}