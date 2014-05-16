using System;

namespace Unidade_VI.Exercicios_Complementares
{
    internal class _07_Cadastro
    {
        public static string Nome, Sair, NomeMaisAlta = null;
        public static double Altura, MaisAlta = 0;
        public static int Program;

        public static void Main06(string[] args)
        {
            /*7) Escreva um programa que leia o primeiro nome e a altura das moças inscritas em um concurso de beleza.
             * Quando for informada a palavra FIM para o nome da moça o programa deverá ser encerrado e imprimir:
             * o nome e a altura da moça mais alta e o número de moças no concurso.
             * Considere que todas as moças possuem altura diferente
             */
            Program = 1;
            while (Program == 1)
            {
                Console.WriteLine("Digite o nome: ");
                Nome = Console.ReadLine();
                Console.WriteLine("Digite a altura: *Utilize com virgula, EX: 1,68* ");
                Altura = Convert.ToDouble(Console.ReadLine());
                if (Altura > MaisAlta)
                {
                    MaisAlta = Altura;
                    NomeMaisAlta = Nome;
                }
                Console.WriteLine("Deseja continuar o cadastro? (SIM/NAO)");
                Sair = Console.ReadLine();
                if (Sair == "NAO" || Sair == "nao")
                {
                    Console.WriteLine("A mais alta é: {0} e tem uma altura de : {1} ", NomeMaisAlta, MaisAlta);
                    Program = 0;
                }
            }
            Console.ReadKey();
        }
    }
}