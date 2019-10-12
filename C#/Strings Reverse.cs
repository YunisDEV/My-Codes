using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASKK
{
    class Program
    {
        public static string Reverse(string a)
        {
            string str = "";
            for (int i = a.Length-1; i>=0; i++)
            {
                str +=a[i];
            }
            return str;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Reverse(Console.ReadLine()));
        }
    }
}
