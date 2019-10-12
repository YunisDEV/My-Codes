using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.Write("Eded daxil edin:");
                int a = Convert.ToInt32(Console.ReadLine());
                double result = 1;
                if (a == 0)
                {
                    result = 1;
                    Console.WriteLine(result);
                }
                else if (a==128)
                {
                    for (int i = 0; i <=30; i++)
                    {
                        result = 1;
                        if (i==0)
                        {
                            Console.WriteLine($"0   1");
                            continue;
                        }
                        for (int j = 1; j <= i; j++)
                        {
                            result *= j;
                        }
                        Console.WriteLine($"{i}   {result}");
                    }
                }
                else if (a < 0)
                {
                    Console.WriteLine("Menfi ededlerin faktoriali yoxdur!");
                }
                else
                {
                    for (int i = a; i >= 1; i--)
                    {
                        result *= i;
                    }
                    Console.WriteLine(result);
                }
                Console.ReadKey();
            }
        }
    }
}
