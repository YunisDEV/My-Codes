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
            int result = 0;
            int input;
            for (int i = 1; i <= 10; i++)
            {
                input = Convert.ToInt32(Console.ReadLine());
                if (input%2!=0)
                {
                    result += input;
                }
            }
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
