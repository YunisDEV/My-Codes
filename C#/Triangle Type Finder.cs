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
           
            while (true)
            {
                Console.Clear();
                Console.WriteLine("First side:");
                int a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Second Side:");
                int b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Third side:");
                int c = Convert.ToInt32(Console.ReadLine());

                if (a + b < c || a + c < b || b + c < a)
                {
                    Console.WriteLine("Triangle does not follow rules");
                }
                else
                {
                    if (Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2)) == c || Math.Sqrt(Math.Pow(a, 2) + Math.Pow(c, 2)) == b || Math.Sqrt(Math.Pow(c, 2) + Math.Pow(b, 2)) == a)
                    {
                        Console.WriteLine("Right Triangle");
                        
                        if (Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2)) == c)
                        {
                            double S = (a * b) / 2;
                            Console.WriteLine($"Area :{S}");
                        }
                        else if (Math.Sqrt(Math.Pow(a, 2) + Math.Pow(c, 2)) == b)
                        {
                            double S = (a * c) / 2;
                            Console.WriteLine($"Area :{S}");
                        }
                        else if (Math.Sqrt(Math.Pow(c, 2) + Math.Pow(b, 2)) == a)
                        {
                            double S = (b * c) / 2;
                            Console.WriteLine($"Area :{S}");
                        }
                    }

                    else if (a == b && a == c && b == c)
                    {
                        Console.WriteLine("Equilateral Triangle");
                        double p = (a + b + c) / 2;
                        double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                        Console.WriteLine($"Area :{S}");
                    }

                    else if (a != b && a != c && b != c)
                    {
                        Console.WriteLine("Scalene Triangle");
                        double p = (a + b + c) / 2;
                        double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                        Console.WriteLine($"Area :{S}");
                    }

                    else if (a == b || a == c || b == c)
                    {
                        Console.WriteLine("Isosceles Triangle");
                        double p = (a + b + c) / 2;
                        double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                        Console.WriteLine($"Area :{S}");
                    }
                }
                Console.ReadLine();
            }
            
        }
    }
}
