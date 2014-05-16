using System;

namespace Unidade_VI.Exercicios_Fixação
{
    internal class _07_Revendedores
    {
        public static string NomeVendedor, Opc;
        public static double ComissaoPorCarro, SalarioFinal, CarroX,CarroY, CarroZ, Continua = 0, SalarioFinalX, SalarioFinalY, SalarioFinalZ;

        private static void Main07(string[] args)
        {
            //A revendedora de carros XYZ, paga a seus vendedores dois salários mínimos fixos,
            //e mais uma comissão fixa de $ 150,00 por carro vendido, e mais 5% do valor total das vendas do vendedor.
            //Determine o salário total de um vendedor, e mostre ao final, seu nome e seu salário total.
            //salario minimo hj 724,00
            Console.WriteLine("Digite o nome: ");
            NomeVendedor = Console.ReadLine();
            Console.WriteLine("Digite o valor do carro X: ");
            CarroX = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor do carro Y: ");
            CarroY = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor do carro Z: ");
            CarroZ = Convert.ToDouble(Console.ReadLine());
            while (Continua == 0)
            {
                Console.WriteLine("Qual carro voce vendeu? (X/Y/Z)");
                Opc = Convert.ToString(Console.ReadLine());
                if (Opc == "X" || Opc == "x")
                {
                    ComissaoPorCarro = CarroX * 0.05;
                    SalarioFinalX = ComissaoPorCarro + 724 + 724 + 150;
                }
                if (Opc == "Y" || Opc == "y")
                {
                    ComissaoPorCarro = CarroX * 0.05;
                    SalarioFinalY = ComissaoPorCarro + 724 + 724 + 150;
                }
                if (Opc == "z" || Opc == "Z")
                {
                    ComissaoPorCarro = CarroX * 0.05;
                    SalarioFinalZ = ComissaoPorCarro + 724 + 724 + 150;
                }

                if (Continua == 0)
                {
                    Console.WriteLine("Nome vendedor: {0}", NomeVendedor);
                    SalarioFinal = SalarioFinalX + SalarioFinalY + SalarioFinalZ;
                    Console.WriteLine("Seu salario final foi de : {0}", SalarioFinal);
                }
            }
        }
    }
}