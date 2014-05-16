using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaliacoes.Medindo_a_Febre_05
{
    class _08_GerenteBanco
    {
        public static int Hora,ContPessoas;
        public static void Main08(string[]args)
        {
           
            for (int i = 0; i <= 9; i++)
            {
                Console.WriteLine("Digite o horário que você entrou no banco: USE FORMATO 24HRS ");
                Hora = Convert.ToInt32(Console.ReadLine());
                if (Hora >= 10 && Hora <= 16)
                {
                    ContPessoas++;
                }
                if (Hora < 0 || Hora > 24)
                {
                    Console.WriteLine("HORA INVALIDA");
                    break;
                }           
            }
            Console.WriteLine("\n");
            Console.WriteLine("O total que entraram no banco no intervalo de horas foi: {0} pessoas.",ContPessoas);

            Console.ReadKey();

        }
    }
}
