﻿using System;

namespace Unidade_VIII.Exercicio_Slide.Controle_de_Fluxo
{
    internal class _01_NotaAluno
    {
        public static void Main01(string[] args)
        {
            double nota;
            Random geradorNota = new Random();
            nota = geradorNota.NextDouble();
            nota = nota * 10;
            if (nota >= 7)
            {
                Console.WriteLine("Nota: {0}", nota.ToString("##.##"));
                Console.WriteLine("APROVADO ");
            }
            else
            {
                Console.WriteLine("Nota: {0}", nota.ToString("##.##"));
                Console.WriteLine("REPROVADO");
            }
            Console.ReadKey();
        }
    }
}