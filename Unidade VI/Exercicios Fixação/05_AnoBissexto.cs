using System;

namespace Unidade_VI.Exercicios_Fixação
{
    internal class _05_AnoBissexto
    {
        private static void Main05(string[] args)
        {
            //Escreva um algoritmo que receba um ano como parâmetro, e determine se é ou não bissexto.
            //Nota: são bissextos os anos múltiplos de 4 que não são múltiplos de 100 e ainda os anos múltiplos de 400.
            //Exemplo:  1996 e 2000 são bissextos, enquanto 1998 e 1900 são comuns.
            int ano;
            Console.WriteLine("Digite o ano para testar se e bissexto: ");
            ano = Convert.ToInt16(Console.ReadLine());
            if (ano % 4 == 0 && ano % 100 != 0 || ano % 400 == 0)
            {
                Console.WriteLine("O ano {0} é bissexto.", ano);
            }
            Console.ReadKey();
        }
    }
}