using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Elaborar um programa em C# que leia um número que deve ser maior ou igual a
 * zero e exiba o seu fatorial. Se o número for negativo, solicite novamente até que o
 * usuário digite um número maior ou igual a zero. Por definição, 0! = 1, 1! = 1, e se * o número for n > 1, então n! = 1 x 2 x 3 x ..... x n
 */
namespace PP_Pratica04
{
    class Fatorial
    {
        public void Exibir()
        {
            int n,fat;
            do
            {
                Console.WriteLine("Informe um número e conheça o seu fatorial:  ");
                n = int.Parse(Console.ReadLine());
                fat = n;
                if (n < 0) Console.WriteLine("Número Inválido");
            } while (n < 0 );

            for (int i = n - 1; i > 0; i--)
            {
                Console.Write("{0}",i);
                if (i != 1) Console.Write("X");
                fat *= i;
            }
            Console.WriteLine();
            Console.WriteLine("Valor Fatorial é {0}", fat);
        }
    }
}
