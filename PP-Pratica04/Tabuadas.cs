using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_Pratica04
{
    class Tabuadas
    {
        public void exibir()
        {
            Console.WriteLine("TABUADA DO 2\tTABUADA DO 3\tTABUADA DO 4\tTABUADA DO 5");
            int n = 1;
            for (int a = 1; a <= 10; a++)
            {
                for (int b = 2; b <= 5; b++)
                {
                    Console.Write("{0} X {1} = {2}\t", b, n, b * n);
                }
                Console.WriteLine();
                n++;
            }

            Console.WriteLine();
            Console.WriteLine("TABUADA DO 6\tTABUADA DO 7\tTABUADA DO 8\tTABUADA DO 9");
             n = 1;
            for (int a = 1; a <= 10; a++)
            {
                for (int b = 6; b <= 9; b++)
                {
                    Console.Write("{0} X {1} = {2}\t", b, n, b * n);
                }
                Console.WriteLine();
                n++;
            }


        }
    }
}
