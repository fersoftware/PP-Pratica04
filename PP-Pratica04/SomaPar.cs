using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Elabore um programa em C# que solicite que o usuário digite um número par. Se
 * o número digitado não for par, solicite novamente até que o número digitado seja
 * par. Depois solicite que o usuário digite um outro número par, que deve ser maior
 * do que o primeiro número. Se o segundo número não por par ou se for menor ou
 * igual ao primeiro, solicite que o usuário digite novamente, até que o número
 * digitado seja par e maior do que o primeiro. Exiba todos os números pares que há
 * entre os 2 números digitados, em ordem decrescente 
 */

namespace PP_Pratica04
{
    class SomaPar
    {
        public void exibir()
        {
            int num, num2;
            do
            {
                Console.Write("Digite um número par: ");
                num = int.Parse(Console.ReadLine());
                if (num % 2 != 0) Console.WriteLine("O número digitado não é PAR");
            } while (num %2 != 0);

            do
            {                
                Console.Write("Digite outro número par: ");
                num2 = int.Parse(Console.ReadLine());
                if (num2%2!=0) Console.WriteLine("O número digitado não é PAR");
                if (num > num2) Console.WriteLine("O número é menor que o primeiro");
            } while (num2 %2 !=0 || num > num2);

            for (int i = num2; i >= num; i-=2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
