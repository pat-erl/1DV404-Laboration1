using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaknaA___Patrik_Erlandsson
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            int countUpperCase = 0;
            int countLowerCase = 0;

            Console.Write("Mata in en textrad: ");
            userInput = Console.ReadLine();

            foreach (char c in userInput)
            {
                if (c == 'A')
                {
                    countUpperCase++;
                }
                if (c == 'a')
                {
                    countLowerCase++;
                }
            }
            Console.WriteLine("\nAntal A: {0}\nAntal a: {1}\n", countUpperCase, countLowerCase);
        }
    }
}
