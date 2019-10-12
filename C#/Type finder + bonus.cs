using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                #region Booleans
                bool isDigit = true;
                bool isAlpha = true;
                bool isSpec = true;
                bool isUpper = true;
                #endregion


                Console.Clear();

                #region Input
                Console.Write("INPUT:");
                string input = "";
                input = Console.ReadLine();
                Console.Clear();
                #endregion

                #region If Null
                if (input == "")
                {
                    Console.WriteLine("NULL");
                    Console.WriteLine();
                    for (int i = 1; i <= 9; i++)
                    {
                        for (int a = i; a > 0; a--)
                        {
                            Console.Write("*");
                        }
                        Console.Write("\n");
                    }
                    for (int i = 10; i >= 0; i--)
                    {
                        for (int a = i; a > 0 ; a--)
                        {
                            Console.Write("*");
                        }
                        Console.Write("\n");
                    }
                }
                #endregion

                #region Finding Type
                else
                {
                    for (int i = 0; i < input.Length; i++)
                    {
                        char character_string = Convert.ToChar(input[i]);
                        if (character_string >= '0' && character_string <= '9')
                        {
                            isDigit = Convert.ToBoolean(Convert.ToInt32(isDigit) * Convert.ToInt32(true));
                            isAlpha = Convert.ToBoolean(Convert.ToInt32(isAlpha) * Convert.ToInt32(false));
                            isSpec = Convert.ToBoolean(Convert.ToInt32(isSpec) * Convert.ToInt32(false));
                            isUpper = Convert.ToBoolean(Convert.ToInt32(isUpper) * Convert.ToInt32(false));
                        }
                        else if (character_string >= 'a' && character_string <= 'z')
                        {
                            isDigit = Convert.ToBoolean(Convert.ToInt32(isDigit) * Convert.ToInt32(false));
                            isAlpha = Convert.ToBoolean(Convert.ToInt32(isAlpha) * Convert.ToInt32(true));
                            isSpec = Convert.ToBoolean(Convert.ToInt32(isSpec) * Convert.ToInt32(false));
                            isUpper = Convert.ToBoolean(Convert.ToInt32(isUpper) * Convert.ToInt32(false));
                        }
                        else if (character_string >= 'A' && character_string <= 'Z')
                        {
                            isDigit = Convert.ToBoolean(Convert.ToInt32(isDigit) * Convert.ToInt32(false));
                            isAlpha = Convert.ToBoolean(Convert.ToInt32(isAlpha) * Convert.ToInt32(false));
                            isSpec = Convert.ToBoolean(Convert.ToInt32(isSpec) * Convert.ToInt32(false));
                            isUpper = Convert.ToBoolean(Convert.ToInt32(isUpper) * Convert.ToInt32(true));
                        }
                        else
                        {
                            isDigit = Convert.ToBoolean(Convert.ToInt32(isDigit) * Convert.ToInt32(false));
                            isAlpha = Convert.ToBoolean(Convert.ToInt32(isAlpha) * Convert.ToInt32(false));
                            isSpec = Convert.ToBoolean(Convert.ToInt32(isSpec) * Convert.ToInt32(true));
                            isUpper = Convert.ToBoolean(Convert.ToInt32(isUpper) * Convert.ToInt32(false));
                        }
                    }
                    #endregion

                    #region Finalize
                    if (isDigit)
                    {
                        Console.WriteLine("NUMBER:\n");
                        Console.WriteLine(Convert.ToInt32(input) + 1);
                    }
                    else if (isAlpha)
                    {
                        Console.WriteLine("Lower case STRING:\n");
                        Console.WriteLine(input + "*");
                    }
                    else if (isUpper)
                    {
                        Console.WriteLine("Upper case STRING:\n");
                        Console.WriteLine(input + "**");
                    }
                    else if (isSpec)
                    {
                        Console.WriteLine("SPECIAL:\n");
                        Console.WriteLine(input + "//");
                    }
                    else
                    {
                        Console.WriteLine("MIXED:\n");
                        Console.WriteLine("--" + input + "--");
                    }
                    #endregion

                }
                Console.ReadLine();
            }
        }
    }
}
