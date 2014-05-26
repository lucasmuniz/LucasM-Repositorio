using System;

namespace Unidade_VI.Exercicios_Fixação
{
    internal class _01_AnoBissexto
    {
        private static void Main01(string[] args)
        {
            /*1) Implemente um método que determina seu ano é ou não é bissexto. As regras para determinar se um ano é bissexto são:

              1. Anos múltiplos de 4 são bissextos.
              2. Anos múltiplos de 100 não são bissextos.
              3. Anos múltiplos de 400 são bissextos.
              4. As últimas regras prevalecem sobre as primeiras.
              */
            int ano;
            Console.WriteLine("Digite o ano para testar se é bissexto: ");
            ano = Convert.ToInt16(Console.ReadLine());
            TestaBissexto(ano);
            Console.ReadKey();
        }

        private static void TestaBissexto(int ano)
        {
            if (ano % 4 == 0 && ano % 100 != 0 || ano % 400 == 0)
            {
                Console.WriteLine("O ano {0} é bissexto.", ano);
            }
            else
            {
                Console.WriteLine("O ano {0} não é bissexto!", ano);
            }
        }
    }
}