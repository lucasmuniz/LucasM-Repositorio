﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade_VIII.Exercicio_Slide.Controle_de_Fluxo
{
    class _03_EscolhaCaminho
    {
        public static void Main03(string[] args)
        {
            Random gerador = new Random();
            double numero = gerador.NextDouble();
            numero = numero * 10;
            if (numero>=5)
            {
                Console.WriteLine("NUMERO: {0}",numero);
                Console.WriteLine("DIREITA");
            }
            else
            {
                Console.WriteLine("NUMERO: {0}",numero);
                Console.WriteLine("ESQUERDA");
            }
            Console.ReadKey();
        }
    }
}
