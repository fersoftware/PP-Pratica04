using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Elabore um programa em C# que exiba todos os múltiplos de 3 entre 3 e 100, * usando o comando for.*/

namespace PP_Pratica04
{
    class Multiplo
    {
        public void Multiplos()
        {
            for (int i = 3; i <= 100; i+=3)
            {
                Console.WriteLine(i);
            }
        }
    }
}
