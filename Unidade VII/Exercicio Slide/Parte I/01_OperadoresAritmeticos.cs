using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade_VII.Exercicio_Slide
{
    class _01_OperadoresAritmeticos
    {
        public static void Main01(string[] args)
        {


            int n1, n2;
            double a,b;
            Console.WriteLine("Digite o n1: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o n2: ");
            n2 = Convert.ToInt32(Console.ReadLine());
            a= Math.Pow(n1, n2);
            b= n1%n2;

            Console.WriteLine("SOMA => {0}",n1+n2);
            Console.WriteLine("DIVISAO => {0}",n1/n2);
            Console.WriteLine("MULTIPLICAÇÃO => {0}",n1*n2);
            Console.WriteLine("SUBTRAÇÃO => {0}",n1-n2);
            Console.WriteLine("Potenciação => {0}",a);
            Console.WriteLine("Resto da divisão => {0}",b);
            Console.ReadKey();


        }
    }
}
