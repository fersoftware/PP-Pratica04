using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Elabore um programa em C# que solicite que o usuário digite 10 números. Exiba
 * qual foi o menor número e qual foi o maior número digitado. (Não é para usar vetor)
 */

namespace PP_Pratica04
{
    class MenorMaior
    {
        public void exibir()
        {
            int x, menor = 0, maior = 0;            
            Console.Write("1 - Digite um número:");
            x = int.Parse(Console.ReadLine());
            menor = x;
            maior = x;
            for (int i = 1; i < 4; i++)
            {
                Console.Write("{0} - Digite um número: ", i+1);                
                x = int.Parse(Console.ReadLine());
                if (x <= maior)
                {
                    if(x < menor) menor = x;
                }
                else
                {
                    maior = x;
                }                
            }
            Console.WriteLine("Maior número: {0}", maior);
            Console.WriteLine("Menor número: {0}", menor);
        }
    }
}
