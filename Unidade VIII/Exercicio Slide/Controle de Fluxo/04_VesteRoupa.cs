﻿using System;

namespace Unidade_VIII.Exercicio_Slide.Controle_de_Fluxo
{
    internal class _04_VesteRoupa
    {
        public static void Main04(string[] args)
        {
            Random gerador = new Random();
            double numero = gerador.NextDouble();
            numero = numero * 10;
            if (numero >= 5)
            {
                Console.WriteLine("NUMERO: {0}", numero);
                Console.WriteLine("VERMELHA");
            }
            else
            {
                Console.WriteLine("NUMERO: {0}", numero);
                Console.WriteLine("AZUL");
            }
            Console.ReadKey();
        }
    }
}