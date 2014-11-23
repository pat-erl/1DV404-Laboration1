using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrom___Patrik_Erlandsson
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;

            do
            {
                Console.Clear();

                Console.WriteLine("----------------------------------");
                Console.WriteLine("Testa om din text är ett palindrom");
                Console.WriteLine("----------------------------------\n");
                Console.Write("Skriv text: ");

                userInput = Console.ReadLine();

                foreach (char c in userInput)
                {
                    if (char.IsUpper(c) || char.IsDigit(c))
                    {
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("\nBara små bokstäver är tillåtna!\n", userInput);
                        Console.ResetColor();
                        break;
                    }
                    else
                    {
                        if (IsPalindrome(userInput) == false)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("\nDin text {0} är inte ett palindrom!\n", userInput);
                            Console.ResetColor();
                            break;
                        }
                        else
                        {
                            Console.BackgroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("\nDin text {0} är ett palindrom!\n", userInput);
                            Console.ResetColor();
                            break;
                        }
                    }
                }

                Console.WriteLine("Tryck på valfri tangent för att fortsätta!\n");
 
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
        public static bool IsPalindrome(string text)
        {
            char[] myArray = text.ToCharArray();
            Array.Reverse(myArray);
            string reverse = new string(myArray);
            return text == reverse;
        }
    }
}
