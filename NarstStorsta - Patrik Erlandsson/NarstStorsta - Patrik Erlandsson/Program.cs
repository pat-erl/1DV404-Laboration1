using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NarstStorsta___Patrik_Erlandsson
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                int largestNumber = 0;
                int secondLargestNumber = 0;
                int temporaryNumber = 0;
                int temporaryNumber2 = 0;

                Console.Clear();

                for (int count = 1; count <= 10; count++)
                {
                    try
                    {
                        Console.Write("Mata in heltal {0} av 10: ", count);
                        temporaryNumber = int.Parse(Console.ReadLine());

                        if (count == 1)
                        {
                            temporaryNumber = largestNumber;
                        }
                        else if (count == 2)
                        {
                            if (temporaryNumber > largestNumber)
                            {
                                temporaryNumber2 = largestNumber;
                                secondLargestNumber = largestNumber;
                                largestNumber = temporaryNumber;
                            }
                            else
                            {
                                secondLargestNumber = temporaryNumber;
                            }
                        }
                        else
                        {
                            if (temporaryNumber > secondLargestNumber && temporaryNumber < largestNumber)
                            {
                                secondLargestNumber = temporaryNumber;
                            }
                            else if (temporaryNumber > largestNumber)
                            {
                                temporaryNumber2 = largestNumber;
                                secondLargestNumber = largestNumber;
                                largestNumber = temporaryNumber;
                            }
                        }
                    }
                    catch
                    {
                        Console.WriteLine("\nKan ej tolkas som ett heltal!\n");
                        count--;
                    }
                }

                Console.WriteLine("\nDet näst största talet är: {0}\n", secondLargestNumber);
                Console.WriteLine("Tryck tangent för att fortsätta!\n");

            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
