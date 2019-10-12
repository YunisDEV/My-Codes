using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) {
                Console.Clear();
                Console.Write("Enter the number of day:");
                long a = Convert.ToInt64(Console.ReadLine());
                if (a > 7)
                {
                    a %= 7;
                }
                if (a > 0 && a <= 7)
                {
                    if (a == 1)
                    {
                        Console.WriteLine("Monday");
                    }
                    else if (a == 2)
                    {
                        Console.WriteLine("Tuesday");
                    }
                    else if (a == 3)
                    {
                        Console.WriteLine("Wednesday");
                    }
                    else if (a == 4)
                    {
                        Console.WriteLine("Thursday");
                    }
                    else if (a == 5)
                    {
                        Console.WriteLine("Friday");
                    }
                    else if (a == 6)
                    {
                        Console.WriteLine("Saturday");
                    }
                    else if (a == 7)
                    {
                        Console.WriteLine("Sunday");
                    }
                }
                Console.ReadKey();
            }
            }
            
        }
    }
}
