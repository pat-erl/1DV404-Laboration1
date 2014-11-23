using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_3b___fraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputA1;
            int inputA2;
            int inputB1;
            int inputB2;

            do
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("SKAPA TVÅ BRÅKTAL");
                    Console.Write("\nSkriv täljaren i det första bråktalet: ");
                    inputA1 = int.Parse(Console.ReadLine());
                    Console.Write("Skriv nämnaren i det första bråktalet: ");
                    inputA2 = int.Parse(Console.ReadLine());
                    Console.Write("\nSkriv täljaren i det andra bråktalet: ");
                    inputB1 = int.Parse(Console.ReadLine());
                    Console.Write("Skriv nämnaren i det andra bråktalet: ");
                    inputB2 = int.Parse(Console.ReadLine());

                    Fraction fractionA = new Fraction(inputA1, inputA2);
                    Fraction fractionB = new Fraction(inputB1, inputB2);

                    Console.Clear();
                    Console.WriteLine("Bråktal 1: {0}\nBråktal 2: {1}", fractionA, fractionB);
                    Console.WriteLine("\nTESTER");
                    Console.WriteLine("-----------------------------");

                    bool checkedIfNegA = Fraction.IsNegative(fractionA);
                    bool checkedIfNegB = Fraction.IsNegative(fractionB);

                    if(checkedIfNegA == true)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.Write("Bråktal 1 är negativt\n");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Console.Write("Bråktal 1 är positivt\n");
                        Console.ResetColor();
                    }

                    if (checkedIfNegB == true)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.Write("Bråktal 2 är negativt\n");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Console.Write("Bråktal 2 är positivt\n");
                        Console.ResetColor();
                    }

                    Fraction added = new Fraction();
                    added.Add(fractionA, fractionB);
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.Write("\nBråktalen adderade blir: {0}\n", added);

                    Fraction multiplied = new Fraction();
                    multiplied.Multiply(fractionA, fractionB);
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.Write("\nBråktalen multiplicerade blir: {0}\n", multiplied);

                    bool compared = Fraction.IsEqualTo(fractionA, fractionB);
                    if(compared == true)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("\nBråktalen är likadana");
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("\nBråktalen är inte likadana");
                    }
                    Console.ResetColor();
                    Console.WriteLine("-----------------------------");
                }
                catch(ArgumentOutOfRangeException)
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("\nNämnaren måste vara minst 1!");
                }
                catch
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("\nKan inte tolkas som ett heltal!");
                }
                Console.ResetColor();
                Console.WriteLine("\nTryck tangent för att fortsätta!\n");

            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
