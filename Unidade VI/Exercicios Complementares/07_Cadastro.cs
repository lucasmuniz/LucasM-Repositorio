﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade_VI.Exercicios_Complementares
{
    class _07_Cadastro
    {
        public static string nome,sair;
        public static double altura;
        public static int program;
        public static void Mai07(string[] args)
        {
            /*7) Escreva um programa que leia o primeiro nome e a altura das moças inscritas em um concurso de beleza.
             * Quando for informada a palavra FIM para o nome da moça o programa deverá ser encerrado e imprimir:
             * o nome e a altura da moça mais alta e o número de moças no concurso. 
             * Considere que todas as moças possuem altura diferente
             * */
            program = 1;
            while (program==1)
            {
                Console.WriteLine("Digite o nome: ");
                nome = Console.ReadLine();
                Console.WriteLine("Digite a altura: *Utilize com virgula, EX: 1,68* ");
                altura = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Deseja continuar o cadastro? (SIM/NAO)");
                sair = Console.ReadLine();
                if (sair == "NAO" || sair == "nao")
                {
                    program = 0;
                }

            }



        }
    }
}
