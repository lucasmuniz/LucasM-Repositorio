using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidade_VII.Exercicios_Fixação
{
    class _05_Piramide
    {

        public static string[] Vetor;
        public static void Main05(string[] args)
        {
           
            /* Faça o programa que apresenta a seguinte saída, perguntando ao usuário o número máximo (no exemplo, 9). 
             * Este número deve ser sempre ímpar.

                1 2 3 4 5 6 7 8 9
                  2 3 4 5 6 7 8
                    3 4 5 6 7
                      4 5 6
                        5  
            */          
           Console.WriteLine("Digite o número máximo");
           int numMaximo = Convert.ToInt16(Console.ReadLine());
           int contador = 0;
           Vetor = new string [numMaximo];
           for (int i = 0; i < numMaximo; i++)
           {
               int valor = i + 1;
               Vetor[i] = valor.ToString();
               Console.Write(Vetor[i]+" ");
               contador++;   
           }
           Console.WriteLine("");
           if (contador>=8)
           {
               for (int i = 0; i < numMaximo; i++)
               {
                   Vetor[0] = " ";
                   Vetor[numMaximo - 1] = " ";
                   Console.Write(Vetor[i] + " ");
                   contador++;             
               }
           }
           Console.WriteLine("");
           if (contador>=18)
           {
               for (int i = 0; i <numMaximo; i++)
               {
                   Vetor[1] = " ";
                   Vetor[numMaximo - 2] = " ";
                   Console.Write(Vetor[i] + " ");
                   contador++;
               }
           }
           Console.WriteLine("");
           if (contador >= 27)
           {
               for (int i = 0; i < numMaximo; i++)
               {
                   Vetor[2] = " ";
                   Vetor[numMaximo - 3] = " ";
                   Console.Write(Vetor[i] + " ");
                   contador++;
               }
           }
           Console.WriteLine("");
           if (contador >= 35)
           {
               for (int i = 0; i < numMaximo; i++)
               {
                   Vetor[3] = " ";
                   Vetor[numMaximo - 4] = " ";
                   Console.Write(Vetor[i] + " ");
                   contador++;
               }
           }                 
           Console.ReadKey(); 
        }
    }
}
