using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade_VII.Exercicio_Slide.Parte_II
{
    class _04_OperadorTernario
    {
        public static void Main04(string[] args)
        {
            //====================== EXEMPLO 1 =====================

            double nota;
            nota = Convert.ToDouble(Console.ReadLine());
            string resultado = nota >= 0.5 ? "aprovado" : "reprovado";
            Console.WriteLine(resultado);


            //====================== EXEMPLO 2 =====================

            int i = nota >= 0.5 ? 1 : 2;
            Console.WriteLine(nota);

            Console.ReadKey();
        }
    }
}
