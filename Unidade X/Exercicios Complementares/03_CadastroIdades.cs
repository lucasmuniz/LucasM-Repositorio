using System;

namespace Unidade_X.Exercicios_Complementares
{
    internal class _03_CadastroIdades
    {
        public static int SomaIdades;

        public static void Main(string[] args)
        {
            /*3) Implemente um método que verifique a idade de 20 pessoas, um para comparar a maior idade, um para menor idade,
             * outro para fazer a média de todas as 20 idades e por fim imprimir todos esses dados. (5 métodos)*/
            int maiorIdade = 0, menorIdade = 100, mediaIdades = 0, idade = 0;
            for (int i = 1; i <= 20; i++)
            {
                Console.Write("Digite a idade da pessoa numero {0}: ", i);
                idade = Convert.ToInt16(Console.ReadLine());
                SomaIdades = SomaIdades + idade;
                maiorIdade = TestaMaiorIdade(maiorIdade, idade);
                menorIdade = TestaMenorIdade(menorIdade, idade);
            }
            mediaIdades = MediaDasIdades(mediaIdades);
            Console.WriteLine("=========== RESULTADOS ==========\n");
            Console.WriteLine("Média das idades: {0}", mediaIdades);
            Console.WriteLine("Maior idade: {0}", maiorIdade);
            Console.WriteLine("Menor idade: {0}", menorIdade);
            Console.ReadKey();
        }

        private static int MediaDasIdades(int mediaIdades)
        {
            mediaIdades = SomaIdades / 20;
            return mediaIdades;
        }

        private static int TestaMenorIdade(int menorIdade, int idade)
        {
            if (idade < menorIdade)
            {
                menorIdade = idade;
            }
            return menorIdade;
        }

        private static int TestaMaiorIdade(int maiorIdade, int idade)
        {
            if (idade > maiorIdade)
            {
                maiorIdade = idade;
            }
            return maiorIdade;
        }
    }
}