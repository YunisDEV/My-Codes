using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST
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
                for (int j = last + 1; k <= i; j++)
                {
                    Console.Write($"{j%2} ");
                    k++;
                    last = j;
                }
                Console.WriteLine();
            }
            Console.ReadKey();

        }
    }
}
