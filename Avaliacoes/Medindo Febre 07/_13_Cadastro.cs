using System;

namespace Avaliacoes.Medindo_Febre_07
{
    internal class _13_Cadastro
    {
        public static double PorcentagemAdultos, PorcentagemNaoAdultos, ContMasculino, ContFeminino, TotalPessoas, TotalAdultos, TotalNaoAdultos;
        public static double PorcentagemMasculino, PorcentagemFeminino, PorcentagemMaisAltos, ContAltos, PessoaMaisAlta = 0, PessoaMaisBaixa = 2;
        public static double MaisVelhos = 0, MaisNovos = 100;
        public static int[] idade = new int[50];
        public static string[] nome = new string[50];
        public static int[] sexo = new int[50];
        public static string[] sexoFormatado = new string[50];
        public static double[] altura = new double[50];
        public static bool[] adulto = new bool[50];
        public static Random gerador = new Random();

        public static void Main(string[] args)
        {
            /*13) Implemente um algoritmo que armazene a idade, nome, sexo, altura, se é adulto ou não. Esses vetores devem ter 50 posições cada um.
             * O algoritmo deve ter métodos ou funções para inicializar seus vetores com os dados, os valores de idade, altura, sexo e se é adulto ou
             * não, podem ser gerados aletoriamente. OK
            - A porcentagem dos que são adultos e dos que não são; OK
            - A porcentagem do sexo masculino e feminino; OK
            - A porcentagem dos mais altos que 1,70m; OK
            - Listar todos da seguinte maneira:  Nome: Thiago Sartor, Idade: 23, Sexo: ‘M’, Adulto: true OK
            - Listar os 10 mais velhos;
            - Listar os 5 mais novos;
            - Listar a pessoa mais alta; OK
            - Listar a pessoa mais baixa; OK      */

            IdadePessoa();
            NomePessoa();
            SexoPessoa();
            AlturaPessoa();
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine("Nome: {0}, Idade: {1}, Sexo: {2}, Adulto: {3}. ", nome[i], idade[i], sexoFormatado[i], adulto[i]);
            }

            Porcentagens();
            Console.WriteLine("");
            Console.WriteLine("============= RESULTADOS ==============\n");
            Console.WriteLine("Porcentagem Adultos: {0}%", PorcentagemAdultos);
            Console.WriteLine("Porcentagem Não Adultos: {0}%", PorcentagemNaoAdultos);
            Console.WriteLine("");
            Console.WriteLine("Porcentagem Masculinos: {0}%", PorcentagemMasculino);
            Console.WriteLine("Porcentagem Femininos: {0}%", PorcentagemFeminino);
            Console.WriteLine("");
            Console.WriteLine("A pessoa mais alta possui: {0}m.", PessoaMaisAlta.ToString("##.##"));
            Console.WriteLine("A pessoa mais baixa possui: {0}m.", PessoaMaisBaixa.ToString("##.##"));
            Console.WriteLine("");
            Console.WriteLine("A idade da pessoa mais velha é: {0} anos.", MaisVelhos);
            Console.WriteLine("A idade da pessoa mais nova é: {0} anos.", MaisNovos);

            Console.ReadKey();
        }

        private static void Porcentagens()
        {
            //Adultos ou não.
            PorcentagemAdultos = (TotalAdultos * 2);
            PorcentagemNaoAdultos = (TotalNaoAdultos * 2);

            //Masculino ou não.
            PorcentagemMasculino = (ContMasculino * 2);
            PorcentagemFeminino = (ContFeminino * 2);

            //Mais altos.
            PorcentagemMaisAltos = ContAltos * 2;
        }

        private static void AlturaPessoa()
        {
            for (int m = 0; m < altura.Length; m++)
            {
                altura[m] = gerador.NextDouble();
                altura[m] = altura[m] + 1;
                if (altura[m] > PessoaMaisAlta)
                {
                    PessoaMaisAlta = altura[m];
                }
                if (altura[m] < PessoaMaisBaixa)
                {
                    PessoaMaisBaixa = altura[m];
                }
                if (altura[m] >= 1.70)
                {
                    ContAltos++;
                }
            }
        }

        private static void SexoPessoa()
        {
            for (int l = 0; l < sexo.Length; l++)
            {
                sexo[l] = gerador.Next(0, 2);
                if (sexo[l] == 0)
                {
                    sexoFormatado[l] = "Masculino";
                    ContMasculino++;
                }
                else if (sexo[l] == 1)
                {
                    sexoFormatado[l] = "Feminino";
                    ContFeminino++;
                }
            }
        }

        private static void NomePessoa()
        {
            for (int k = 0; k < nome.Length; k++)
            {
                nome[k] = "Teste" + k;
            }
        }

        private static void IdadePessoa()
        {
            for (int j = 0; j < idade.Length; j++)
            {
                TotalPessoas++;
                idade[j] = gerador.Next(1, 100);

                if (idade[j] < MaisNovos)
                {
                    MaisNovos = idade[j];
                }

                if (idade[j] > MaisVelhos)
                {
                    MaisVelhos = idade[j];
                }

                if (idade[j] >= 18)
                {
                    adulto[j] = true;
                    TotalAdultos++;
                }
                else if (idade[j] < 18)
                {
                    adulto[j] = false;
                    TotalNaoAdultos++;
                }
            }
        }
    }
}