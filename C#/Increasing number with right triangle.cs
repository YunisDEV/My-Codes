using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONSOLE_APP
{
    class Program
    {
        static void Main(string[] args)
        {

            int last = 0;
            int k;
            for (int i = 0; i <= 3; i++)
            {
                k = 0;
                for (int j = last+1; k <= i; j++)
                {
                    Console.Write($"{j} ");
                    k++;
                    last = j;
                }
                Console.WriteLine();
            }

               Console.WriteLine(result);
            }




            Console.ReadKey();
        }
    }
}
