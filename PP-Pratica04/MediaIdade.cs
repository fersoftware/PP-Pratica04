using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Elaborar um programa em C# que solicita que o usuário digite um número n entre
 * 1 e 10. Enquanto o usuário não fornecer um número entre 1 e 10, o programa
 * deve solicitar novamente. Em seguida, o programa deve solicitar que o usuário
 * digite n idades. O programa deverá depois exibir a média das idades lidas, a
 * maior idade lida e a menor idade lida. (Não é para usar vetor)
 * Exemplo:
 * Digite a quantidade de idades (entre 1 e 10): 13
 * Valor não permitido!
 * Digite a quantidade de idades (entre 1 e 10): 3
 * Digite 3 idades:
 * 20
 * 15
 * 30
 * Média das idades: 21,66
 * Maior idade: 30
 * Menor idade: 15 
 */
namespace PP_Pratica04
{
    class MediaIdade
    {
        public void exibir()
        {
            int n;
            float idade,maior,menor,somaidade=0;
            do
            {
                Console.Write("Digite a quantidade de idades(entre 1 e 10):");
                n = int.Parse(Console.ReadLine());
                if (n < 1 || n > 10) Console.WriteLine("Valor não permitido!");
            } while (n < 1 || n > 10);

            Console.Write("Digite {0} idade(s):", n);
            idade = int.Parse(Console.ReadLine());
            somaidade += idade;
            maior = idade;
            menor = idade;
            n--;

            if( n > 1)
            {
                for (int i = n; i > 0; i--)
                {
                    Console.Write("Digite {0} idade(s):", i);
                    idade = int.Parse(Console.ReadLine());
                    somaidade += idade;                    

                    if(idade < maior)
                    {
                        if (idade < menor) menor = idade;
                    }
                    else
                    {
                        maior = idade;
                    }
                }
                n++;
            }
            float media = somaidade / n;
            Console.WriteLine("Média das idades: {0:F}", media);
            Console.WriteLine("Maior idade: {0}", maior);
            Console.WriteLine("Menor idade: {0}", menor);
        }
    }
}
