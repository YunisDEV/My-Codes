using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONSOLE_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = 2;
            int h = 10;
            int place = 0;
            int day = 0;
            int i = 0;
            if (a > b)
            {
                while (i==0)
                {
                    day++;
                    place += a;
                    if (place >= h)
                    {
                        Console.WriteLine(day);
                        i = 1;
                    }
                    place -= b;

                }
                Console.ReadLine();
            }
        }
    }
}
