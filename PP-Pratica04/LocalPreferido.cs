using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Elaborar um programa em C# que ajude a escolher qual o local preferido dos EUA
 * para o turista brasileiro passar as férias. Os lugares mais disputados são Orlando,
 * Nova York, São Francisco, Las Vegas. Seu programa deverá solicitar que o usuário
 * digite a quantidade de eleitores, que deverá ser um número maior do que zero.
 * Depois, seu programa deverá exibir o menu para que o eleitor vote nas cidades
 * citadas acima. Leia os votos e contabilize os votos usando uma estrutura
 * switch/case que compara strings. Exiba no final do programa qual a cidade mais
 * votada e a porcentagem de votos que cada cidade obteve.
 */

namespace PP_Pratica04
{
    class LocalPreferido
    {
        public void exbir()
        {
            int qtd;
            string maisVotado = "", opc;
            float orlando = 0, ny = 0, sf = 0, vegas = 0;
            do
            {
                Console.WriteLine("Digite a quantidade de eleitores");
                qtd = int.Parse(Console.ReadLine());
                if (qtd < 0) Console.WriteLine("Número Inválido");
            } while (qtd < 0);

            for (int i = 0; i < qtd; i++)
            {
                Console.WriteLine("****************************");
                Console.WriteLine("escolha 1 para  ORLANDO");
                Console.WriteLine("escolha 2 para  NOVA YORK");
                Console.WriteLine("escolha 3 para  SÃO FRANCISCO");
                Console.WriteLine("escolha 4 para  LAS VEGAS");
                Console.WriteLine("****************************");
                opc = Console.ReadLine();

                switch (opc)
                {
                    case "1":
                    case "ORLANDO":
                        orlando+=1;
                        if (orlando > ny && orlando > sf && orlando > vegas) maisVotado = "ORLANDO";
                        break;
                    case "2":
                    case "NOVA YORK":
                        ny += 1;
                        if (ny > orlando && ny > sf && ny > vegas) maisVotado = "NOVA YORK";
                        break;
                    case "3":
                    case "SÃO FRANCISCO":
                        sf += 1;
                        if (sf > orlando && sf > ny && sf > vegas) maisVotado = "SÃO FRANCISCO";
                        break;
                    case "4":
                    case "LAS VEGAS":
                        vegas += 1;
                        if (vegas > orlando && vegas > ny && vegas > sf) maisVotado = "LAS VEGAS";
                        break;
                    default:
                        Console.WriteLine("Opção Invalida");
                        break;
                }
            }
            
            Console.WriteLine("A CIDADE MAIS VOTADA FOI: {0}", maisVotado);
            Console.WriteLine();
            float porc = orlando < 1 ? 0 : (orlando / qtd) * 100;
            Console.WriteLine("ORLANDO: {0}% VOTOS", porc);
            porc = ny < 1 ? 0 : (ny / qtd) * 100;
            Console.WriteLine("NOVA YORK: {0}% VOTOS", (ny / qtd) * 100);
            porc = sf < 1 ? 0 : (sf / qtd) * 100;
            Console.WriteLine("SÃO FRANSICO: {0}% VOTOS", (sf / qtd) * 100);
            porc = vegas < 1 ? 0 : (vegas / qtd) * 100;
            Console.WriteLine("LAS VEGAS: {0}% VOTOS", (vegas / qtd) * 100);

        }
        
    }
}
