using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade_VI.Exercicios_Fixação
{
    class _06_Consorcio
    {
        static void Main06(string[] args)
        {
            //Considerando que para um consórcio, sabe-se o número total de prestações, 
            //a quantidade de prestações pagas e o valor da prestação. Calcular e mostrar o valor total pago e o saldo devedor.

            int numero_Parcelas, quantidade_Pagas, valor_Prestacao,total_pago,valorTotal,saldo_devedor;
            Console.WriteLine("Digite o total de parcelas que contem o consórcio: ");
            numero_Parcelas = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Digite o valor de cada prestação: ");
            valor_Prestacao = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Digite quantas parcelas voce ja pagou: ");
            quantidade_Pagas = Convert.ToInt16(Console.ReadLine());

            total_pago = quantidade_Pagas * valor_Prestacao;
            valorTotal = numero_Parcelas * valor_Prestacao;
            saldo_devedor = valorTotal - total_pago;
            Console.WriteLine("====== RESULTADO ======");
            Console.WriteLine("Saldo devedor: {0}",saldo_devedor);
            Console.WriteLine("Total pago: {0}",total_pago);
            Console.ReadKey();
        }
    }
}
