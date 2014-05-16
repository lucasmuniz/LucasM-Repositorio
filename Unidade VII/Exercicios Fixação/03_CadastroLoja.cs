using System;

namespace Unidade_VII.Exercicios_Fixação
{
    internal class _03_CadastroLoja
    {
        public static int QntMercadoria;
        public static double ValorMercadoria, ValorTotal, MediaValores;

        public static void Main03(string[] args)
        {
            /*Uma loja está levantando o valor total de todas as mercadorias em estoque. Escreva um algoritmo que
              permita a entrada das seguintes informações:

            a) o número total de mercadorias no estoque;
            b) o valor de cada mercadoria.
              Ao final imprimir o valor total em estoque e a média de valor das mercadorias.
            */

            Console.Write("Digite o total de mercadorias no estoque: ");
            QntMercadoria = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= QntMercadoria; i++)
            {
                Console.Write("Digite o valor do produto {0}: ", i);
                ValorMercadoria = Convert.ToDouble(Console.ReadLine());
                if (ValorMercadoria < 0)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("NÃO EXISTE MERCADORIA COM VALOR NEGATIVO");
                    break;
                }
                ValorTotal = ValorTotal + ValorMercadoria;
            }
            MediaValores = ValorTotal / QntMercadoria;
            Console.WriteLine("\n");
            Console.WriteLine("============== RESULTADO ============\n");
            Console.WriteLine("O VALOR MEDIO É: R${0}", MediaValores.ToString("##.##"));
            Console.WriteLine("VALOR TOTAL : R${0}", ValorTotal);
            Console.WriteLine("ESTOQUE: {0} produtos", QntMercadoria);
            Console.ReadKey();
        }
    }
}