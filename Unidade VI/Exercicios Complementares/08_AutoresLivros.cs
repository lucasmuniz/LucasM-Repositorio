using System;

namespace Unidade_VI.Exercicios_Complementares
{
    internal class _08_AutoresLivros
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
        public static int NumNomes;
        public static char PrimeiraLetra;
        public static string PrimeiroNome, SegundoNome, SegundoNomeUpper;

        public static void Main(string[] args)
        {
            Console.WriteLine("Quantos autores são?");
            NumNomes = Convert.ToInt16(Console.ReadLine());
            for (int i = 0; i <= NumNomes; i++)
            {
                Console.WriteLine("Digite o primeiro nome: ");
                PrimeiroNome = Console.ReadLine();
                PrimeiraLetra = char.ToUpper(PrimeiroNome[0]);
                Console.WriteLine("Digite o segundo nome: ");
                SegundoNome = Console.ReadLine();
                SegundoNomeUpper = SegundoNome.ToUpper();
                Console.WriteLine("");
                Console.WriteLine("{0}, {1}{2}", SegundoNomeUpper, PrimeiraLetra, PrimeiroNome.Substring(1));
                Console.WriteLine("");
            }
        }
    }
}