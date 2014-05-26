using System;

namespace Unidade_VI.Exercicios_Fixação
{
    internal class _02_DataValida
    {
        private static void Main02(string[] args)
        {
            /*2) Implemente um método que verifica se uma determinada data é válida ou não.
             * Lembre-se que Janeiro, Março, Maio, Julho, Agosto, Outubro e Dezembro possuem 31 dias; Abril, Junho, Setembro e
             * Novembro possuem 30 dias; e Fevereiro possui 28 dias em anos não bissextos e 29 dias em anos bissextos.*/
            int ano, dia;
            string mes;
            int janeiro = 31, marco = 31, maio = 31, julho = 31, agosto = 31, outubro = 31, dezembro = 31;
            int abril = 30, junho = 30, setembro = 30, novembro = 30, fevereiro = 0; ;
            Console.WriteLine("Digite o ano para testar se e bissexto: ");
            ano = Convert.ToInt16(Console.ReadLine());
            if (ano % 4 == 0 && ano % 100 != 0 || ano % 400 == 0)
            {
                fevereiro = 29;
            }
            else
            {
                fevereiro = 28;
            }
            Console.Write("Digite o dia: ");
            dia = Convert.ToInt16(Console.ReadLine());

            Console.Write("Digite o mês: (Formato: Janeiro/Fevereiro.) ");
            mes = Console.ReadLine();
            ConsultaMes(dia, mes, janeiro, marco, maio, julho, agosto, outubro, dezembro, abril, junho, setembro, novembro, fevereiro);
            Console.ReadKey();
        }

        private static void ConsultaMes(int dia, string mes, int janeiro, int marco, int maio, int julho, int agosto, int outubro, int dezembro, int abril, int junho, int setembro, int novembro, int fevereiro)
        {
            if (mes == "Janeiro" && dia <= janeiro)
            {
                Console.WriteLine("Data válida! ");
                return;
            }
            if (mes == "Fevereiro" && dia <= fevereiro)
            {
                Console.WriteLine("Data válida! ");
                return;
            }
            if (mes == "Março" && dia <= marco)
            {
                Console.WriteLine("Data válida! ");
                return;
            }
            if (mes == "Abril" && dia <= abril)
            {
                Console.WriteLine("Data válida! ");
                return;
            }
            if (mes == "Maio" && dia <= maio)
            {
                Console.WriteLine("Data válida! ");
                return;
            }
            if (mes == "Junho" && dia <= junho)
            {
                Console.WriteLine("Data válida! ");
                return;
            }
            if (mes == "Julho" && dia <= julho)
            {
                Console.WriteLine("Data válida! ");
                return;
            }
            if (mes == "Agosto" && dia <= agosto)
            {
                Console.WriteLine("Data válida! ");
                return;
            }
            if (mes == "Setembro" && dia <= setembro)
            {
                Console.WriteLine("Data válida! ");
                return;
            }
            if (mes == "Outubro" && dia <= outubro)
            {
                Console.WriteLine("Data válida! ");
                return;
            }
            if (mes == "Novembro" && dia <= novembro)
            {
                Console.WriteLine("Data válida! ");
                return;
            }
            if (mes == "Dezembro" && dia <= dezembro)
            {
                Console.WriteLine("Data válida! ");
                return;
            }

            Console.WriteLine("DIA INVÁLIDO");
        }
    }
}