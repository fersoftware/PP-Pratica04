using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Elaborar um programa em C# que lê um número digitado pelo usuário e exibe
 * separadamente os dígitos que formam o número, de trás para frente. (não é para
 * usar vetor)
 * Exemplo:
 * Se o número digitado for 3459, o programa deverá exibir:
 * 9
 * 5
 * 4
 * 3 
 */

namespace PP_Pratica04
{
    class InverterNumero
    {
        public void exibir()
        {
            Console.WriteLine("Digite um número: ");
            int n = int.Parse(Console.ReadLine());           

            Console.WriteLine(n % 10);
            Console.WriteLine((n % 100) / 10);
            Console.WriteLine((n - ((n / 1000) * 1000)) / 100);
            Console.WriteLine((n / 1000));
        }
    }
}
