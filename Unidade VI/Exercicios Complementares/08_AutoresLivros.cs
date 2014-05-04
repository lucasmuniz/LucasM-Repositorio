using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade_VI.Exercicios_Complementares
{
    class _08_AutoresLivros
    {
        /*Quando se lista o nome de autores de livros, artigos e outras publicações é comum que se 
         * apresente o nome do autor ou dos autores da seguinte forma: sobrenome do autor em letras maiúsculas, 
         * seguido de uma vírgula e da primeira parte do nome apenas com as iniciais maiúsculas.
         * Por exemplo:
         * SILVA, Joao
         * COELHO, Paulo
         * ARAUJO, Celso de
         * Seu desafio é fazer um programa que leia um número inteiro correspondendo ao número de 
         * nomes que será fornecido, e, a seguir, leia estes nomes (que podem estar em qualquer tipo de letra) e 
         * imprima a versão formatada no estilo exemplificado acima.
         * */
        public static int numNomes;
        public static string primeiroNome, SegundoNome,segundoNomeUpper;
        public static void Main08(string[] args)
        {
            Console.WriteLine("Quantos autores são?");
            numNomes = Convert.ToInt16(Console.ReadLine());
            for (int i = 0; i <= numNomes; i++)
            {
                Console.WriteLine("Digite o primeiro nome: ");
                primeiroNome = Console.ReadLine();
                Console.WriteLine("Digite o segundo nome: ");
                SegundoNome = Console.ReadLine();
                segundoNomeUpper=SegundoNome.ToUpper();
                Console.WriteLine("");
                Console.WriteLine("{0},{1}",segundoNomeUpper, primeiroNome);
                Console.WriteLine("");      
            }

        }

    }
}
