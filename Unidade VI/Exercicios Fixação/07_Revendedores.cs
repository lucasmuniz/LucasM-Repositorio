using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade_VI.Exercicios_Fixação
{
    class _07_Revendedores
    {
        public static string simOuNao;
        public static double comissaoPorCarro, salarioFinal, carroX, carroY, carroZ, continua = 0, salarioFinalX, salarioFinalY, salarioFinalZ;
        static void Main(string[] args)
        {
            //A revendedora de carros XYZ, paga a seus vendedores dois salários mínimos fixos,
            //e mais uma comissão fixa de $ 150,00 por carro vendido, e mais 5% do valor total das vendas do vendedor.
            //Determine o salário total de um vendedor, e mostre ao final, seu nome e seu salário total.

            //salario minimo hj 724,00

            string nomeVendedor, opc;
          
            

            Console.WriteLine("Digite o nome: ");
            nomeVendedor =Console.ReadLine();

            Console.WriteLine("Digite o valor do carro X: ");
            carroX = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor do carro Y: ");
            carroY = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor do carro Z: ");
            carroZ = Convert.ToDouble(Console.ReadLine());
            while (continua == 0)
            {


                Console.WriteLine("Qual carro voce vendeu? (X/Y/Z)");
                opc = Convert.ToString(Console.ReadLine());
                if (opc == "X"||opc=="x")
                {
                    comissaoPorCarro = carroX * 0.05;
                    salarioFinalX = comissaoPorCarro + 724 + 724 + 150;
                    
                }
                if (opc == "Y"||opc=="y")
                {
                    comissaoPorCarro = carroX * 0.05;
                    salarioFinalY = comissaoPorCarro + 724 + 724 + 150;                 
                }
                if (opc == "z"||opc=="Z")
                {
                    comissaoPorCarro = carroX * 0.05;
                    salarioFinalZ = comissaoPorCarro + 724 + 724 + 150;                 
                }
                
                if (continua==0)
                {
                    Console.WriteLine("Nome vendedor: {0}", nomeVendedor);
                    salarioFinal = salarioFinalX + salarioFinalY + salarioFinalZ;
                    Console.WriteLine("Seu salario final foi de : {0}", salarioFinal);
                    
                }
                
            }

        }
    }
}
