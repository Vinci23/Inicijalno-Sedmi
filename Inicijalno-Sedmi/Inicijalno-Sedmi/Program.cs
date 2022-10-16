using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inicijalno_Sedmi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool prim = false;
            int primBr = 0;

            for (int i=1; i<=100; i++)
            {

                for (int j=2; j<=100; j++)
                {
                    if (i!=j && i%j==0)
                    {
                        prim = false;
                        break;
                    }
                }
                if (prim)
                {
                    primBr++;
                }
                prim = true;

            }
            Console.WriteLine(primBr);
            Console.ReadKey();
        }
    }
}
