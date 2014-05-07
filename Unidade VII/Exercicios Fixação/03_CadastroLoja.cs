using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade_VII.Exercicios_Fixação
{
    class _03_CadastroLoja
    {
        public static int qntMercadoria;
        public static double valorMercadoria, valorTotal,mediaValores;
        public static void Main(string[]args)
        {
            /*Uma loja está levantando o valor total de todas as mercadorias em estoque. Escreva um algoritmo que 
              permita a entrada das seguintes informações: 
              
            a) o número total de mercadorias no estoque; 
            b) o valor de cada mercadoria.
              Ao final imprimir o valor total em estoque e a média de valor das mercadorias.  
            */

            Console.Write("Digite o total de mercadorias no estoque: ");
            qntMercadoria = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= qntMercadoria; i++)
            {
                Console.Write("Digite o valor do produto {0}: ",i);
                valorMercadoria = Convert.ToDouble(Console.ReadLine());
                if (valorMercadoria<0)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("NÃO EXISTE MERCADORIA COM VALOR NEGATIVO");
                    break;
                }
                valorTotal = valorTotal + valorMercadoria;
            }
            mediaValores = valorTotal / qntMercadoria;
            Console.WriteLine("\n");
            Console.WriteLine("============== RESULTADO ============\n");              
            Console.WriteLine("O VALOR MEDIO É: R${0}",mediaValores.ToString("##.##"));
            Console.WriteLine("VALOR TOTAL : R${0}", valorTotal);
            Console.WriteLine("ESTOQUE: {0} produtos", qntMercadoria);
            Console.ReadKey();
        }
    }
}
