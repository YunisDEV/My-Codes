using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONSOLE_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.INT in duzgun yazilisi");
            Console.WriteLine("  a)int x = 10;");
            Console.WriteLine("  b)float x = 10;");
            Console.WriteLine("  c)int 1x = 10;");
            Console.WriteLine("  d)int x = \"10\";\n\n Cavabi Daxil Edin:");
            char answer = Convert.ToChar(Console.ReadLine());
            switch (answer)
            {
                case 'a':
                    Console.Clear();
                    Console.WriteLine("DUZGUNDUR!!!");
                    break;

                case 'b':
                case 'c':
                case 'd':
                    Console.Clear();
                    Console.WriteLine("YANLISDIR!!!");
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("BELE BIR CAVAB YOXDUR!!!");
                    break;

            }
            Console.ReadKey();
        }
    }
}
