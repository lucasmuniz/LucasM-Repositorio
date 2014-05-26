using System;

namespace Avaliacoes.Medindo_a_Febre_05
{
    internal class _07_IdadeAdulta
    {
        public static void Main07(string[] args)
        {
            int idade;
            Console.Write("Digite a idade: ");
            idade = Convert.ToInt16(Console.ReadLine());
            if (idade < 0)
            {
                Console.WriteLine("IDADE INVALIDA!");
            }
            else if (idade == 0)
            {
                Console.WriteLine("VOCE NAO PODE TER IDADE IGUAL A ZERO!");
            }
            Console.WriteLine("\n");
            Console.WriteLine("======== RESULTADO ========");
            string resultado = idade >= 21 ? "Adulta" : "Não é adulta";
            Console.WriteLine(resultado);
            Console.WriteLine("E sua idade é: {0} Anos", idade);

            Console.ReadKey();
        }
    }
}