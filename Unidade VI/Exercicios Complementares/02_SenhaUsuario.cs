using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade_VI.Exercicios_Complementares
{
    class SenhaUsuario
    {
       public static void Main(string[] args)
        {
            /*2) Escreva um programa que verifique a validade de uma senha fornecida pelo usuário. A senha válida é o número
             *  NomeUsuário123. Devem ser impressas as seguintes mensagens: 
                ACESSO PERMITIDO caso a senha seja válida. 
                ACESSO NEGADO caso a senha seja inválida.
            */
            string senhaTeste;
            Console.WriteLine("Digite a senha: ");
            senhaTeste = Console.ReadLine();
            if (senhaTeste!="Lucas123")
            {
                Console.WriteLine("ACESSO NEGADO");
            }
            else
            {
                Console.WriteLine("ACESSO PERMITIDO");
            }
            Console.ReadKey();
        }
    }
}
