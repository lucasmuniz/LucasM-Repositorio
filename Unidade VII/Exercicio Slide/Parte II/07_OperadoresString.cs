using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade_VII.Exercicio_Slide.Parte_II
{
    class _07_OperadoresString
    {
        public static void Main(string[] args)
        {
            //=========== DESCOBRE A QUANTIDADE DE CARACTERE DA STRING ===========
            /*

            string s = "Nome da Pessoa";
            int lenght = s.Length;
            Console.WriteLine(lenght);

            Console.ReadKey();
            
            */



            //========= RECUPERAR UM CARACTERE DE ACORDO COM A POSICAO DA STRING ===========
            /*
            string s = "Nome da Pessoa";
            char d = s[0];
             *
            Console.WriteLine(d); //LETRA N
             
            */


            //========= VERIFICAR SE O CARACTERE ESTÁ CONTIDO OU NAO NA STRING ============
            /*

              string s = "Apostila de Java";
              bool resultado1 = s.Contains("C#");
              bool resultado2 = s.Contains("Java");

            //false
              Console.WriteLine(resultado1);

            //true
              Console.WriteLine(resultado2);

              Console.ReadKey();
            
           */


            //======== VERIFICAR SE O CARACTER TERMINA COM A STRING DO PARAMETRO ===========
            /*
            string s = "Apostila de C#";
            bool resultado1 = s.EndsWith("Java"); //termina com....
            bool resultado2 = s.EndsWith("C#");

            Console.ReadKey();
            */


            //======= VERIFICA SE COMEÇA COM O CARACTERE ==============
            /*
            string s = "Apostila de C#";
            bool resultado1 = s.StartsWith("Apostila");
            bool resultado2 = s.StartsWith("C#");

            Console.ReadKey();
            */


            //======= PODEMOS EXTRAIR UM TRECHO DE UMA STRING ========
            /*

            string s1 = " Thiago Sartor ";

            string s2 = s1.Substring(7); // Pos 7
            string s3 = s1.Substring(0, 6); //0 ate 6
            string s4 = s1.Substring(1);
            string s5 = s1.Substring(1, 1);

            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);
            Console.WriteLine(s5);
               
            Console.ReadKey();
            */


            //=========== ELIMINAR O ESPAÇO EM BRANCO DAS EXTREMIDADES==========
            /*
            string s1 = "   Thiago Sartor  ";
            string s2 = s1.Trim();
            Console.WriteLine(s2);

            Console.ReadKey();
            */

            //======== DATAS ===================
            /*
             
            DateTime dt = new DateTime(2010, 08, 27);
            // Acrescentando 140 dias
            dt = dt.AddDays(140);

            // Subtraindo 2 anos
            dt = dt.AddYears(-2);

            // Acrescentando 20 segundos
            dt = dt.AddSeconds(20);

            Console.ReadKey();
             
           */
            
        


        }
    }
}
