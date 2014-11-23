using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaknaSiffror___Patrik_Erlandsson
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                string userInput;
                int countZero = 0;
                int countOdd = 0;
                int countEven = 0;

                Console.Clear();
                Console.Write("Mata in ett heltal: ");

                try
                {
                    userInput = (Console.ReadLine());
                    int number = int.Parse(userInput);

                    if (number > 0)
                    {
                        foreach (char c in userInput)
                        {
                            if (c == 0)
                            {
                                countZero++;
                            }
                            else if (c % 2 != 0)
                            {
                                countOdd++;
                            }
                            else
                            {
                                countEven++;
                            }
                        }
                        Console.WriteLine("\nNollor: {0}\nUdda: {1}\nJämna: {2}\n", countZero, countOdd, countEven);
                    }
                    else
                    {
                        Console.WriteLine("\nHeltalet måste vara större än 0\n");
                    }
                }
                catch
                {
                    Console.WriteLine("\nKan inte tolkas som ett heltal\n");
                }

                Console.WriteLine("Tryck tangent för att fortsätta!");

            }while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
